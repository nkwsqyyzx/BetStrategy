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
            RecommendManager.Instance.Init(@"data source=G:\netdrive\baiduyun\玉女吧推荐\database", "");
            float roi;
            float yield;
            List<Recommend> recs = new List<Recommend>();
            for (int n = 3; n < 30; n++)
            {
                List<Recommend> rec = new List<Recommend>();
                Person p = new Person();
                for (int offset = 0; offset < 180; offset++)
                {
                    rec.Clear();
                    Semaphore sm = new Semaphore(0, 1);
                    var sql = SQL1(offset, n);
                    RecommendManager.Instance.RecommendCenter.GetRecommendsBySql(sql, rec.Add, () => sm.Release(), onSqlError);
                    sm.WaitOne();
                    roi = YieldRoiHelper.CalculateRoi(rec);
                    yield = YieldRoiHelper.CalculateYield(rec);
                    YieldRoiHelper.RefreshProfit(rec, p);
                    recs.AddRange(rec);
                }
                roi = YieldRoiHelper.CalculateRoi(recs);
                yield = YieldRoiHelper.CalculateYield(recs);
                YieldRoiHelper.RefreshProfit(recs, p);
                Write("outer " + n + " count:" + recs.Count + " roi:" + roi + " yield:" + yield + " Win:" + p.Win + " WinHalf:" + p.WinHalf + " Lose:" + p.Lose + " LoseHalf:" + p.LoseHalf);
                recs.Clear();
            }
        }

        /// <summary>
        /// 最近一周内最佳然后挑最近3天最佳
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private string SQL(int offset, int n)
        {
            return "select * from PRecommends where Person in (select Person from (select Person,sum(P) as Profit,sum(P) * 1.0/count(*) as Yield,count(*) as Total from PRecommends where (Time1 > date('NOW','localtime','-" + (n + offset) + " day') and Time1 < date('NOW','localtime','-" + offset + " day')) and Person in (select Person from (select Person,sum(P) as Profit,sum(P) * 1.0/count(*) as Yield,count(*) as Total from PRecommends where Time1 > date('NOW','localtime','-" + (2 * n + offset) + " day') and Time1 < date('NOW','localtime','-" + offset + " day') group by Person order by Profit) limit 10) group by Person having Profit<0 order by Profit desc)) and Time2 > date('NOW','localtime','-" + offset + " day') and Time2 < date('NOW','localtime','-" + (offset - 1) + " day')";
        }

        /// <summary>
        /// 过去N天最佳选手
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private string SQL1(int offset, int n)
        {
            var sql = "select * from PRecommends where Person in " + "(select Person from (select Person,sum(P) as Profit,sum(P) * 1.0/count(*) as Yield,count(*) as Total from PRecommends where Time1 > date('NOW','localtime','-" + (n + offset) + " day') and Time1 < date('NOW','localtime','-" + offset + " day') group by Person order by Profit desc) limit 10)" + " and Time2 > date('NOW','localtime','-" + offset + " day') and Time2 < date('NOW','localtime','-" + (offset - 1) + " day')";
            return sql;
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
