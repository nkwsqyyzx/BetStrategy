using BetStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BetStrategy.Utils
{
    public class DB : ILocal
    {
        private static DB _instance = new DB();
        public static DB Instance { get { return _instance; } }

        public void SaveRecommend(Recommend rec)
        {
            var properties = rec.GetType().GetProperties();

        }

        public void SaveRecommends(IEnumerable<Recommend> recs)
        {
            throw new NotImplementedException();
        }

        public void GetAllPerson(Action<string> onPerson, Action finish = null)
        {
            throw new NotImplementedException();
        }

        public void GetRecommends(string name, Action<Recommend> onRecommend, Action finish = null)
        {
            throw new NotImplementedException();
        }

        public void GetAllWaitingRecommends(Action<Recommend> onRecommend, Action finish = null)
        {
            throw new NotImplementedException();
        }

        public void GetLatestRecommends(int count, Action<Recommend> onRecommend, Action finish = null)
        {
            throw new NotImplementedException();
        }
    }

    private static class DBHelper
    {
        public static string InsertCommand(Recommend rec)
        {
            string sz = string.Format("");
            return sz;
        }
    }
}
