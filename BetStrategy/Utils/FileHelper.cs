﻿using BetStrategy.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using WSQ.CSharp.Serialization;

namespace BetStrategy.Utils
{
    /// <summary>
    /// 处理文件读写的类
    /// </summary>
    public class FileHelper
    {
        private static string CACHE_DIR = "cache";
        private static IFileSerializer Serializer = SerializationManager.Instance.GetInstance();

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

        public static string GetPersonCacheDir(string name)
        {
            return Path.Combine(Environment.CurrentDirectory, CACHE_DIR, Escape(name));
        }

        private static string GetPersonRecommendsDir(string name)
        {
            return Path.Combine(GetPersonCacheDir(name), "Recommends");
        }

        private static string GetRecommendPath(Recommend rec)
        {
            return Path.Combine(GetPersonRecommendsDir(rec.Person), Regex.Replace(rec.Time2, "[- :]", "_") + ".txt");
        }

        public static void SaveRecommend(Recommend rec)
        {
            Serializer.Serialize(GetRecommendPath(rec), rec);
        }

        public static void SaveRecommends(IEnumerable<Recommend> recs)
        {
            foreach (var rec in recs)
            {
                SaveRecommend(rec);
            }
        }

        public static void GetAllPerson(Action<string> onPerson, Action finish = null)
        {
            var dir = CACHE_DIR;
            if (Directory.Exists(dir))
            {
                var subdirs = Directory.EnumerateDirectories(dir);
                foreach (var sdir in subdirs)
                {
                    onPerson(Path.GetFileName(sdir));
                }
            }
            if (finish != null)
            {
                finish();
            }
        }

        public static void GetAllRecommends(string name, Action<Recommend> onRecommend, Action finish = null)
        {
            var dir = GetPersonRecommendsDir(name);
            if (Directory.Exists(dir))
            {
                var files = Directory.EnumerateFiles(dir);
                foreach (var file in files)
                {
                    var rec = Serializer.Deserialize<Recommend>(Path.Combine(GetPersonCacheDir(name), file));
                    onRecommend(rec);
                }
            }
            if (finish != null)
            {
                finish();
            }
        }

        public static void GetAllRecommends(Action<Recommend> onRecommend, Action finish = null)
        {
            var cache = Path.Combine(Environment.CurrentDirectory, CACHE_DIR);
            var persons = Directory.EnumerateDirectories(cache);
            foreach (var per in persons)
            {
                var dir = GetPersonRecommendsDir(per);
                var files = Directory.EnumerateFiles(dir);
                foreach (var file in files)
                {
                    var rec = Serializer.Deserialize<Recommend>(Path.Combine(GetPersonCacheDir(per), file));
                    onRecommend(rec);
                }
            }
            if (finish != null)
            {
                finish();
            }
        }
    }
}
