using BetStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using BetStrategy.Properties;
using System.Data;

namespace BetStrategy.Utils
{
    public class DB : ILocal
    {
        private static DB _instance = new DB();
        public static DB Instance { get { return _instance; } }

        private SQLiteConnection connection = null;

        private void EnsureConnect()
        {
            if (connection == null)
            {
                connection = new SQLiteConnection(Settings.Default.dbConnectionString);
                connection.Open();
            }
        }

        private bool RecommendExists(Recommend rec)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(connection))
            {
                cmd.CommandText = DBHelper.SelectCommand(rec);
                cmd.CommandType = CommandType.Text;
                using (var reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        public void SaveRecommend(Recommend rec)
        {
            EnsureConnect();
            using (SQLiteCommand cmd = new SQLiteCommand(connection))
            {
                cmd.CommandType = CommandType.Text;
                if (RecommendExists(rec))
                {
                    cmd.CommandText = DBHelper.UpdateCommand(rec);
                }
                else
                {
                    cmd.CommandText = DBHelper.InsertCommand(rec);
                }
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveRecommends(IEnumerable<Recommend> recs)
        {
            
        }

        public void GetAllPerson(Action<string> onPerson, Action finish = null)
        {
        }

        public void GetRecommends(string name, Action<Recommend> onRecommend, Action finish = null)
        {
        }

        public void GetAllWaitingRecommends(Action<Recommend> onRecommend, Action finish = null)
        {
        }

        public void GetLatestRecommends(int count, Action<Recommend> onRecommend, Action finish = null)
        {
        }
    }
}
