using HtmlAgilityPack;
using System.Collections.ObjectModel;
using WSQ.CSharp.Net;
using BetStrategy.Models;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using BetStrategy.Windows;
using System.Windows.Threading;
using BetStrategy.Common.Configurations;
using System.ComponentModel;
using System.Linq;
using WSQ.CSharp.Helper;

namespace BetStrategy.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private Window WinGameShow;
        private Window WinGameTop;
        private Window WinGameBest;

        private ICommand _cmdGameShow;
        public ICommand CommandGameShow
        {
            get
            {
                if (_cmdGameShow == null)
                {
                    _cmdGameShow = new RelayCommand(() =>
                    {
                        if (WinGameShow == null)
                        {
                            WinGameShow = new GameShowWindow();
                            WinGameShow.Closed += (o, e) => WinGameShow = null;
                        }
                        WinGameShow.Show();
                    });
                }
                return _cmdGameShow;
            }
        }

        private ICommand _cmdGameTop;
        public ICommand CommandGameTop
        {
            get
            {
                if (_cmdGameTop == null)
                {
                    _cmdGameTop = new RelayCommand(() =>
                    {
                        if (WinGameTop == null)
                        {
                            WinGameTop = new GameTopWindow();
                            WinGameTop.Closed += (o, e) => WinGameTop = null;
                        }
                        WinGameTop.Show();
                    });
                }
                return _cmdGameTop;
            }
        }

        private ICommand _cmdBest;
        public ICommand CommandBestPrefer
        {
            get
            {
                if (_cmdBest == null)
                {
                    _cmdBest = new RelayCommand(() =>
                    {
                        if (WinGameBest == null)
                        {
                            WinGameBest = new GameShowWindow();
                            WinGameBest.Closed += (o, e) => WinGameBest = null;
                        }
                        WinGameBest.Show();
                    });
                }
                return _cmdBest;
            }
        }

        private bool _check;
        public bool CheckBoxIsChecked
        {
            get
            {
                return _check;
            }
            set
            {
                _check = value;
                NotifyPropertyChange(() => CheckBoxIsChecked);
                Start(_check);
            }
        }

        private static MainViewModel _instance;
        public static MainViewModel Instance
        {
            get
            {
                return _instance;
            }
        }

        private DispatcherTimer _timer;
        public MainViewModel()
        {
            _instance = this;
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, Constants.Instance.INT_MINUTES_UPDATE_RECOMMEND, 30);
            _timer.Tick += timer_Tick;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Notify();
        }

        private List<Recommend> _allRecommends = new List<Recommend>();
        private void DownloadRecommends()
        {
            NetworkUtils.DownloadString(Constants.Instance.URL_BASE + Constants.Instance.URL_GAME_SHOW, (ok, html, error) =>
            {
                if (ok)
                {
                    UiDispatcher.BeginInvoke(new Action(() =>
                    {
                        _allRecommends.Clear();
                        ParseRecommendsFromHtmlResponse(html);
                    }));
                }
            });
        }

        private void ParseRecommendsFromHtmlResponse(string html)
        {
            new System.Threading.Thread(new System.Threading.ParameterizedThreadStart((o) =>
            {
                HtmlDocument hDoc = new HtmlDocument();
                hDoc.LoadHtml(html);

                var tableRows = hDoc.DocumentNode.SelectNodes(Constants.Instance.XPATH_GAME_SHOW_RESULT);

                foreach (var node in tableRows)
                {
                    ExtractTableRow(node, (results) =>
                    {
                        UiDispatcher.BeginInvoke(new Action(() =>
                        {
                            if (results.Count == Constants.Instance.COUNT_GAME_SHOW_RESULT_COLUMNS)
                            {
                                _allRecommends.Add(RecommendFromStrings(results));
                            }
                        }));
                    });
                }
            })).Start();
        }

        private PreferResultToStringConverter converter = new PreferResultToStringConverter();
        private Recommend RecommendFromStrings(IList<string> results)
        {
            string r6 = results[6]; // 艾斯迪格拿/0.900
            string szOdds = "0.0";
            int lastSlash = r6.LastIndexOf("/");
            string prefer = "推荐";
            if (lastSlash >= 0)
            {
                szOdds = r6.Substring(r6.LastIndexOf("/") + 1);
                prefer = r6.Substring(0, r6.LastIndexOf("/"));
            }
            float odds = 0.0f;
            float.TryParse(szOdds, out odds);
            Recommend rec = new Recommend()
            {
                // 开赛时间:04-27 16:30
                Time1 = results[2],
                // 主队:中央海岸學院
                Host = new Team() { TeamName = results[3] },
                // 盘口:2.5/3球
                OddStake = new OddStake() { Description = results[4] },
                // 客队:馬柯尼
                Guest = new Team() { TeamName = results[5] },
                // 推荐内容:大球
                Prefer = new Prefer() { Description = prefer },
                // 赔率:0.86
                Odds = odds,
                // 比赛最终结果:0-1
                Result = results[7],
                // 推荐最终结果:输盘
                PreferResult = (PreferResult)converter.ConvertBack(results[8], typeof(PreferResult), null, null),
                // 推荐时间:04-27 16:00
                Time2 = results[9],
                // 推荐人:地狱黑仔王
                Person = new Person() { Name = results[10] }
            };

            return rec;
        }

        private static List<Recommend> sent = new List<Recommend>();
        public void Notify()
        {
            if (TopPerson.Count == 0)
            {
                GetBestPlayer();
                return;
            }
            if (_allRecommends.Count == 0)
            {
                this.DownloadRecommends();
                return;
            }
            if (TopPerson != null && TopPerson.Count > 0)
            {
                foreach (var item in _allRecommends)
                {
                    if (TopPerson.Any((p) => p.Name == item.Person.Name))
                    {
                        // 这条推荐是牛逼推荐
                        if (sent.Any((i) => i.Person.Name == item.Person.Name &&
                            i.Odds == item.Odds &&
                            i.Prefer.Description == item.Prefer.Description))
                        {
                            // 遗憾的是这条已经发送过了.
                        }
                        else
                        {
                            string subject = "牛逼人物 " + item.Person.Name + " 发推荐啦";
                            string body = item.Person.Name + " 推荐: "
                                + item.Host.TeamName + " "
                                + item.OddStake.Description + " "
                                + item.Odds.ToString() + " "
                                + item.Guest.TeamName + " 推荐:" + item.Prefer.Description;

                            EmailHelper.SendEmailViaGmail(EmailConfig.Instance.Username, EmailConfig.Instance.ToAddress, EmailConfig.Instance.Username, EmailConfig.Instance.Password, subject, body);
                        }
                    }
                    else
                    {
                        // 不是牛逼推荐.
                    }
                }
            }
            else
            {
                MessageBox.Show("牛逼人物没设定.请检查!");
            }
        }

        private void Start(bool flag)
        {
            if (!flag)
            {
                _timer.Stop();
            }
            else
            {
                _timer.Start();
                timer_Tick(null, null);
            }
        }

        private List<Person> TopPerson = new List<Person>();
        private void GetBestPlayer()
        {
            if (TopPerson.Count == 0)
            {
                NetworkUtils.DownloadString(Constants.Instance.URL_BASE + Constants.Instance.URL_GAME_TOP, (ok, html, error) =>
                {
                    string response = ok ? html : TestData.HTML_GAME_TOP;
                    UiDispatcher.BeginInvoke(new Action(() =>
                    {
                        ParseTopPersonFromHtml(response);
                    }));
                });
            }
        }

        public void RefreshBestPlayer()
        {
            TopPerson.Clear();
            GetBestPlayer();
        }

        private void ParseTopPersonFromHtml(string html)
        {
            new System.Threading.Thread(() =>
            {
                HtmlDocument hDoc = new HtmlDocument();
                hDoc.LoadHtml(html);

                var tableRows = hDoc.DocumentNode.SelectNodes(Constants.Instance.XPATH_GAME_TOP_RESULT);

                foreach (var node in tableRows)
                {
                    ExtractTableRow(node, (results) =>
                    {
                        UiDispatcher.BeginInvoke(new Action(() =>
                        {
                            if (results.Count == Constants.Instance.COUNT_GAME_TOP_RESULT_COLUMNS)
                            {
                                var person = TopPersonFromStrings(results);
                                if (person.Profit >= (float)(Constants.Instance.COUNT_MIN_PROFIT))
                                {
                                    TopPerson.Add(person);
                                }
                            }
                        }));
                    });
                }
            }).Start();
        }

        private void ExtractTableRow(HtmlNode node, Action<IList<string>> callback)
        {
            IList<string> values = new List<string>();
            foreach (var td in node.ChildNodes)
            {
                var result = td.InnerText.Trim();
                if (!string.IsNullOrWhiteSpace(result))
                {
                    values.Add(result);
                }
            }
            callback(values);
        }

        private Person TopPersonFromStrings(IList<string> r)
        {
            /*
               排名:第462名
               会员名称:小兵突击
               净胜:-7.5场
               总发布:14场
               全赢:3场
               赢半:0场
               全输:10场
               输半:1场
               走水:0场
               */

            Person p = new Person();
            p.Name = r[1];
            float profit = 0.0f;
            float.TryParse(r[2].Substring(0, r[2].Length - 1), out profit);
            p.Profit = profit;

            int total = 0;
            int.TryParse(r[3].Substring(0, r[3].Length - 1), out total);
            p.Total = total;

            int win = 0;
            int.TryParse(r[4].Substring(0, r[4].Length - 1), out win);
            p.Win = win;

            int halfWin = 0;
            int.TryParse(r[5].Substring(0, r[5].Length - 1), out halfWin);
            p.HalfWin = halfWin;

            int lose = 0;
            int.TryParse(r[6].Substring(0, r[6].Length - 1), out lose);
            p.Lose = lose;

            int halfLose = 0;
            int.TryParse(r[7].Substring(0, r[7].Length - 1), out halfLose);
            p.HalfLose = halfLose;

            int draw = 0;
            int.TryParse(r[8].Substring(0, r[8].Length - 1), out draw);
            p.Draw = draw;

            return p;
        }

    }
}
