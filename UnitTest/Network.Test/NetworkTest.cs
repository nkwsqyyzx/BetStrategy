using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WSQ.CSharp.Net
{
    [TestClass]
    public class NetworkTest
    {
        [TestMethod]
        public void TestDownload()
        {
            RequestFinished finished = (ok, result, error) =>
            {
                if (ok)
                {
                    System.Diagnostics.Debug.WriteLine(result);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("DownloadString failed:" + error);
                }
            };
            NetworkUtils.DownloadString("http://www.baidu.com", new RequestFinished(finished));
        }
    }
}
