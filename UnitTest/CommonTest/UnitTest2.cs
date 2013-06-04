using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BetStrategy.Utils;
using BetStrategy.Models;
using System.Threading;
using System.Collections.Generic;

namespace CommonTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestRecommendsSave()
        {
            List<Recommend> res = new List<Recommend>();
            Action finish = () =>
            {
                FileHelper.SaveRecommends(res);
            };
            FileHelper.GetRecommends("godball", (r) => res.Add(r), finish);
            Thread.Sleep(1000000);
        }

        [TestMethod]
        public void TestEnumeratePersons()
        {
            var ps = PathHelper.AllPersons();
            foreach (var p in ps)
            {
                System.Diagnostics.Debug.WriteLine(p);
            }
            Thread.Sleep(1000000);
        }

        [TestMethod]
        public void TestNormal()
        {
            var files = PathHelper.Recommends("godball");
            foreach (var file in files)
            {
                System.Diagnostics.Debug.WriteLine(file);
            }
            Thread.Sleep(10000);
        }

        [TestMethod]
        public void TransferData()
        {
            var persons = PathHelper.AllPersons();
            Action<Recommend> work = (rec) =>
            {
                if (rec.PreferResult == PreferResult.Waiting)
                {
                    rec.PreferResult = PreferResult.Useless;
                    FileHelper.DeleteRecommend(rec);
                    rec.PreferResult = PreferResult.Waiting;
                    FileHelper.SaveRecommend(rec);
		}
            };
            foreach (var p in persons)
            {
                FileHelper.GetRecommends(p, work, null);
            }
            Thread.Sleep(30 * 60 * 1000);
        }
    }
}
