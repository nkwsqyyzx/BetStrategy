using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WSQ.CSharp.Configuration
{
    /// <summary>
    /// dictionary can be serialable
    /// </summary>
    /// <typeparam name="TKey">key</typeparam>
    /// <typeparam name="TValue">value</typeparam>
    [XmlRoot("dictionary")]
    public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, IXmlSerializable
    {
        // cache the type XmlSerializer.
        private static Dictionary<Type, XmlSerializer> _cacheSerializer = new Dictionary<Type, XmlSerializer>();
        private static XmlSerializer GetSerializer(Type type)
        {
            if (_cacheSerializer.ContainsKey(type))
            {
                return _cacheSerializer[type];
            }
            else
            {
                XmlSerializer zer = new XmlSerializer(type);
                _cacheSerializer[type] = zer;
                return zer;
            }
        }

        #region IXmlSerializable Members
        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(System.Xml.XmlReader reader)
        {
            bool wasEmpty = reader.IsEmptyElement;
            reader.Read();

            if (wasEmpty)
                return;

            while (reader.NodeType != System.Xml.XmlNodeType.EndElement)
            {
                reader.ReadStartElement("item");
                reader.ReadStartElement("key");
                TKey key = (TKey)GetSerializer(typeof(TKey)).Deserialize(reader);
                reader.ReadEndElement();
                reader.ReadStartElement("value");
                TValue value = (TValue)GetSerializer(typeof(TValue)).Deserialize(reader);
                reader.ReadEndElement();
                this.Add(key, value);
                reader.ReadEndElement();
                reader.MoveToContent();
            }

            reader.ReadEndElement();
        }

        public void WriteXml(System.Xml.XmlWriter writer)
        {
            foreach (TKey key in this.Keys)
            {
                writer.WriteStartElement("item");
                writer.WriteStartElement("key");
                GetSerializer(key.GetType()).Serialize(writer, key);
                writer.WriteEndElement();
                writer.WriteStartElement("value");
                TValue value = this[key];
                GetSerializer(value.GetType()).Serialize(writer, value);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }
        }
        #endregion
    }
}
