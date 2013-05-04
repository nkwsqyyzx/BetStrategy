using System;
using System.Xml.Serialization;
using System.IO;
using System.Threading.Tasks;

namespace WSQ.CSharp.Serialization
{
    public class XmlSerializer<T> : FileStreamSerializer<T>
    {

        public override void Serialize(Stream stream, T data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(stream, data);
        }

        public override T Deserialize(Stream stream)
        {
            T data = default(T);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            var deserializedData = (T)serializer.Deserialize(stream);
            if (deserializedData != null && deserializedData is T)
            {
                data = deserializedData;
            }
            return data;
        }
    }
}
