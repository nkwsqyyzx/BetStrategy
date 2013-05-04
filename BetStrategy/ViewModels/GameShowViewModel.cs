using BetStrategy.Common.Configurations;
using BetStrategy.Models;
using GalaSoft.MvvmLight.Command;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WSQ.CSharp.Extensions;
using WSQ.CSharp.Helper;
using WSQ.CSharp.Net;
using WSQ.CSharp.Serialization;

namespace BetStrategy.ViewModels
{
    public class GameShowViewModel : BaseViewModel
    {

        private PreferResultToStringConverter converter = new PreferResultToStringConverter();

        private List<Recommend> _allRecommends = new List<Recommend>();
        private ObservableCollection<Recommend> _recommends = new ObservableCollection<Recommend>();
        /// <summary>
        /// 推荐列表
        /// </summary>
        public ObservableCollection<Recommend> Recommends
        {
            get
            {
                if (_recommends.Count == 0)
                {
                    foreach (var item in _allRecommends)
                    {
                        _recommends.Add(item);
                    }
                }
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

        private ICommand _cmdViewBest;
        public ICommand CommandViewBest
        {
            get
            {
                if (_cmdViewBest == null)
                {
                    _cmdViewBest = new RelayCommand(() =>
                    {
                        ViewBest();
                    });
                }
                return _cmdViewBest;
            }
        }

        public GameShowViewModel()
        {
            DownloadRecommends();
        }

        public void DownloadRecommends()
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

        private void ExtractTableRow(HtmlNode rowNode, Action<IList<string>> callback)
        {
            IList<string> values = new List<string>();
            foreach (var td in rowNode.ChildNodes)
            {
                var result = td.InnerText.Trim();
                if (!string.IsNullOrWhiteSpace(result))
                {
                    values.Add(result);
                }
            }
            callback(values);
        }

        static FileStreamSerializer<List<Person>> serializer = new JsonSerializer<List<Person>>();
        private void ViewBest()
        {
            List<Person> best = serializer.Deserialize(Constants.Instance.FILEPATH_GAME_TOP_BEST);
            List<Recommend> bRs = new List<Recommend>();
            if (best != null && best.Count > 0)
            {
                foreach (var item in _allRecommends)
                {
                    if (best.Any((b) => b.Name == item.Person.Name))
                    {
                        item.Person = best.First((b) => b.Name == item.Person.Name);
                        bRs.Add(item);
                    }
                }

                _recommends.Clear();
                foreach (var item in bRs)
                {
                    _recommends.Add(item);
                }
            }
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
