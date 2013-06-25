using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BetStrategy.Utils;
using BetStrategy.Models;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BetStrategy.ViewModels;
using WSQ.CSharp.Extensions;
using BetStrategy.Converters;

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
                LocalManager.Instance.SaveRecommends(res);
            };
            LocalManager.Instance.GetRecommends("godball", (r) => res.Add(r), finish);
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
                LocalManager.Instance.SaveRecommend(rec);
            };
            foreach (var p in persons)
            {
                LocalManager.Instance.GetRecommends(p, work, () => System.Diagnostics.Debug.WriteLine("Finished"));
            }
            Thread.Sleep(30 * 60 * 1000);
        }

        [TestMethod]
        public void TestDetectFileName()
        {
            PreferResultToStringConverter converter = new PreferResultToStringConverter();
            var _recommends = new ObservableCollection<Recommend>();
            _recommends.Add(new Recommend() { Time1 = "05-01 07:15", Host = "堤格雷", OddStake = "2/2.5球", Guest = "奧林匹亞", Prefer = "小球", Odds = 0.940f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 23:03", Person = "bin-bin" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:00", Host = "喜百年U20", OddStake = "球半/两球", Guest = "登地U20", Prefer = "喜百年U20", Odds = 0.920f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 23:02", Person = "回心融雪衣" });
            _recommends.Add(new Recommend() { Time1 = "04-30 23:50", Host = "艾恩", OddStake = "平/半", Guest = "艾斯迪格拿", Prefer = "艾斯迪格拿", Odds = 0.860f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 23:01", Person = "不学无术" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "車斯曼", OddStake = "半球", Guest = "赫默爾亨普斯特德城", Prefer = "赫默爾亨普斯特德城", Odds = 0.800f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:57", Person = "sos73" });
            _recommends.Add(new Recommend() { Time1 = "05-01 07:15", Host = "堤格雷", OddStake = "平/半", Guest = "奧林匹亞", Prefer = "奧林匹亞", Odds = 1.020f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:56", Person = "茶居" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "米禾爾", OddStake = "平手", Guest = "水晶宮", Prefer = "水晶宮", Odds = 0.800f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:56", Person = "运达不来霉" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "菲爾德", OddStake = "半球", Guest = "盧沙奧林", Prefer = "菲爾德", Odds = 1.020f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:56", Person = "mzzzzzzm" });
            _recommends.Add(new Recommend() { Time1 = "05-01 02:45", Host = "皇家馬德里", OddStake = "一球/球半", Guest = "多特蒙德", Prefer = "多特蒙德", Odds = 0.890f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "04-30 22:55", Person = "西班牙王子" });
            _recommends.Add(new Recommend() { Time1 = "05-01 01:30", Host = "馬摩洛迪落日", OddStake = "平/半", Guest = "自由州星", Prefer = "馬摩洛迪落日", Odds = 0.970f, Result = "-", PreferResult = (PreferResult)converter.ConvertBack("等待", typeof(PreferResult), null, null), Time2 = "12-30 22:54", Person = "大D哥" });


            var t1 = "05-01 02:34";
            var t2 = "08-04 02:07";

            TimeSpan ts = TimeSpan.Parse(t1);

        }

        [TestMethod]
        public void EmptyTest()
        {
        }

        [TestMethod]
        public void TestOutPutSql()
        {
            var rec = new Recommend()
            {
                Current = "第43期",
                League = "无联赛",
                Time1 = "05-01 02:45",
                Host = "車斯曼",
                OddStake = "半球",
                Guest = "赫默爾亨普斯特德城",
                Prefer = "赫默爾亨普斯特德城",
                Odds = 0.800f,
                Result = "-",
                PreferResult = PreferResult.Waiting,
                Time2 = "04-30 22:57",
                Person = "sos73"
            };

            string sz = DBHelper.ReplaceCommand(rec);
        }
    }
}
