using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BetStrategy.ViewModels;
using System.Threading;
using System.IO;
using System.Net;
using BetStrategy.Utils;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
                System.Diagnostics.Debug.WriteLine(ls.Prefer);
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
        public void TesHtmlParser()
        {
            HtmlParser.ParseRecommends(TestData.GAME_USER_HTML, (rs) =>
            {
                foreach (var rec in rs)
                {
                    System.Diagnostics.Debug.WriteLine("Host:" + rec.Host + " League:" + rec.League);
                }
            });
            Thread.Sleep(100000);
        }

        [TestMethod]
        public void TestSaveRecommends()
        {
            HtmlParser.ParseRecommends(TestData.GAME_USER_HTML, (rs) =>
            {
                FileHelper.SaveRecommends(rs);
            });
        }

        [TestMethod]
        public void TestGetRecommends()
        {
            FileHelper.GetAllRecommends("格力电器", (rec) =>
            {
                System.Diagnostics.Debug.WriteLine(rec.Host + " " + rec.OddStake + " " + rec.Guest + ":" + rec.Result);
            });
            Thread.Sleep(100000);
        }

        [TestMethod]
        public void DownloadPersonRecommends()
        {
	    /*
            foreach (var name in TestData.TopPersons)
            {
                System.Diagnostics.Debug.WriteLine("start to download person:" + name);
                YieldRoiProvider.Instance.DownloadRecommends(name, 1, null);
                Thread.Sleep(5000);
            }
            System.Diagnostics.Debug.WriteLine("finished downloading");
            Thread.Sleep(1000 * 1000 * 1000);
	    */
        }

        [TestMethod]
        public void DownloadLight()
        {
	    /*
            List<string> lights = new List<string>() { "12388123", "1300100915", "234678136", "BVBReus", "LXF1234", "lanquan11", "lijian520", "lk930", "qqzy", "ronapigu", "segespa", "sos73", "wintion", "zxy60120", "zy530", "云里金刚虎", "低调玩球一齐杀庄", "公测", "动听的乐章", "哥哥", "地狱黑仔王", "小李飞刀", "小球下盘", "希望之星", "弹弓六", "战无不胜", "无极旋风", "杀手47", "梅西的左脚", "水龙头", "爽爽", "空中飞人", "空山新雨", "红日", "红红火火", "罗纳尔多", "蛋定", "足球擂台", "量力而為", "金牌出击", "锐壮壮", "顺水顺风", "龙缘" };
            foreach (var name in lights)
            {
                System.Diagnostics.Debug.WriteLine("start to download person:" + name);
                YieldRoiProvider.Instance.DownloadRecommends(name, 1, null);
                Thread.Sleep(15040);
            }
            System.Diagnostics.Debug.WriteLine("finished downloading");
            Thread.Sleep(1000 * 1000 * 1000);
            */
        }

        [TestMethod]
        public void TestAddEmtpyString()
        {
            List<string> list = new List<string>();
            list.Add("");
            list.Add("");
            list.Add("");
            list.Add("");
        }
    }
}
