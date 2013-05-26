using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WSQ.CSharp.Serialization
{
    [TestClass]
    public class SerializationTest
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<SerializationTest> Parents { get; set; }

        [TestMethod]
        public void TestSerialize()
        {
            SerializationTest child = new SerializationTest();
            child.Name = "Child";
            child.Age = 18;

            child.Parents = new List<SerializationTest> {
                new SerializationTest(){ Name = "Mother", Age = 50} ,
                new SerializationTest(){ Name = "Father",Age = 52}
            };

            SerializationManager.Instance.GetInstance().Serialize("Family.txt", child);
        }

        [TestMethod]
        public void TestDeserialize()
        {
            SerializationTest child = SerializationManager.Instance.GetInstance().Deserialize<SerializationTest>("Family.txt");
        }

        [TestMethod]
        public void TestSerializeDictionary()
        {
            var dic = new Dictionary<string, object>();
            dic["key1"] = "Key1Value";
            dic["key2"] = 3333;
            SerializationTest child = new SerializationTest();
            child.Name = "Child";
            child.Age = 18;

            child.Parents = new List<SerializationTest> {
                new SerializationTest(){ Name = "Mother", Age = 50} ,
                new SerializationTest(){ Name = "Father",Age = 52}
            };
            dic["key3"] = child;

            SerializationManager.Instance.GetInstance().Serialize("complicated.txt", dic);
        }

        [TestMethod]
        public void TestDeserializeDictionary()
        {
            var dic = SerializationManager.Instance.GetInstance().Deserialize<Dictionary<string, object>>("complicated.txt");
        }

        [TestMethod]
        public void TestSerializeDirectory()
        {
            var dic = new Dictionary<string, object>();
            dic.Add("k1", 1000);
            dic.Add("k2", "hello,world");
            dic.Add("k3", new List<object>() { 1000, "hello" });

            SerializationManager.Instance.GetInstance().Serialize("dir1/dir2/dir3/save.txt", dic);
        }
    }
}
