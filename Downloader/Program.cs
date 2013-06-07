using BetStrategy.Utils;
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
            int count = 5;
            if (args.Length >= 1)
            {
                int c;
                if (int.TryParse(args[0], out c))
                {
                    count = c;
                }
                else
                {
                    System.Console.Out.WriteLine("Usage:Downloader [num]");
                    Finish();
                }
            }
            System.Console.Out.WriteLine("begin to download " + count + " pages");
            Downloader.DownloadRecommends(count, null, Finish);
            Thread.Sleep(1000 * 1000 * 1000);
        }

        private static void Finish()
        {
            Environment.Exit(0);
        }
    }
}
