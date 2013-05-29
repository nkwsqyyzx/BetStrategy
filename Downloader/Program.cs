using BetStrategy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecommendsDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            Downloader.DownloadRecommends(5, () => 
            {
                Environment.Exit(0);
            });
            Thread.Sleep(1000 * 1000 * 1000);
        }
    }
}
