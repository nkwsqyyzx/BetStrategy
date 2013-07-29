using BetStrategy.Domain.Models;
using BetStrategy.Services.Recommends.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BetStrategy.Services.Recommends.Services
{
    class RecommendCenter : IRecommendCenter
    {
        private ILocalWrapper localHelper;
        private IServerWrapper serverHelper;

        public RecommendCenter(ILocalWrapper localHelper, IServerWrapper serverHelper)
        {
            this.localHelper = localHelper;
            this.serverHelper = serverHelper;
        }

        public void Download(int startPage, int endPage, Action<IEnumerable<Recommend>> onRecommends, Action<int> finish)
        {
            serverHelper.Download(startPage, endPage, onRecommends, finish);
        }

        public void SaveRecommend(Recommend rec)
        {
            localHelper.SaveRecommend(rec);
        }

        public void SaveRecommends(IEnumerable<Recommend> recs)
        {
            localHelper.SaveRecommends(recs);
        }

        public void GetAllPerson(Action<string> onPerson, Action finish = null)
        {
            localHelper.GetAllPerson(onPerson, finish);
        }

        public void GetPersons(Action<Person> onPerson, Action finish = null)
        {
            localHelper.GetPersons(onPerson, finish);
        }

        public void GetRecommendsBySql(string sql, Action<Recommend> onRecommend, Action finish, Action<Exception> onSqlError)
        {
            localHelper.GetRecommendsBySql(sql, onRecommend, finish, onSqlError);
        }
    }
}
