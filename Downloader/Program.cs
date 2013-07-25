using BetStrategy.Utils;
using BetStrategy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading;

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
            Download(count);
            Thread.Sleep(1000 * 1000 * 1000);
        }

        private static void Download(int count)
        {
            System.Console.Out.WriteLine("begin to download " + count + " pages");
            Downloader.DownloadRecommends(count, SaveToFile, Finish);
        }

        private static void SaveToFile(List<Recommend> recommends)
        {
            using (System.IO.FileStream fs = new System.IO.FileStream("SQL.sql", System.IO.FileMode.Append))
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fs))
            {
                writer.WriteLine("-- this is downloaded at:" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
                foreach (var r in recommends)
                {
                    writer.WriteLine(DBHelper.ReplaceCommand(r));
                }
            }
        }

        private static void Finish()
        {
            Environment.Exit(0);
        }
    }
}
