﻿using BetStrategy.Models;
using System;
using System.Data;
using WSQ.CSharp.Extensions;

namespace BetStrategy.Utils
{
    public static class DBHelper
    {
        public static string InsertCommand(Recommend rec)
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

            var sz = "insert into Recommends(" + prms + "'Time1','Time2','Odds','PreferResult') values(" + vals + "'" + t1 + "','" + t2 + "'," + rec.Odds + "," + (int)rec.PreferResult + ");";
            return sz;
        }

        public static string UpdateCommand(Recommend rec)
        {
            return "update Recommends set Result='" + rec.Result + "',PreferResult=" + (int)rec.PreferResult + " where Current='" + rec.Current + "' and Host='" + rec.Host + "' and Guest='" + rec.Guest + "' and Person='" + rec.Person + "' and Time2='" + DateTimeToSqlTime(TimeFromString(rec.Time2)) + "';";
        }

        public static string SelectCommand(Recommend rec)
        {
            return "select * from Recommends where Current='" + rec.Current + "' and Host='" + rec.Host + "' and Guest='" + rec.Guest + "' and Person='" + rec.Person + "' and Time2='" + DateTimeToSqlTime(TimeFromString(rec.Time2)) + "';";
        }

        public static string SelectByPerson(string person)
        {
            return "select * from Recommends where Person='" + person + "';";
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
                    rec.SetProperty(p, (reader[p] as string).Clone());
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
    }
}
