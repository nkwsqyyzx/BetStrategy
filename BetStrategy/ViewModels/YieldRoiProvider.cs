using BetStrategy.Common.Configurations;
using BetStrategy.Models;
using BetStrategy.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using WSQ.CSharp.Net;
using WSQ.CSharp.Serialization;

namespace BetStrategy.ViewModels
{
    internal class _YieldRoi
    {
        public string Name { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public YieldRoiPerson Person { get; set; }

        /// <summary>
        /// 数据保留24小时.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public bool IsLatest
        {
            get
            {
                return Person != null && DateTime.Now.Subtract(LastUpdateTime).TotalMinutes < 24 * 60;
            }
        }
    }

    public class YieldRoiProvider
    {
        #region INSTANCE
        private static YieldRoiProvider _instance = new YieldRoiProvider();
        public static YieldRoiProvider Instance
        {
            get
            {
                return _instance;
            }
        }
        #endregion

        private IFileSerializer serializer = SerializationManager.Instance.GetInstance();
        private YieldRoiProvider() { }
        public void GetPersonRecommends(string name, Action<Recommend> finish)
        {
            FileHelper.GetAllRecommends(name, finish);
        }

        private string GetCachedYieldRoiPerson(string name)
        {
            return Path.Combine(FileHelper.GetPersonCacheDir(name), "YieldRoi.txt");
        }

        public YieldRoiPerson GetPerson(string name)
        {
            var data = serializer.Deserialize<_YieldRoi>(GetCachedYieldRoiPerson(name));
            if (data != null && data.IsLatest)
            {
                return data.Person;
            }
            else
            {
                var person = new YieldRoiPerson(name);
                return person;
            }
        }

        public void SavePerson(YieldRoiPerson person)
        {
            var data = new _YieldRoi();
            data.LastUpdateTime = DateTime.Now;
            data.Name = person.Name;
            data.Person = person;
            serializer.Serialize(GetCachedYieldRoiPerson(person.Name), data);
        }

        public void DownloadRecommends(string name, int page, Action<List<Recommend>> finish)
        {
            var url = Constants.Instance.URL_BASE + Constants.Instance.URL_GAME_USER + NetworkUtils.UrlEncode(name, Encoding.GetEncoding("GB2312"));
            if (page > 0)
            {
                url = url + "&page=" + page.ToString();
            }
            Action<bool, string, string> callback = (ok, html, error) =>
            {
                if (ok)
                {
                    HtmlParser.ParseRecommends(html, (rs) =>
                    {
                        if (rs.Count == 100)
                        {
                            Thread.Sleep(4203);
                            DownloadRecommends(name, page + 1, finish);
                        }
                        Save(rs);
                        if (finish != null)
                        {
                            finish(rs);
                        }
                    });
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("ERROR WHEN GETTING {0} PROFILE.ERROR:{1}", name, error));
                }
            };
#if !TEST
            NetworkUtils.DownloadString(url, (ok, html, error) => callback(ok, html, error));
#else
            callback(true, TestData.GAME_USER_HTML, "");
#endif
        }

        private void Save(List<Recommend> recommends)
        {
            FileHelper.SaveRecommends(recommends);
        }
    }
}
