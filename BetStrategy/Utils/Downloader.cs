using BetStrategy.Common.Configurations;
using BetStrategy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using WSQ.CSharp.Net;

namespace BetStrategy.Utils
{
    public class Downloader
    {
        public static void DownloadRecommends(int maxPage, Action<List<Recommend>> onRecommends, Action finish)
        {
            return;
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
                var url = Constants.Instance.URL_BASE + Constants.Instance.URL_GAME_SHOW + "?page=" + i.ToString();
                System.Console.Out.WriteLine(url);
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
                        else
                        {
                            Save(rs);
                        }
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
            LocalManager.Instance.SaveRecommends(recommends);
        }
    }
}
