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

        public void SaveRecommend(Recommend rec)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(connection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = DBHelper.ReplaceCommand(rec);
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
            GetRecommends(onRecommend, sql, finish);
        }

        public void GetAllWaitingRecommends(Action<Recommend> onRecommend, Action finish = null)
        {
            string sql = "select * from Recommends where PreferResult=" + (int)PreferResult.Waiting + ";";
            GetRecommends(onRecommend, sql, finish);
        }

        public void GetLatestRecommends(int count, Action<Recommend> onRecommend, Action finish = null)
        {
            string sql = "select * from Recommends Order by Time2 desc limit " + count + ";";
            GetRecommends(onRecommend, sql, finish);
        }

        public void GetUnFinishedRecommends(Action<Recommend> onRecommend, Action finish = null)
        {
            string sql = "select * from Recommends where datetime('NOW','localtime','-2 hour') <= Time1 order by Time1;";
            GetRecommends(onRecommend, sql, finish);
        }

        private void GetRecommends(Action<Recommend> onRecommend, string sql, Action finish)
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
            if (finish != null)
            {
                finish();
            }
        }

        public void GetPersons(Action<Person> onPerson, Action finish = null)
        {
            string sql = @"
select 
Person as Name,
count(*) as Total,              
SUM(CASE PreferResult WHEN 1 THEN -1 WHEN 2 THEN -0.5 WHEN 4 THEN 0.5 WHEN 5 THEN 1 ELSE 0 END) as Profit,
SUM(CASE PreferResult WHEN 0 THEN 1 ELSE 0 END) as Waiting, 
SUM(CASE PreferResult WHEN 1 THEN 1 ELSE 0 END) as Lose, 
SUM(CASE PreferResult WHEN 2 THEN 1 ELSE 0 END) as LoseHalf, 
SUM(CASE PreferResult WHEN 3 THEN 1 ELSE 0 END) as Draw, 
SUM(CASE PreferResult WHEN 4 THEN 1 ELSE 0 END) as WinHalf, 
SUM(CASE PreferResult WHEN 5 THEN 1 ELSE 0 END) as Win
from Recommends group by Person;";
            using (IDbCommand cmd = new SQLiteCommand(connection))
            {
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        onPerson(DBHelper.PersonFromReader(reader));
                    }
                }
            }
            if (finish != null)
            {
                finish();
            }
        }
    }
}
