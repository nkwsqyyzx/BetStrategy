using System.IO;

namespace WSQ.CSharp.Serialization
{
    public class XmlSerializer : FileSerializer
    {

        public override void Serialize<T>(Stream stream, T data)
        {
            XmlSerializer serializer = new XmlSerializer();
            serializer.Serialize<T>(stream, data);
        }

        public override T Deserialize<T>(Stream stream)
        {
            T data = default(T);
            XmlSerializer serializer = new XmlSerializer();
            var deserializedData = (T)serializer.Deserialize<T>(stream);
            if (deserializedData != null && deserializedData is T)
            {
                data = deserializedData;
            }
            return data;
        }
    }
}
