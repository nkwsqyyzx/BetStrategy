using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WSQ.CSharp.Serialization
{
    public interface IFileSerializer : ISerializer
    {
        /// <summary>
        /// Serialize data to file.
        /// </summary>
        /// <param name="fileName">file to store data.</param>
        /// <param name="data"></param>
        void Serialize<T>(string fileName, T data);

        /// <summary>
        /// Deserialize data from file.
        /// </summary>
        /// <param name="fileName">the file contains data.</param>
        /// <returns></returns>
        T Deserialize<T>(string fileName);
    }
}
