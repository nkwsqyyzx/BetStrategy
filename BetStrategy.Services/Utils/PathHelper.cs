using BetStrategy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace BetStrategy.Services.Utils
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
        /// 用户YieldRoi数据路径
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string PersonYield(string name)
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), CACHE_DIR, Escape(name));
            return Path.Combine(path, "YieldRoi.txt");
        }
    }
}
