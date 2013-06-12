using BetStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            var t1 = TimeFromString(rec.Time1);
            var t2 = TimeFromString(rec.Time2);

            var sz = "insert into Recommends(" + prms + "'Time1','Time2','Odds','PreferResult') values(" + vals + "'" + t1 + "','" + t2 + "'," + rec.Odds + "," + (int)rec.PreferResult + ");";
            return sz;
        }

        public static string UpdateCommand(Recommend rec)
        {
            return "update Recommends set Result='" + rec.Result + "',PreferResult=" + (int)rec.PreferResult + " where Current='" + rec.Current + "' and Host='" + rec.Host + "' and Guest='" + rec.Guest + "' and Person='" + rec.Person + "' and Time2='" + TimeFromString(rec.Time2) + "';";
        }
        public static string SelectCommand(Recommend rec)
        {
            return "select * from Recommends where Current='" + rec.Current + "' and Host='" + rec.Host + "' and Guest='" + rec.Guest + "' and Person='" + rec.Person + "' and Time2='" + TimeFromString(rec.Time2) + "';";
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
    }
}
