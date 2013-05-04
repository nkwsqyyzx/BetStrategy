using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HtmlAgilityPack
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HtmlDocument doc = new HtmlDocument();
            doc.Load("game_show.html");

            OutPut(doc.DocumentNode);
        }

        private void OutPut(HtmlNode node)
        {
            System.Diagnostics.Debug.WriteLine(node.Name + node.InnerHtml);
            if (node.ChildNodes != null)
            {
                foreach (var n in node.ChildNodes)
                {
                    OutPut(n);
                }
            }
        }
    }
}
