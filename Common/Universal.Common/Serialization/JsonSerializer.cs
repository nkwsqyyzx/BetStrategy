using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters;

namespace WSQ.CSharp.Serialization
{
    public class JsonSerializer : FileSerializer
    {
        private static JsonSerializerSettings setting = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.Auto,
            TypeNameAssemblyFormat = FormatterAssemblyStyle.Full
        };

        public override void Serialize<T>(Stream stream, T data)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data, Formatting.Indented, setting);
                using (TextWriter writer = new StreamWriter(stream))
                {
                    writer.Write(json);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Serialize failed:" + ex.Message);
            }
        }

        public override T Deserialize<T>(Stream stream)
        {
            T data = default(T);
            try
            {
                using (TextReader reader = new StreamReader(stream))
                {
                    data = JsonConvert.DeserializeObject<T>(reader.ReadToEnd(), setting);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Deserialize failed:" + ex.Message);
            }
            return data;
        }
    }
}
