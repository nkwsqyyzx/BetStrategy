using BetStrategy.Common.Configurations;
using BetStrategy.Models;
using GalaSoft.MvvmLight.Command;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using WSQ.CSharp.Extensions;
using WSQ.CSharp.Net;
using WSQ.CSharp.Serialization;

namespace BetStrategy.ViewModels
{
    public class GameTopViewModel : BaseViewModel
    {
        private ObservableCollection<Person> _topPerson = null;
        public ObservableCollection<Person> TopPerson
        {
            get
            {
                if (_topPerson == null)
                {
                    _topPerson = new ObservableCollection<Person>();
                }
                return _topPerson;
            }
        }

        private ICommand _cmdRefresh = null;
        public ICommand CommandRefresh
        {
            get
            {
                if (_cmdRefresh == null)
                {
                    _cmdRefresh = new RelayCommand(() => DownloadTopPerson());
                }
                return _cmdRefresh;
            }
        }

        public GameTopViewModel()
        {
            DownloadTopPerson();
        }

        public void DownloadTopPerson()
        {
            NetworkUtils.DownloadString(Constants.Instance.URL_BASE + Constants.Instance.URL_GAME_TOP, (ok, html, error) =>
            {
                string response = ok ? html : TestData.HTML_GAME_TOP;
                UiDispatcher.BeginInvoke(new Action(() =>
                {
                    TopPerson.Clear();
                    ParseTopPersonFromHtml(response);
                }));
            });
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
                                TopPerson.Add(TopPersonFromStrings(results));
                            }
                        }));
                    });
                }

                System.Threading.Thread.Sleep(1000);
                SaveBestPerson();
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

        public void Sort(string sortBy, ListSortDirection direction)
        {
            List<Person> ps = new List<Person>();
            foreach (var p in TopPerson)
            {
                ps.Add(p);
            }

            ps.Sort(ps[0].ComparerFromProperty(sortBy, direction == ListSortDirection.Descending));

            TopPerson.Clear();
            foreach (var p in ps)
            {
                TopPerson.Add(p);
            }
        }

        private void SaveBestPerson()
        {
            List<Person> best = new List<Person>();
            foreach (var p in TopPerson)
            {
                if (p.Profit >= (float)(Constants.Instance.COUNT_MIN_PROFIT))
                {
                    best.Add(p);
                }
            }
            FileStreamSerializer<List<Person>> serializer = new JsonSerializer<List<Person>>();
            serializer.Serialize(Constants.Instance.FILEPATH_GAME_TOP_BEST, best);
        }
    }
}
