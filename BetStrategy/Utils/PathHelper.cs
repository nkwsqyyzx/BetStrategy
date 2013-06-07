using BetStrategy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace BetStrategy.Utils
{
    public class PathHelper
    {
        public const string CACHE_DIR = "cache";
        private static string Escape(string name)
        {
            var chs = Path.GetInvalidPathChars();

            if (name.IndexOfAny(chs) < 0)
            {
                return name;
            }
            else
            {
                var result = name;
                foreach (var ch in chs)
                {
                    result = result.Replace(ch, '_');
                }
                return result;
            }
        }

        /// <summary>
        /// 用户的缓存目录(绝对路径)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static string PersonCacheDir(string name)
        {
            return Path.Combine(Environment.CurrentDirectory, CACHE_DIR, Escape(name));
        }

        /// <summary>
        /// 用户YieldRoi数据路径
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string PersonYield(string name)
        {
            return Path.Combine(PersonCacheDir(name), "YieldRoi.txt");
        }

        /// <summary>
        /// 用户已经出结果的推荐存放文件夹(绝对路径)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static string PersonFinishedRecommendsDir(string name)
        {
            return Path.Combine(PersonCacheDir(name), "Recommends");
        }

        /// <summary>
        /// 用户未出结果推荐存放文件夹(绝对路径)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static string PersonWaitingRecommendsDir(string name)
        {
            return Path.Combine(PersonCacheDir(name), "Waiting");
        }

        private static string GetRecommendDir(Recommend rec)
        {
            if (rec.PreferResult == PreferResult.Waiting)
            {
                return PersonWaitingRecommendsDir(rec.Person);
            }
            else
            {
                return PersonFinishedRecommendsDir(rec.Person);
            }
        }

        /// <summary>
        /// 返回该推荐存放的路径(绝对路径)
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        public static string RecommendPath(Recommend rec)
        {
            var name = System.Text.RegularExpressions.Regex.Replace(rec.Time2, "[- :]", "_") + ".txt";
            var mdhm = name.Split("_ -:".ToCharArray());
            var month = int.Parse(mdhm[0]);
            if (month > DateTime.Now.Month)
            {
                name = string.Format("{0}_{1}", DateTime.Now.Year - 1, name);
            }
            else
            {
                name = string.Format("{0}_{1}", DateTime.Now.Year, name);
            }
            return Path.Combine(GetRecommendDir(rec), name);
        }

        /// <summary>
        /// 获取所有推荐人
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> AllPersons()
        {
            var items = Directory.EnumerateDirectories(CACHE_DIR);
            foreach (var item in items)
            {
                yield return Path.GetFileName(item);
            }
        }

        /// <summary>
        /// 所有等待结果的推荐
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IEnumerable<string> WaitingRecommends()
        {
            var persons = AllPersons();
            foreach (var p in persons)
            {
                var waitingDir = PersonWaitingRecommendsDir(p);
                if (Directory.Exists(waitingDir))
                {
                    var files = Directory.EnumerateFiles(waitingDir);
                    foreach (var file in files)
                    {
                        yield return Path.Combine(Environment.CurrentDirectory, file);
                    }
                }
            }
        }

        /// <summary>
        /// 获取用户的所有推荐
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IEnumerable<string> Recommends(string name)
        {
            var waitingDir = PersonWaitingRecommendsDir(name);
            if (Directory.Exists(waitingDir))
            {
                var files = Directory.EnumerateFiles(waitingDir);
                foreach (var file in files)
                {
                    yield return Path.Combine(Environment.CurrentDirectory, file);
                }
            }

            var finishedDir = PersonFinishedRecommendsDir(name);
            if (Directory.Exists(finishedDir))
            {
                var files = Directory.EnumerateFiles(finishedDir);
                foreach (var file in files)
                {
                    yield return Path.Combine(Environment.CurrentDirectory, file);
                }
            }
        }

        public static IEnumerable<string> AllRecommends()
        {
            var persons = AllPersons();
            IEnumerable<string> all = new Collection<string>();
            foreach (var p in persons)
            {
                var waitingDir = PersonWaitingRecommendsDir(p);
                if (Directory.Exists(waitingDir))
                {
                    var files = Directory.EnumerateFiles(waitingDir);
                    all = all.Concat(files);
                }
            }

            foreach (var p in persons)
            {
                var finishedDir = PersonFinishedRecommendsDir(p);
                if (Directory.Exists(finishedDir))
                {
                    var files = Directory.EnumerateFiles(finishedDir);
                    all = all.Concat(files);
                }
            }
            return all;
        }

        public static IEnumerable<string> LatestRecommends(int count)
        {
            var all = AllRecommends();
            return all.OrderByDescending((i) => Path.GetFileName(i)).Take(count);
        }
    }
}
