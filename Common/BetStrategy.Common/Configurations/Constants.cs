using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WSQ.CSharp.Configuration;

namespace BetStrategy.Common.Configurations
{
    internal enum ENUMCONSTANT
    {
        [Config(typeof(Constants))]
        CONTENT
    }

    public class Constants
    {
        private static string FILE_PATH = "constants.json.txt";
        private static IConfig config = null;

        private static Constants _instance = null;
        public static Constants Instance
        {
            get
            {
                if (_instance == null)
                {
                    Init();
                }
                return _instance;
            }
        }

        private static void Init()
        {
            config = ConfigurationManager.GetInstance(FILE_PATH, (cfg) =>
            {
                cfg.Set(ENUMCONSTANT.CONTENT, new Constants()
                {
                    URL_BASE = "http://www.yn1999.com/",
                    URL_GAME_SHOW = "game_show.asp",
                    XPATH_GAME_SHOW_RESULT = "/html[1]/body[1]/table[1]/tr",
                    COUNT_GAME_SHOW_RESULT_COLUMNS = 11,
                    URL_GAME_TOP = "game_top.asp",
                    XPATH_GAME_TOP_RESULT = "html[1]/body[1]/table[1]/tr",
                    COUNT_GAME_TOP_RESULT_COLUMNS = 10,
                    FILEPATH_GAME_TOP_BEST = "filepath_game_top_best.json.txt",
                    COUNT_MIN_PROFIT = 7.0f,
                    INT_MINUTES_UPDATE_TOP_PERSON = 600,
                    INT_MINUTES_UPDATE_RECOMMEND = 17
                });
            });
            _instance = config.Get<Constants>(ENUMCONSTANT.CONTENT);
        }

        /// <summary>
        /// 论坛地址
        /// </summary>
        public string URL_BASE { get; set; }

        /// <summary>
        /// 每隔这一段时间后更新推荐排行榜
        /// </summary>
        public int INT_MINUTES_UPDATE_TOP_PERSON { get; set; }

        /// <summary>
        /// 每隔这一段时间后更新推荐
        /// </summary>
        public int INT_MINUTES_UPDATE_RECOMMEND { get; set; }

        #region 擂台
        /// <summary>
        /// 擂台参赛纪录页面
        /// </summary>
        public string URL_GAME_SHOW { get; set; }

        /// <summary>
        /// 擂台参赛纪录页面结果在HTML中的XPath
        /// </summary>
        public string XPATH_GAME_SHOW_RESULT { get; set; }

        /// <summary>
        /// 擂台参赛纪录结果列数
        /// </summary>
        public int COUNT_GAME_SHOW_RESULT_COLUMNS { get; set; }
        #endregion

        #region 擂台排行
        /// <summary>
        /// 擂台排行榜
        /// </summary>
        public string URL_GAME_TOP { get; set; }

        /// <summary>
        /// 擂台排行榜页面结果在HTML中的XPATH
        /// </summary>
        public string XPATH_GAME_TOP_RESULT { get; set; }

        /// <summary>
        /// 擂台排行榜页面结果列数
        /// </summary>
        public int COUNT_GAME_TOP_RESULT_COLUMNS { get; set; }

        /// <summary>
        /// 擂台排名最靠前的选手.
        /// </summary>
        public string FILEPATH_GAME_TOP_BEST { get; set; }

        /// <summary>
        /// 成为靠前选手的必须条件.目前定为最少净胜7场.
        /// </summary>
        public float COUNT_MIN_PROFIT { get; set; }
        #endregion
    }
}
