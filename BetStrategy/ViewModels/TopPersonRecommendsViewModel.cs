using BetStrategy.Common.Configurations;
using BetStrategy.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using System.Windows.Threading;
using WSQ.CSharp.Extensions;
using WSQ.CSharp.Helper;
using WSQ.CSharp.Net;
using System.Linq;
using GalaSoft.MvvmLight;
using BetStrategy.Utils;
using System.Windows;
using BetStrategy.Windows;

namespace BetStrategy.ViewModels
{
    public class TopPersonRecommendsViewModel : BaseViewModel
    {
        private PreferResultToStringConverter converter = new PreferResultToStringConverter();

        private ObservableCollection<Recommend> _recommends = new ObservableCollection<Recommend>();

        #region BINDABLE PROPERTIES
        private bool _isChecked = true;
        public bool CheckBoxIsChecked
        {
            get
            {
                return _isChecked;
            }
            set
            {
                _isChecked = value;
                NotifyPropertyChange(() => CheckBoxIsChecked);
                EnableAutoRefresh(_isChecked);
            }
        }

        private void EnableAutoRefresh(bool flag)
        {
            if (!flag)
            {
                _timerRefreshRecommends.Stop();
            }
            else
            {
                _timerRefreshRecommends.Start();
                RefreshRecommends(null, null);
            }
        }

        private bool _isPreferMostChecked = true;
        public bool CheckBoxPreferMostIsChecked
        {
            get
            {
                return _isPreferMostChecked;
            }
            set
            {
                _isPreferMostChecked = value;
                NotifyPropertyChange(() => CheckBoxPreferMostIsChecked);
                ReloadList();
            }
        }

        private Person _person = null;
        public Person SelectedProfitPerson
        {
            get { return _person; }
            set
            {
                var p = value as Person;
                if (p != null && p.Profit > 0)
                {
                    Constants.Instance.COUNT_MIN_PROFIT = p.Profit;
                }
                _person = value;

                ReloadList();
            }
        }

        private bool _enableEmail = false;
        public bool EnableEmailNotify
        {
            get
            {
                return _enableEmail;
            }
            set
            {
                _enableEmail = value;
                NotifyPropertyChange(() => EnableEmailNotify);
            }
        }
        #endregion

        #region BINDABLE COLLECTIONS
        private List<Recommend> AllRecommends = new List<Recommend>();
        public ObservableCollection<Recommend> Recommends
        {
            get
            {
                return _recommends;
            }
        }

        private ObservableCollection<Person> _topWinsList = new ObservableCollection<Person>();
        public ObservableCollection<Person> TopPersonWinsList
        {
            get
            {
                return _topWinsList;
            }
        }
        #endregion

        #region COMMANDS
        private ICommand _cmdRefresh;
        public ICommand CommandRefresh
        {
            get
            {
                if (_cmdRefresh == null)
                {
                    _cmdRefresh = new RelayCommand(() =>
                    {
                        DownloadRecommends();
                    });
                }
                return _cmdRefresh;
            }
        }

        private ICommand _cmdViewYield;
        public ICommand CommandViewYield
        {
            get
            {
                if (_cmdViewYield == null)
                {
                    _cmdViewYield = new RelayCommand(() =>
                    {
                        ShowYieldWindow();
                    });
                }
                return _cmdViewYield;
            }
        }

        private Window YieldView;
        private void ShowYieldWindow()
        {
            if (YieldView == null)
            {
                YieldView = new YieldRoiWindow();
                YieldView.Closed += (o, e) => { YieldView = null; };
            }
            YieldView.Show();
            YieldView.Activate();
        }

        private ICommand _viewPerson = null;
        public ICommand CommandViewPerson
        {
            get
            {
                if (_viewPerson == null)
                {
                    _viewPerson = new RelayCommand<Recommend>(ViewPerson);
                }
                return _viewPerson;
            }
        }
        #endregion

        private void ReloadList()
        {
            _recommends.Clear();
            if (SelectedProfitPerson != null || _isPreferMostChecked)
            {
                foreach (var item in AllRecommends)
                {
                    if (IsTopPerson(item.Person))
                    {
                        _recommends.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in AllRecommends)
                {
                    _recommends.Add(item);
                }
            }
        }

        private List<Person> TopPerson = new List<Person>();
        private void DownloadRecommends()
        {
#if PUBLISH
            ParseHtml(TestData.GAME_SHOW_HTML);
#else
            NetworkUtils.DownloadString(Constants.Instance.URL_BASE + Constants.Instance.URL_GAME_SHOW, (ok, html, error) =>
            {
                if (ok)
                {
                    ParseHtml(html);
                }
            });
#endif
        }

        private void ParseHtml(string html)
        {
            HtmlParser.ParseRecommends(html, (rs) =>
            {
                FileHelper.SaveRecommends(rs);
                (new Action(() =>
                {
                    AddRecommends(rs);
                })).RunOnUI();
            });
        }

        private void AddRecommends(List<Recommend> rs)
        {
            NotifyBalloonTip(rs);
            AllRecommends.Clear();
            foreach (var item in rs)
            {
                AllRecommends.Add(item);
            }
            ReloadList();
            App.Icon.Text = DateTime.Now.ToString("HH:mm:ss") + ":高手推荐了" + AllRecommends.Count((i) => IsTopPerson(i.Person)) + "条,一共有" + _recommends.Count + "条推荐,点击查看";
            if (EnableEmailNotify)
            {
                NotifyViaEmail();
            }
        }

        private void NotifyBalloonTip(List<Recommend> rs)
        {
            var newRecommends = (from item in rs where IsTopNewRecommend(item) select item).Except(from item in AllRecommends select item);
            string recs = RecommendsToString(newRecommends);
            if (!string.IsNullOrEmpty(recs))
            {
                App.Icon.ShowBalloonTip(5 * 60 * 1000, "高手有" + newRecommends.Count() + "条新推荐", recs, System.Windows.Forms.ToolTipIcon.Info);
            }
        }

        private bool IsTopNewRecommend(Recommend item)
        {
            return IsTopPerson(item.Person) && item.PreferResult == PreferResult.Waiting;
        }

        private string RecommendsToString(IEnumerable<Recommend> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.AppendLine(RecommendToString(item));
            }
            return sb.ToString();
        }

        private string RecommendToString(Recommend item)
        {
            string body = item.Person + " 推荐了: "
                    + item.Host + " "
                    + item.OddStake + " "
                    + item.Odds.ToString() + " "
                    + item.Guest + " 推荐:" + item.Prefer;
            return body;
        }

        private void NotifyViaEmail()
        {
            string subject = "高手们推荐啦:" + DateTime.Now.ToLongDateString();
            string recs = RecommendsToString(AllRecommends.Where((i) => IsTopPerson(i.Person)));
            if (!string.IsNullOrEmpty(recs))
            {
                try
                {
                    EmailHelper.SendEmailViaGmail(EmailConfig.Instance.Username, EmailConfig.Instance.ToAddress, EmailConfig.Instance.Username, EmailConfig.Instance.Password, subject, recs);
                }
                catch (System.Exception ex)
                {
                    App.Icon.Text = "你的邮件配置好像是出问题了.要不就是你的网络发不出去邮件.尝试修改配置后重启吧.\n" + ex.Message;
                    EnableEmailNotify = false;
                }
            }
            else
            {
                App.Icon.Text = "你选择的高手们还没有推荐哦.是不是你要求太苛刻了?";
            }
        }

        private bool IsTopPerson(string name)
        {
            if (_isPreferMostChecked)
            {
                return TopPersonProvider.Instance.PreferMost.Contains(name);
            }
            else
            {
                var personInTopPerson = TopPerson.FindLast((i) => i.Name == name);
                return personInTopPerson != null && personInTopPerson.Profit >= Constants.Instance.COUNT_MIN_PROFIT;
            }
        }

        private static TopPersonRecommendsViewModel _instance;
        public static TopPersonRecommendsViewModel Instance
        {
            get
            {
                lock (typeof(TopPersonRecommendsViewModel))
                {
                    if (_instance == null)
                    {
                        _instance = new TopPersonRecommendsViewModel();
                    }
                }
                return _instance;
            }
        }

        private DispatcherTimer _timerRefreshRecommends = null;
        private TopPersonRecommendsViewModel()
        {
            _timerRefreshRecommends = new DispatcherTimer();
            _timerRefreshRecommends.Interval = new TimeSpan(0, Constants.Instance.INT_MINUTES_UPDATE_RECOMMEND, 30);
            _timerRefreshRecommends.Tick += RefreshRecommends;
            _timerRefreshRecommends.Start();
        }

        public void StartUpdate()
        {
            GetTopPerson();
        }

        private static DateTime LastTimeUpdatePerson;
        private void GetTopPerson()
        {
            TopPersonProvider.Instance.GetTopPerson((last, persons) =>
            {
                if (last == LastTimeUpdatePerson)
                    return;
                LastTimeUpdatePerson = last;
                (new Action(() =>
                {
                    TopPerson.Clear();
                    List<Person> bestPerson = new List<Person>();
                    foreach (var p in persons)
                    {
                        TopPerson.Add(p);
                        if (!bestPerson.Any((t) => t.Profit == p.Profit) && p.Profit > 0)
                        {
                            bestPerson.Add(p);
                        }
                    }

                    bestPerson.Sort(new Comparison<Person>((Person p, Person q) =>
                    {
                        return q.Profit.CompareTo(p.Profit);
                    }));

                    foreach (var item in bestPerson)
                    {
                        _topWinsList.Add(item);
                    }

                    if (TopPerson.Count > 0)
                    {
                        DownloadRecommends();
                    }
                })).RunOnUI();
            });
        }

        private void RefreshRecommends(object sender, EventArgs e)
        {
            DownloadRecommends();
        }

        public void Sort(string sortBy, ListSortDirection direction)
        {
            List<Recommend> rms = new List<Recommend>();
            foreach (var rec in _recommends)
            {
                rms.Add(rec);
            }
            if (sortBy == "Person.Name")
            {
                rms.Sort(new Comparison<Recommend>(delegate(Recommend x, Recommend y)
                    {
                        int result = 0;
                        /* fixme
                                    if (x.Person.Profit > y.Person.Profit)
                                        result = 1;
                                    if (x.Person.Profit < y.Person.Profit)
                                        result = -1;*/
                        return (direction == ListSortDirection.Descending ? -1 : 1) * result;
                    }));
            }
            else
            {
                Comparison<Recommend> com = rms[0].ComparerFromProperty(sortBy, direction == ListSortDirection.Descending);
                rms.Sort(com);
            }

            _recommends.Clear();
            foreach (var item in rms)
            {
                _recommends.Add(item);
            }
        }

        private string PersonString(Person p)
        {
            return string.Format("净胜{0}场:{1}推{2}胜{3}半胜{4}走{5}半负{6}负", p.Profit, p.Total, p.Win, p.WinHalf, p.Draw, p.LoseHalf, p.Lose);
        }

        private Dictionary<string, Window> Windows = new Dictionary<string, Window>();
        private void ViewPerson(Recommend obj)
        {
            Window window = null;
            if (Windows.ContainsKey(obj.Person))
            {
                window = Windows[obj.Person];
                window.Activate();
            }
            else
            {
                window = new PersonRecommendsWindow();
                var vm = new PersonRecommendsViewModel();
                window.DataContext = vm;
                window.Loaded += (o, e) => vm.Load(obj.Person);
                window.Closed += (o, e) => { Windows.Remove(obj.Person); };
                Windows[obj.Person] = window;
                window.Show();
            }
        }
    }
}
