﻿
namespace BetStrategy.Models
{

    /// <summary>
    /// 单条推荐
    /// </summary>
    public class Recommend
    {
        /// <summary>
        /// 开赛时间
        /// </summary>
        public string Time1 { get; set; }

        /// <summary>
        /// 主队
        /// </summary>
        public Team Host { get; set; }

        /// <summary>
        /// 盘口
        /// </summary>
        public OddStake OddStake { get; set; }

        /// <summary>
        /// 客队
        /// </summary>
        public Team Guest { get; set; }

        /// <summary>
        /// 推荐
        /// </summary>
        public Prefer Prefer { get; set; }

        /// <summary>
        /// 推荐的赔率
        /// </summary>
        public float Odds { get; set; }

        /// <summary>
        /// 比分 3-2
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 推荐最终结果
        /// </summary>
        public PreferResult PreferResult { get; set; }

        /// <summary>
        /// 推荐时间
        /// </summary>
        public string Time2 { get; set; }

        /// <summary>
        /// 推荐人
        /// </summary>
        public Person Person { get; set; }
    }
}
