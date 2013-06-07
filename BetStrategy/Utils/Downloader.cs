using BetStrategy.Common.Configurations;
using BetStrategy.Models;
using BetStrategy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WSQ.CSharp.Net;

namespace BetStrategy.Utils
{
    public class Downloader
    {
        public static void DownloadPersonRecommends(string name, int page, Action<List<Recommend>> finish)
        {
            var url = Constants.Instance.URL_BASE + Constants.Instance.URL_GAME_USER + NetworkUtils.UrlEncode(name, Encoding.GetEncoding("GB2312"));
            page = page <= 0 ? 1 : page;
            if (page > 0)
            {
                url = url + "&page=" + page.ToString();
                System.Console.Out.WriteLine("downloading " + name + " page " + page.ToString());
            }
            Action<bool, string, string> callback = (ok, html, error) =>
            {
                if (ok)
                {
                    HtmlParser.ParseRecommends(html, (rs) =>
                    {
                        if (rs.Count == 100)
                        {
                            Thread.Sleep(5283);
                            DownloadPersonRecommends(name, page + 1, finish);
                        }
                        Save(rs);
                        if (finish != null)
                        {
                            finish(rs);
                        }
                    });
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("ERROR WHEN GETTING {0} PROFILE.ERROR:{1}", name, error));
                }
            };
#if !TEST
            NetworkUtils.DownloadString(url, (ok, html, error) => callback(ok, html, error));
#else
            callback(true, TestData.GAME_USER_HTML, "");
#endif
        }

        public static void DownloadRecommends(int maxPage, Action<List<Recommend>> onRecommends, Action finish)
        {
            int current = 1;

            Action<bool, string, string> callback = null;

            Action<int> download = (i) =>
            {
                if (i > maxPage)
                {
                    if (finish != null)
                    {
                        finish();
                    }
                    return;
                }
                var url = Constants.Instance.URL_BASE + Constants.Instance.URL_GAME_SHOW + "?&page=" + i.ToString();
                NetworkUtils.DownloadString(url, (ok, html, error) => callback(ok, html, error));
            };

            callback = (ok, html, error) =>
            {
                if (ok)
                {
                    HtmlParser.ParseRecommends(html, (rs) =>
                    {
                        System.Console.Out.WriteLine("Page " + current + " Finished!");
                        if (onRecommends != null)
                        {
                            onRecommends(rs);
                        }
                        Save(rs);
                        Thread.Sleep(5283);
                        current += 1;
                        download(current);
                    });
                }
                else
                {
                    System.Console.Out.WriteLine(string.Format("ERROR WHEN GETTING {0} PROFILE.ERROR", error));
                }
            };

            download(1);
        }

        private static void Save(List<Recommend> recommends)
        {
            FileHelper.SaveRecommends(recommends);
        }
    }
}
