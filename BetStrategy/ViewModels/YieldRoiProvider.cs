using BetStrategy.Common.Configurations;
using BetStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WSQ.CSharp.Net;
using WSQ.CSharp.Serialization;
using System.Web;
using System.IO;

namespace BetStrategy.ViewModels
{
    public class RecommendsData
    {
        public string Name { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public List<Recommend> Recommends { get; set; }
    }

    public class YieldRoiProvider
    {
        private static FileStreamSerializer<RecommendsData> serializer = SerializationManager.Instance.GetInstance<RecommendsData>();
        private static string RECOMMENDS_DIR = "Recommends";

        private static YieldRoiProvider _instance = new YieldRoiProvider();
        public static YieldRoiProvider Instance 
        {
            get
            {
                return _instance;
            }
        }

        private YieldRoiProvider() { }

        public void GetPersonRecommends(string name, Action<List<Recommend>> finish)
        {
            Load(name, finish);
        }

        private bool IsDataLatest(RecommendsData data)
        {
            return data != null && data.Recommends != null && data.Recommends.Count > 0 &&
                DateTime.Now.Subtract(data.LastUpdateTime).TotalMinutes < Constants.Instance.INT_MINUTES_UPDATE_YIELD_ROI;
        }

        private void Load(string name, Action<List<Recommend>> finish)
        {
            var data = serializer.Deserialize(GetPersonRecommendsPath(name));
            if (IsDataLatest(data))
            {
                finish(data.Recommends);
            }
            else
            {
                DownloadRecommends(name, finish);
            }
        }

        private void DownloadRecommends(string name, Action<List<Recommend>> finish)
        {
            var url = Constants.Instance.URL_BASE + Constants.Instance.URL_GAME_USER + NetworkUtils.UrlEncode(name, Encoding.GetEncoding("GB2312"));
            Action<bool, string, string> callback = (ok, html, error) =>
            {
                if (ok)
                {
                    HtmlParser.HtmlParser.ParseRecommends(html, (rs) =>
                    {
                        Save(name, rs);
                        finish(rs);
                    });
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("ERROR WHEN GETTING {0} PROFILE.ERROR:{1}", name, error));
                }
            };
#if TEST
            NetworkUtils.DownloadString(url, (ok, html, error) => callback(ok, html, error));
#else
            callback(true, TestData.GAME_USER_HTML, "");
#endif
        }

        private static string GetPersonRecommendsPath(string name)
        {
            return Path.Combine(Environment.CurrentDirectory, RECOMMENDS_DIR + "/" + name + ".json.txt");
        }

        private void Save(string name, List<Recommend> recommends)
        {
            var data = new RecommendsData() { Name = name, LastUpdateTime = DateTime.Now, Recommends = recommends };
            serializer.Serialize(GetPersonRecommendsPath(name), data);
        }
    }
}
