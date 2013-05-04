using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSQ.CSharp.Configuration;

namespace Configuration.Test
{
    internal enum KKKK
    {
        [Config(typeof(int))]
        Key1,
        [Config(typeof(T))]
        Key2
    }

    internal class T
    {
        public string AA { get; set; }
        public string BB { get; set; }

        public List<string> CC { get; set; }

        public T D { get; set; }
    }

    [TestClass]
    public class ConfigurationTest
    {
        [TestMethod]
        public void TestDefaultConfiguration()
        {
            KKKK.Key1.Set(8999);
            var t = KKKK.Key1.Get<int>(null);
        }

        [TestMethod]
        public void TestFileNameConfiguration()
        {
            IConfig cm = ConfigurationManager.GetInstance("file_to_save_configuration.json.txt");
            KKKK.Key1.Set(999, cm);
            int t = KKKK.Key1.Get<int>(cm);
        }

        [TestMethod]
        public void TestComplicateClassSet()
        {
            IConfig cm = ConfigurationManager.GetInstance("testfile.txt");
            KKKK.Key2.Set(new T()
            {
                AA = "AA",
                BB = "BB",
                CC = new List<string>() { "CC1", "CC2" },
                D = new T() { AA = "D.AA", BB = "D.BB", CC = new List<string>() { "D.CC1", "D.CC2" } }
            }, cm);
        }

        [TestMethod]
        public void TestComplicateClassGet()
        {
            IConfig cm = ConfigurationManager.GetInstance("testfile.txt");
            var m = KKKK.Key2.Get<T>(cm);
        }

        [TestMethod]
        public void TestInitConfigurationIfNoFileExsists()
        {
            IConfig cm = ConfigurationManager.GetInstance("averylongfilenamefile.txt", (cfg) =>
            {
                KKKK.Key2.Set(new T()
                    {
                        AA = "AA",
                        BB = "BB",
                        CC = new List<string>() { "CC1", "CC2" },
                        D = new T() { AA = "D.AA", BB = "D.BB", CC = new List<string>() { "D.CC1", "D.CC2" } }
                    }, cfg);
            });
            var m = KKKK.Key2.Get<T>(cm);
        }
    }
}
