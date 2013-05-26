using BetStrategy.Common.Configurations;
using BetStrategy.Models;
using BetStrategy.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WSQ.CSharp.Net;
using WSQ.CSharp.Serialization;

namespace BetStrategy.ViewModels
{
    internal class _YieldRoi
    {
        public string Name { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public YieldRoiPerson Data { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        private bool IsLatest
        {
            get
            {
                return true;
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

        private YieldRoiProvider() { }

        public void GetPersonRecommends(string name, Action<YieldRoiPerson> finish)
        {
            Load(name, finish);
        }

        private void Load(string name, Action<YieldRoiPerson> finish)
        {
            /*
                if (IsDataLatest(data))
                {
                    finish(data.Recommends);
                }
                else
                {
                    DownloadRecommends(name, finish);
                }
            */
        }

        private void DownloadRecommends(string name, Action<List<Recommend>> finish)
        {
            var url = Constants.Instance.URL_BASE + Constants.Instance.URL_GAME_USER + NetworkUtils.UrlEncode(name, Encoding.GetEncoding("GB2312"));
            Action<bool, string, string> callback = (ok, html, error) =>
            {
                if (ok)
                {
                    HtmlParser.ParseRecommends(html, (rs) =>
                    {
                        Save(rs);
                        finish(rs);
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
