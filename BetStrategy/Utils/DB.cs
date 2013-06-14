using BetStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using BetStrategy.Properties;
using System.Data;
using WSQ.CSharp.Extensions;

namespace BetStrategy.Utils
{
    public class DB : ILocal
    {
        private static DB _instance = new DB();
        public static DB Instance { get { return _instance; } }

        private SQLiteConnection _conn = null;
        private SQLiteConnection connection
        {
            get
            {
                EnsureConnect();
                return _conn;
            }
        }

        private void EnsureConnect()
        {
            if (_conn == null)
            {
                _conn = new SQLiteConnection(Settings.Default.dbConnectionString);
                _conn.Open();
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
            recs.Enumerate((i) => SaveRecommend(i));
        }

        public void GetAllPerson(Action<string> onPerson, Action finish = null)
        {
            string sql = "select Person from Recommends group by Person;";
            using (SQLiteCommand cmd = new SQLiteCommand(connection))
            {
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        onPerson(reader["Person"] as string);
                    }
                }
            }
            if (finish != null)
            {
                finish();
            }
        }

        public void GetRecommends(string name, Action<Recommend> onRecommend, Action finish = null)
        {
            string sql = "select * from Recommends where Person='" + name + "';";
            GetRecommends(onRecommend, sql);
            if (finish != null)
            {
                finish();
            }
        }

        public void GetAllWaitingRecommends(Action<Recommend> onRecommend, Action finish = null)
        {
            string sql = "select * from Recommends where PreferResult=" + (int)PreferResult.Waiting + ";";
            GetRecommends(onRecommend, sql);
            if (finish != null)
            {
                finish();
            }
        }

        public void GetLatestRecommends(int count, Action<Recommend> onRecommend, Action finish = null)
        {
            string sql = "select * from Recommends Order by Time2 desc limit " + count + ";";
            GetRecommends(onRecommend, sql);
            if (finish != null)
            {
                finish();
            }
        }

        private void GetRecommends(Action<Recommend> onRecommend, string sql)
        {
            using (IDbCommand cmd = new SQLiteCommand(connection))
            {
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        onRecommend(DBHelper.RecommendFromReader(reader));
                    }
                }
            }
        }
    }
}
