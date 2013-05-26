using BetStrategy.Common.Configurations;
using BetStrategy.Models;
using BetStrategy.ViewModels;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.ComponentModel;

namespace BetStrategy.Utils
{
    public class HtmlParser
    {
        private static PreferResultToStringConverter converter = new PreferResultToStringConverter();

        private static IList<string> ChildElementsInTableRow(HtmlNode rowNode)
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
            return values;
        }

        private static Recommend RecommendFromStrings(IList<string> results)
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
                // 擂台期数:第45期
                Current = results[0],
                // 所属赛事:挪威超
                League = results[1],
                // 开赛时间:04-27 16:30
                Time1 = results[2],
                // 主队:中央海岸學院
                Host = results[3],
                // 盘口:2.5/3球
                OddStake = results[4],
                // 客队:馬柯尼
                Guest = results[5],
                // 推荐内容:大球
                Prefer = prefer,
                // 赔率:0.86
                Odds = odds,
                // 比赛最终结果:0-1
                Result = results[7],
                // 推荐最终结果:输盘
                PreferResult = (PreferResult)converter.ConvertBack(results[8], typeof(PreferResult), null, null),
                // 推荐时间:04-27 16:00
                Time2 = results[9],
                // 推荐人:地狱黑仔王
                Person = results[10]
            };

            return rec;
        }

        private static Person TopPersonFromStrings(IList<string> r)
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
            p.WinHalf = halfWin;

            int lose = 0;
            int.TryParse(r[6].Substring(0, r[6].Length - 1), out lose);
            p.Lose = lose;

            int halfLose = 0;
            int.TryParse(r[7].Substring(0, r[7].Length - 1), out halfLose);
            p.LoseHalf = halfLose;

            int draw = 0;
            int.TryParse(r[8].Substring(0, r[8].Length - 1), out draw);
            p.Draw = draw;

            return p;
        }

        public static void ParseRecommends(string html, Action<List<Recommend>> finished)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler((sender, e) =>
            {
                List<Recommend> allRecommends = new List<Recommend>();
                HtmlDocument hDoc = new HtmlDocument();
                hDoc.LoadHtml(html);
                var tableRows = hDoc.DocumentNode.SelectNodes(Constants.Instance.XPATH_GAME_SHOW_RESULT);
                foreach (var node in tableRows)
                {
                    var results = ChildElementsInTableRow(node);
                    if (results.Count == Constants.Instance.COUNT_GAME_SHOW_RESULT_COLUMNS)
                    {
                        var rec = RecommendFromStrings(results);
                        if (rec.Odds > 0)
                        {
                            allRecommends.Add(rec);
                        }
                    }
                }
                finished(allRecommends);
            });
            bw.RunWorkerAsync();
        }

        public static void ParseTopPerson(string html, Action<List<Person>> finished)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler((sender, e) =>
            {
                List<Person> TopPerson = new List<Person>();
                HtmlDocument hDoc = new HtmlDocument();
                hDoc.LoadHtml(html);
                var tableRows = hDoc.DocumentNode.SelectNodes(Constants.Instance.XPATH_GAME_TOP_RESULT);
                foreach (var node in tableRows)
                {
                    var results = ChildElementsInTableRow(node);
                    if (results.Count == Constants.Instance.COUNT_GAME_TOP_RESULT_COLUMNS)
                    {
                        var person = TopPersonFromStrings(results);
                        if (person.Total != 0)
                        {
                            TopPerson.Add(person);
                        }
                    }
                }
                finished(TopPerson);
            });
            bw.RunWorkerAsync();
        }
    }
}
