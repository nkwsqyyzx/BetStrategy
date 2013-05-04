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

namespace BetStrategy.ViewModels
{
    public class TopPersonRecommendsViewModel : BaseViewModel
    {
        private PreferResultToStringConverter converter = new PreferResultToStringConverter();

        private ObservableCollection<Recommend> _recommends = new ObservableCollection<Recommend>();

        private List<Recommend> AllRecommends = new List<Recommend>();
        public ObservableCollection<Recommend> Recommends
        {
            get
            {
                return _recommends;
            }
        }

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

        private ObservableCollection<Person> _topWinsList = new ObservableCollection<Person>();
        public ObservableCollection<Person> TopPersonWinsList
        {
            get
            {
                return _topWinsList;
            }
        }

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

        private void ReloadList()
        {
            _recommends.Clear();
            if (SelectedProfitPerson != null)
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

        private List<Person> TopPerson = new List<Person>();
        private void DownloadRecommends()
        {

            NetworkUtils.DownloadString(Constants.Instance.URL_BASE + Constants.Instance.URL_GAME_SHOW, (ok, html, error) =>
            {
                if (ok)
                {
                    HtmlParser.HtmlParser.ParseRecommends(html, (rs) =>
                    {
                        UiDispatcher.BeginInvoke(new Action(() =>
                        {
                            AllRecommends.Clear();
                            foreach (var item in rs)
                            {
                                AllRecommends.Add(item);
                            }
                            ReloadList();
                            App.Icon.Text = "高手推荐了" + AllRecommends.Count((i) => IsTopPerson(i.Person)) + "条,一共有" + _recommends.Count + "条推荐,点击查看";
                            if (EnableEmailNotify)
                            {
                                NotifyViaEmail();
                            }
                        }));
                    });
                }
            });
        }

        private string RecommendToString(Recommend item)
        {
            string body = item.Person.Name + " 推荐了: "
                    + item.Host.TeamName + " "
                    + item.OddStake.Description + " "
                    + item.Odds.ToString() + " "
                    + item.Guest.TeamName + " 推荐:" + item.Prefer.Description;
            return body;
        }

        private void NotifyViaEmail()
        {
            string subject = "高手们推荐啦:" + DateTime.Now.ToLongDateString();
            StringBuilder sb = new StringBuilder();
            foreach (var item in AllRecommends)
            {
                if (IsTopPerson(item.Person))
                {
                    sb.AppendLine(RecommendToString(item));
                }
            }
            if (sb.Length > 0)
            {
                EmailHelper.SendEmailViaGmail(EmailConfig.Instance.Username, EmailConfig.Instance.ToAddress, EmailConfig.Instance.Username, EmailConfig.Instance.Password, subject, sb.ToString());
            }
            else
            {
                App.Icon.Text = "你选择的高手们还没有推荐哦.是不是你要求太苛刻了?";
            }
        }

        private bool IsTopPerson(Person p)
        {
            var personInTopPerson = TopPerson.FindLast((i) => i.Name == p.Name);
            return personInTopPerson != null && personInTopPerson.Profit >= Constants.Instance.COUNT_MIN_PROFIT;
        }

        private void DownloadTopPerson()
        {
            NetworkUtils.DownloadString(Constants.Instance.URL_BASE + Constants.Instance.URL_GAME_TOP, (ok, html, error) =>
            {
                if (ok)
                {
                    HtmlParser.HtmlParser.ParseTopPerson(html, (persons) =>
                    {
                        UiDispatcher.BeginInvoke(new Action(() =>
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
                        }));
                    });
                }
            });
        }

        private static TopPersonRecommendsViewModel _instance = new TopPersonRecommendsViewModel();
        public static TopPersonRecommendsViewModel Instance
        {
            get
            {
                return _instance;
            }
        }

        private DispatcherTimer _timerRefreshRecommends = null;
        private TopPersonRecommendsViewModel()
        {
            _timerRefreshRecommends = new DispatcherTimer();
            _timerRefreshRecommends.Interval = new TimeSpan(0, Constants.Instance.INT_MINUTES_UPDATE_RECOMMEND, 30);
            _timerRefreshRecommends.Tick += RefreshRecommends;
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
                UiDispatcher.BeginInvoke(new Action(() =>
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
                }));
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
                        if (x.Person.Profit > y.Person.Profit)
                            result = 1;
                        if (x.Person.Profit < y.Person.Profit)
                            result = -1;
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
    }
}
