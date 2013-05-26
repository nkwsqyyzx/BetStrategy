using BetStrategy.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using WSQ.CSharp.Serialization;

namespace BetStrategy.Utils
{
    public class FileHelper
    {
        private static string REC_BASE_DIR = "Person.Recommends";
        private static FileStreamSerializer<Recommend> RecommendSerializer = SerializationManager.Instance.GetInstance<Recommend>();

        private static string GetPersonRecommendsDir(string name)
        {
            return Path.Combine(Environment.CurrentDirectory, REC_BASE_DIR, name);
        }
        private static string GetRecommendPath(Recommend rec)
        {
            return Path.Combine(GetPersonRecommendsDir(rec.Person), Regex.Replace(rec.Time2, "[- :]", "_") + ".txt");
        }

        public static void SaveRecommend(Recommend rec)
        {
            RecommendSerializer.Serialize(GetRecommendPath(rec), rec);
        }

        public static void SaveRecommends(IEnumerable<Recommend> recs)
        {
            foreach (var rec in recs)
            {
                SaveRecommend(rec);
            }
        }

        public static void GetAllRecommends(string name, Action<Recommend> onRecommend, Action finish = null)
        {
            var files = Directory.EnumerateFiles(GetPersonRecommendsDir(name));
            foreach (var file in files)
            {
                var rec = RecommendSerializer.Deserialize(Path.Combine(GetPersonRecommendsDir(name), file));
                onRecommend(rec);
            }
            if (finish != null)
            {
                finish();
            }
        }
    }
}
