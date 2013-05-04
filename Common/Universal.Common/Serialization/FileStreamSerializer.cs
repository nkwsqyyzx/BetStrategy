using System;
using System.IO;

namespace WSQ.CSharp.Serialization
{
    public abstract class FileStreamSerializer<T> : ISerializer<T>
    {
        public abstract void Serialize(Stream stream, T data);

        public abstract T Deserialize(Stream stream);

        /// <summary>
        /// Serialize data to file.
        /// </summary>
        /// <param name="fileName">file to store data.</param>
        /// <param name="data"></param>
        public void Serialize(string fileName, T data)
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

        /// <summary>
        /// Deserialize data from file.
        /// </summary>
        /// <param name="fileName">the file contains data.</param>
        /// <returns></returns>
        public T Deserialize(string fileName)
        {
            T data = default(T);
            try
            {
                using (Stream fileStream = GetReadStream(fileName))
                {
                    data = Deserialize(fileStream);
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
            return File.Create(Path.Combine(Environment.CurrentDirectory, fileName));
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
