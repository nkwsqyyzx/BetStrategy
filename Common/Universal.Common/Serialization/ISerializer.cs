using System.IO;

namespace WSQ.CSharp.Serialization
{
    public interface ISerializer<T>
    {
        /// <summary>
        /// Serialize data to stream.
        /// </summary>
        /// <param name="stream">the stream to store data.</param>
        /// <param name="data">the data to store.</param>
        void Serialize(Stream stream, T data);

        /// <summary>
        /// Deserialize data from stream.
        /// </summary>
        /// <param name="stream">the stream contains data.</param>
        /// <returns></returns>
        T Deserialize(Stream stream);
    }
}
