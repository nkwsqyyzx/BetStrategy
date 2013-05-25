using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BetStrategy.ViewModels;
using System.Threading;
using System.IO;
using System.Net;
using BetStrategy.HtmlParser;

namespace ProjectUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestYieldRoiProvider()
        {
            YieldRoiProvider pro = YieldRoiProvider.Instance;
            pro.GetPersonRecommends("格力电器", (ls) =>
            {
                foreach (var rec in ls)
                {
                    System.Diagnostics.Debug.WriteLine(rec.Prefer.Description);
                }
            });
            Thread.Sleep(100000);
        }

        [TestMethod]
        public void TestGet() 
        {
            string Url = "http://www.yn1999.com/Game_User.asp?id=章鱼帝";
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(Url);
            myRequest.Method = "PUT";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.GetEncoding("GBK"));
            string result = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();

            System.Diagnostics.Debug.WriteLine(result);
        }

        [TestMethod]
        public void TesHtmlParser() {
            HtmlParser.ParseRecommends(TestData.GAME_USER_HTML, (rs) =>
            {
                System.Diagnostics.Debug.WriteLine(rs.Count);
            });
        }
    }
}
