using BetStrategy.Models;
using BetStrategy.Utils;
using BetStrategy.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using WSQ.CSharp.Serialization;

namespace CommonTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TopPersonProvider.Instance.GetTopPerson((t, ps) =>
            {
                System.Diagnostics.Debug.WriteLine("---------" + ps.Count);
            });

            Thread.Sleep(1000000);
        }

        public string publicProperty;
        public string publicPropertyGetSet { get; set; }

        [JsonProperty]
        private string privateProperty;
        private string privatePropertyGetSet { get; set; }

        [JsonProperty]
        private UnitTest1 ttt;

        [TestMethod]
        public void TestJsonSerealizer()
        {
            FileStreamSerializer<UnitTest1> serializer = new JsonSerializer<UnitTest1>();

            UnitTest1 skdjskdjk = new UnitTest1()
            {
                publicProperty = "publicProperty",
                publicPropertyGetSet = "privatePropertyGetSet",
                privateProperty = "privateProperty",
                privatePropertyGetSet = "privatePropertyGetSet",
                ttt = new UnitTest1()
                {
                    publicProperty = "ttt.publicProperty",
                    publicPropertyGetSet = "ttt.publicPropertyGetSet",
                    privatePropertyGetSet = "ttt.privatePropertyGetSet",
                    privateProperty = "ttt.privateProperty",
                }
            };

            serializer.Serialize("TEST.txt", skdjskdjk);
        }

        [TestMethod]
        public void TestConverter()
        {
            PreferResultToStringConverter con = new PreferResultToStringConverter();
            List<string> szsss = new List<string>();
            foreach (PreferResult p in Enum.GetValues(typeof(PreferResult)))
            {
                string sz = con.Convert(p, typeof(string), null, null) as string;
                System.Diagnostics.Debug.WriteLine("Enum:" + p.ToString() + " string:" + sz);
                szsss.Add(sz);
            }

            foreach (var sz in szsss)
            {
                var p = con.ConvertBack(sz, typeof(PreferResult), null, null);
                System.Diagnostics.Debug.WriteLine("Enum:" + p.ToString() + " string:" + sz);
            }

            HtmlParser.ParseRecommends(TestData.GAME_SHOW_HTML, (re) => { });

            Thread.Sleep(1000000);
        }

        [Conditional("TRACE_ON")]
        private static void msg(bool flag)
        {
            if (flag)
            {
                System.Diagnostics.Debug.WriteLine("true");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("False");
            }
        }

        [TestMethod]
        public void TestConditional()
        {
            string sz = null;
            msg(sz.Length > 0);
            System.Diagnostics.Debug.WriteLine("test");
        }
    }
}
