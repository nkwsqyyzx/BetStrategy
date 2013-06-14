using BetStrategy.Models;
using System;
using System.Collections.Generic;

namespace BetStrategy.Utils
{
    public interface ILocal
    {
        /// <summary>
        /// 存储一条推荐
        /// </summary>
        /// <param name="rec"></param>
        void SaveRecommend(Recommend rec);

        /// <summary>
        /// 保存推荐列表
        /// </summary>
        /// <param name="recs"></param>
        void SaveRecommends(IEnumerable<Recommend> recs);

        /// <summary>
        /// 获取所有推荐人
        /// </summary>
        /// <param name="onPerson"></param>
        /// <param name="finish"></param>
        void GetAllPerson(Action<string> onPerson, Action finish = null);

        /// <summary>
        /// 获取所有推荐
        /// </summary>
        /// <param name="name"></param>
        /// <param name="onRecommend"></param>
        /// <param name="finish"></param>
        void GetRecommends(string name, Action<Recommend> onRecommend, Action finish = null);

        /// <summary>
        /// 获取等待中的推荐
        /// </summary>
        /// <param name="onRecommend"></param>
        /// <param name="finish"></param>
        void GetAllWaitingRecommends(Action<Recommend> onRecommend, Action finish = null);

        /// <summary>
        /// 获取最新推荐
        /// </summary>
        /// <param name="count"></param>
        /// <param name="onRecommend"></param>
        /// <param name="finish"></param>
        void GetLatestRecommends(int count, Action<Recommend> onRecommend, Action finish = null);
    }
}
