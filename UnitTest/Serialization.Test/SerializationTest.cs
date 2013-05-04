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

            SerializationManager.Instance.GetInstance<SerializationTest>().Serialize("Family.txt", child);
        }

        [TestMethod]
        public void TestDeserialize()
        {
            SerializationTest child = SerializationManager.Instance.GetInstance<SerializationTest>().Deserialize("Family.txt");
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

            child.Parents = new List<SerializationTest> {                 new SerializationTest(){ Name = "Mother", Age = 50} ,                new SerializationTest(){ Name = "Father",Age = 52}            };
            dic["key3"] = child;

            SerializationManager.Instance.GetInstance<Dictionary<string, object>>().Serialize("complicated.txt", dic);
        }

        [TestMethod]
        public void TestDeserializeDictionary()
        {
            var dic = SerializationManager.Instance.GetInstance<Dictionary<string, object>>().Deserialize("complicated.txt");
        }
    }
}
