using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading;
using WSQ.CSharp.Extensions;

namespace CommonTest
{
    public class A
    {
        public string szA { get; set; }
        public int iA { get; set; }
    }

    public class B
    {
        public A A { get; set; }

        public string szB { get; set; }
    }

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            var m = (new B()).ComparerFromProperty("A.szA");
            List<B> bs = new List<B>();
            B b1 = new B() { A = new A() { szA = "szA1", iA = 10 }, szB = "szB1" };
            B b2 = new B() { A = new A() { szA = "szA2" }, szB = "szB2" };
            bs.Add(b1);
            bs.Add(b2);

            bs.Sort(m);

            Thread.Sleep(100000);
        }

        [TestMethod]
        public void EmptyTest()
        {
        }

        [TestMethod]
        public void TestProperty()
        {
            B b1 = new B() { A = new A() { szA = "szA1" }, szB = "szB1" };
            var x = b1.Property("szB");
            var y = b1.Property("A");
            var z = b1.Property("A.szA");
            var m = b1.Property("A.iA");
        }
    }
}
