using BetStrategy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BetStrategy.Services.Recommends.Wrappers
{
    interface ILocalWrapper
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
        /// 获取所有推荐人的基本信息
        /// </summary>
        /// <param name="onPerson"></param>
        /// <param name="finish"></param>
        void GetPersons(Action<Person> onPerson, Action finish = null);

        /// <summary>
        /// 通过sql语句查询推荐
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="OnRecommend"></param>
        /// <param name="RefreshFinish"></param>
        void GetRecommendsBySql(string sql, Action<Recommend> onRecommend, Action finish, Action<Exception> onSqlError);
    }
}
