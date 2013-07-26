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

        public void Download(int startPage, int endPage, Action<IEnumerable<Recommend>> onRecommends, Action finish)
        {
#if !发布
            return;
#endif

            if (startPage > endPage || endPage < 0)
            {
                throw new ArgumentException("please specify valid startPage & endPage to download.startPage:" + startPage + " endPage:" + endPage);
	    }

            int current = startPage > 0 ? startPage : 1;

            RequestFinished callback = null;

            Action<int> download = (i) =>
            {
                if (i > endPage)
                {
                    if (finish != null)
                    {
                        finish();
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
