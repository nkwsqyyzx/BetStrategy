using BetStrategy.Domain.Models;
using BetStrategy.Services.Factories;
using BetStrategy.Services.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading;

namespace ProjectUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSelect()
        {
            RecommendManager.Instance.Init(@"data source=g:\database", "");
            for (int i = 0; i < 180; i++)
            {
                Semaphore sm = new Semaphore(0, 1);
                RecommendManager.Instance.RecommendCenter.GetRecommendsBySql(SQL(i), onRecommend, () => sm.Release(), onSqlError);
                sm.WaitOne();
            }
        }

        private string SQL(int offset)
        {
            return "select * from Recommends where Person in (select Person from (select Person,sum(CASE PreferResult WHEN 1 THEN -1 WHEN 2 THEN -0.5 WHEN 4 THEN 0.5*Odds WHEN 5 THEN Odds ELSE 0 END) as Profit,sum(CASE PreferResult WHEN 1 THEN -1 WHEN 2 THEN -0.5 WHEN 4 THEN 0.5*Odds WHEN 5 THEN Odds ELSE 0 END) * 1.0/count(*) as Yield,count(*) as Total from Recommends where " +
"(Time1 > date('NOW','localtime','-" + (8 + offset).ToString() + " day') " +
"and Time1 < date('NOW','localtime','-" + (1 + offset).ToString() + " day'))" +
" and Person in (select Person from (select Person,sum(CASE PreferResult WHEN 1 THEN -1 WHEN 2 THEN -0.5 WHEN 4 THEN 0.5*Odds WHEN 5 THEN Odds ELSE 0 END) as Profit,sum(CASE PreferResult WHEN 1 THEN -1 WHEN 2 THEN -0.5 WHEN 4 THEN 0.5*Odds WHEN 5 THEN Odds ELSE 0 END) * 1.0/count(*) as Yield,count(*) as Total from Recommends where " +
"Time1 > date('NOW','localtime','-" + (14 + offset).ToString() + " day')" +
" group by Person order by Profit desc) limit 10) group by Person having Profit>0.5 order by Profit desc)) and " +
"Time2 > datetime('NOW','localtime','-" + (1 + offset).ToString() + " day') and Time2 < datetime('NOW','localtime','-" + offset + " day') order by Time2 desc";
        }

        private void onSqlError(Exception obj)
        {
            Write(obj.Message);
        }

        private void finish()
        {
            System.Diagnostics.Debug.WriteLine("--Finished");
        }

        private void onRecommend(Recommend obj)
        {
            var sz = DBHelper.ReplaceCommand(obj);
            Write(sz);
        }

        private static void Write(string sz)
        {
            using (var fs = new FileStream("sql.sql", FileMode.Append))
            using (var ws = new StreamWriter(fs))
            {
                ws.WriteLine(sz);
            }
        }
    }
}
