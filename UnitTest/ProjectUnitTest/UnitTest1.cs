using BetStrategy.Domain.Models;
using BetStrategy.Services.Factories;
using BetStrategy.Services.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace ProjectUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSelect()
        {
            RecommendManager.Instance.Init(@"data source=G:\netdrive\baiduyun\球王吧推荐\database", "");
            for (int n = 3; n < 31; n++)
            {
                List<Recommend> rec = new List<Recommend>();
                for (int i = 0; i < 30; i++)
                {
                    Semaphore sm = new Semaphore(0, 1);
                    RecommendManager.Instance.RecommendCenter.GetRecommendsBySql(SQL(i,n), rec.Add, () => sm.Release(), onSqlError);
                    sm.WaitOne();
                }
                Person p = new Person();
                YieldRoiHelper.RefreshProfit(rec, p);
                float roi = YieldRoiHelper.CalculateRoi(rec);
                float yield = YieldRoiHelper.CalculateYield(rec);
                System.Diagnostics.Debug.WriteLine(n + " count:" + rec.Count + " roi:" + roi + " yield:" + yield);
                Write(n + " count:" + rec.Count + " roi:" + roi + " yield:" + yield);
            }
        }

        private string SQL(int offset, int n)
        {
            return "select * from Recommends where Person in (select Person from (select Person,sum(CASE PreferResult WHEN 1 THEN -1 WHEN 2 THEN -0.5 WHEN 4 THEN 0.5*Odds WHEN 5 THEN Odds ELSE 0 END) as Profit,sum(CASE PreferResult WHEN 1 THEN -1 WHEN 2 THEN -0.5 WHEN 4 THEN 0.5*Odds WHEN 5 THEN Odds ELSE 0 END) * 1.0/count(*) as Yield,count(*) as Total from Recommends where " +
"(Time1 > date('NOW','localtime','-" + (n + offset).ToString() + " day') " +
"and Time1 < date('NOW','localtime','-" + (1 + offset).ToString() + " day'))" +
" and Person in (select Person from (select Person,sum(CASE PreferResult WHEN 1 THEN -1 WHEN 2 THEN -0.5 WHEN 4 THEN 0.5*Odds WHEN 5 THEN Odds ELSE 0 END) as Profit,sum(CASE PreferResult WHEN 1 THEN -1 WHEN 2 THEN -0.5 WHEN 4 THEN 0.5*Odds WHEN 5 THEN Odds ELSE 0 END) * 1.0/count(*) as Yield,count(*) as Total from Recommends where " +
"Time1 > date('NOW','localtime','-" + (2 * n + offset).ToString() + " day')" +
" group by Person order by Profit desc) limit 20) group by Person having Profit>0.5 order by Profit desc)) and " +
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
            using (var fs = new FileStream(@"C:\Users\wsq\Downloads\sql.sql", FileMode.Append))
            using (var ws = new StreamWriter(fs))
            {
                ws.WriteLine(sz);
            }
        }
    }
}
