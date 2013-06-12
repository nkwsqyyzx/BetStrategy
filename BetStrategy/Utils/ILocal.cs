using BetStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BetStrategy.Utils
{
    public interface ILocal
    {
	/// <summary>
	/// 存储一条推荐
	/// </summary>
	/// <param name="rec"></param>
        void SaveRecommend(Recommend rec);


        void SaveRecommends(IEnumerable<Recommend> recs);


        void GetAllPerson(Action<string> onPerson, Action finish = null);


        void GetRecommends(string name, Action<Recommend> onRecommend, Action finish = null);


        void GetAllWaitingRecommends(Action<Recommend> onRecommend, Action finish = null);


        void GetLatestRecommends(int count, Action<Recommend> onRecommend, Action finish = null);
    }
}
