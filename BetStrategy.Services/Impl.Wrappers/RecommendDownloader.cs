using BetStrategy.Domain.Models;
using BetStrategy.Services.Recommends.Wrappers;
using BetStrategy.Services.Utils;
using System;
using System.Collections.Generic;
using System.Threading;
using WSQ.CSharp.Net;

namespace BetStrategy.Services.Impl.Wrappers
{
    class RecommendDownloader : IServerWrapper
    {
        private string urlBase;
        public RecommendDownloader(string urlBase)
        {
            this.urlBase = urlBase;
        }

        public void Download(int startPage, int endPage, Action<IEnumerable<Recommend>> onRecommends, Action<int> finish)
        {
#if !发布
            return;
#endif
            int count = 0;
            if (endPage < 0)
            {
                throw new ArgumentException("please specify valid endPage to download.endPage must be zero or positive.startPage:" + startPage + " endPage:" + endPage);
            }

            int current = startPage > 0 ? startPage : 1;

            RequestFinished callback = null;

            Action<int> download = (i) =>
            {
                if (i > endPage)
                {
                    if (finish != null)
                    {
                        finish(count);
                    }
                    return;
                }
                var url = urlBase + i.ToString();
                System.Console.Out.WriteLine(url);
                NetworkUtils.DownloadString(url, callback);
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
                        Thread.Sleep(new Random().Next(2000, 5000));
                        current += 1;
                        count += rs.Count;
                        download(current);
                    });
                }
                else
                {
                    System.Console.Out.WriteLine(string.Format("ERROR WHEN GETTING {0} PROFILE.ERROR", error));
                }
            };

            download(current);
        }
    }
}
