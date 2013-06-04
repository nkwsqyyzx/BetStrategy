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
    public class PersonRecommendsViewModel : BaseViewModel
    {
        private PreferResultToStringConverter converter = new PreferResultToStringConverter();

        private ObservableCollection<Recommend> _recommends = new ObservableCollection<Recommend>();

        #region BINDABLE PROPERTIES
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
        private ICommand _cmdRefresh = null;
        public ICommand CommandRefresh
        {
            get
            {
                return _cmdRefresh.RelayCommand(() => RefreshRecommends());
            }
        }

        private ICommand _cmdViewYield = null;
        public ICommand CommandViewYield
        {
            get
            {
                return _cmdViewYield.RelayCommand(() => ShowYieldWindow());
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
                return _viewPerson.RelayCommand<Recommend>((rec) => ViewHelper.ViewPerson(rec.Person));
            }
        }
        #endregion

        private void ReloadList()
        {
            _recommends.Clear();
            if (SelectedProfitPerson != null || _isPreferMostChecked)
            {
                AllRecommends.Enumerate((i) => IsTopPerson(i.Person), (j) => _recommends.Add(j));
            }
            else
            {
                AllRecommends.ForEach((i) => _recommends.Add(i));
            }
        }

        private List<Person> TopPerson = new List<Person>();

        private void AddRecommends(List<Recommend> rs)
        {
            NotifyBalloonTip(rs);
            AllRecommends.Clear();
            AllRecommends.AddRange(rs);
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

        private static PersonRecommendsViewModel _instance;
        public static PersonRecommendsViewModel Instance
        {
            get
            {
                lock (typeof(PersonRecommendsViewModel))
                {
                    if (_instance == null)
                    {
                        _instance = new PersonRecommendsViewModel();
                    }
                }
                return _instance;
            }
        }

        public PersonRecommendsViewModel()
        {
            StartUpdate();
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
                        RefreshRecommends();
                    }
                })).RunOnUI();
            });
        }

        private void RefreshRecommends(object sender, EventArgs e)
        {
            RefreshRecommends();
        }

        private void RefreshFinish()
        {
            AllRecommends.Sort(AllRecommends[0].ComparerFromProperty("Time2", true));
            var list = new List<Recommend>();
            var top200 = AllRecommends.Take(200);
            foreach (var i in top200)
            {
                list.Add(i);
            }
            AllRecommends.Clear();
            AllRecommends.AddRange(list);
            new Action(() => ReloadList()).RunOnUI();
        }

        private void RefreshRecommends()
        {
            AllRecommends.Clear();
            FileHelper.GetAllWaitingRecommends((rec) => AllRecommends.Add(rec), RefreshFinish);
        }

        public void Sort(string sortBy, ListSortDirection direction)
        {
            List<Recommend> rms = new List<Recommend>();
            foreach (var rec in _recommends)
            {
                rms.Add(rec);
            }
            if (sortBy == "Person.Name")
            { }
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

        public void Load(int count)
        {
        }
    }
}