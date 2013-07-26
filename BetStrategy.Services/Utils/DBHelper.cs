using BetStrategy.Domain.Models;
using System;
using System.Data;
using WSQ.CSharp.Extensions;

namespace BetStrategy.Services.Utils
{
    public static class DBHelper
    {
        public static string ReplaceCommand(Recommend rec)
        {
            var pros = typeof(Recommend).GetProperties();
            string prms = "";
            string vals = "";

            foreach (var p in pros)
            {
                if (p.Name.Contains("Time") || p.PropertyType.Name != "String")
                {
                    continue;
                }
                prms = prms + "'" + p.Name + "',";
                vals = vals + "'" + rec.Property(p.Name) + "',";
            }

            // handle Time1 & Time2
            var t1 = DateTimeToSqlTime(TimeFromString(rec.Time1));
            var t2 = DateTimeToSqlTime(TimeFromString(rec.Time2));

            var sz = "replace into Recommends(" + prms + "'Time1','Time2','Odds','PreferResult') values(" + vals + "'" + t1 + "','" + t2 + "'," + rec.Odds + "," + (int)rec.PreferResult + ");";
            return sz;
        }

        private static string DateTimeToSqlTime(DateTime time)
        {
            return time.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private static DateTime TimeFromString(string time)
        {
            DateTime t1 = DateTime.Now;
            var name = System.Text.RegularExpressions.Regex.Replace(time, "[- :]", "_");
            var mdhm = name.Split("_ -:".ToCharArray());
            var month = int.Parse(mdhm[0]);
            int year = 0;
            if (month > DateTime.Now.Month)
            {
                year = DateTime.Now.Year - 1;
            }
            else
            {
                year = DateTime.Now.Year;
            }
            t1 = new DateTime(year, int.Parse(mdhm[0]), int.Parse(mdhm[1]), int.Parse(mdhm[2]), int.Parse(mdhm[3]), 0);
            return t1;
        }

        public static Recommend RecommendFromReader(IDataRecord reader)
        {
            Recommend rec = new Recommend();
            // 处理string类型
            var ps = typeof(Recommend).Properties<string>();
            try
            {
                foreach (var p in ps)
                {
                    if (p.StartsWith("Time"))
                    {
                        continue;
                    }
                    rec.SetProperty(p, reader[p] as string);
                }
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ex:" + ex.StackTrace);
            }

            // 处理时间类型
            DateTime t1 = (DateTime)reader["Time1"];
            DateTime t2 = (DateTime)reader["Time2"];

            rec.Time1 = t1.ToString("MM-dd HH:mm");
            rec.Time2 = t2.ToString("MM-dd HH:mm");

            rec.PreferResult = (PreferResult)reader["PreferResult"];

            rec.Odds = (float)((double)reader["Odds"]);

            return rec;
        }

        public static Person PersonFromReader(IDataRecord reader)
        {
            Person p = new Person();

            p.Draw = int.Parse(reader["Draw"].ToString());
            p.Lose = int.Parse(reader["Lose"].ToString());
            p.LoseHalf = int.Parse(reader["LoseHalf"].ToString());
            p.Name = reader["Name"].ToString();
            p.Profit = float.Parse(reader["Profit"].ToString());
            p.Total = int.Parse(reader["Total"].ToString());
            p.Win = int.Parse(reader["Win"].ToString());
            p.WinHalf = int.Parse(reader["WinHalf"].ToString());

            return p;
        }

        public static string GetRecommendsByStatusSql(PreferResult pr)
        {
            return "select * from Recommends where PreferResult=" + (int)pr + ";";
        }

        public static string GetRecommendsByPersonSql(string name)
        {
            return "select * from Recommends where Person='" + name + "';";
        }

        public static string GetRecommendsLimitSql(int count)
        {
            return "select * from Recommends Order by Time2 desc limit " + count + ";";
        }

        public const string sql_all_person = "select Person from Recommends group by Person;";
        public const string sql_all_yield_person = @"
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
    }
}
