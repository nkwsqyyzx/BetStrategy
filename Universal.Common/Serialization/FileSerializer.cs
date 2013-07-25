using System;
using System.IO;

namespace WSQ.CSharp.Serialization
{
    public abstract class FileSerializer : IFileSerializer
    {
        public abstract void Serialize<T>(Stream stream, T data);

        public abstract T Deserialize<T>(Stream stream);

        public void Serialize<T>(string fileName, T data)
        {
            try
            {
                using (Stream fileStream = GetWriteStream(fileName))
                {
                    if (fileStream != null && data != null)
                    {
                        Serialize(fileStream, data);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Serialize failed:" + ex.Message);
            }
        }

        public T Deserialize<T>(string fileName)
        {
            T data = default(T);
            try
            {
                using (Stream fileStream = GetReadStream(fileName))
                {
                    data = Deserialize<T>(fileStream);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Deserialize failed:" + ex.Message);
            }
            return data;
        }

        /// <summary>
        /// open file to write
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        protected Stream GetWriteStream(string fileName)
        {
            var path = Path.Combine(Environment.CurrentDirectory, fileName);
            var dir = Path.GetDirectoryName(path);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            return File.Create(path);
        }

        /// <summary>
        /// open file to read.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        protected Stream GetReadStream(string fileName)
        {
            return File.OpenRead(Path.Combine(Environment.CurrentDirectory, fileName));
        }
    }
}
