using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WSQ.CSharp.Net
{

    /// <summary>
    /// Http method
    /// </summary>
    public enum HttpMethod
    {
        Get,
        Post
    }

    public class NetworkUtils
    {
        /// <summary>
        /// Request for content (GET)
        /// </summary>
        /// <param name="url"></param>
        /// <param name="callback"></param>
        public static void DownloadString(string url, RequestFinished callback)
        {
            TaskPool.Instance.Request(
                url,
                HttpMethod.Get,
                null,
                new RequestFinished((isOk, result, errResult) => callback(isOk, result, errResult)));
        }

        /// <summary>
        /// Request for content (POST)
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postData"></param>
        /// <param name="callback"></param>
        public static void UploadString(string url, List<KeyValuePair<string, string>> postData, RequestFinished callback)
        {
            TaskPool.Instance.Request(
                url,
                HttpMethod.Post,
                postData,
                new RequestFinished((isOk, result, errResult) => callback(isOk, result, errResult)));
        }

        /// <summary>
        /// Cancel all networking requests
        /// </summary>
        public static void CancelAll()
        {
            TaskPool.Instance.CancelAll();
        }

        /// <summary>
        /// Get string from stream with UTF-8 encoding
        /// </summary>
        /// <param name="stream"></param>
        /// <returns>Converted string, string.Empty if failed</returns>
        private static string GetTextFromStream(Stream stream)
        {
            return GetTextFromStream(stream, Encoding.UTF8);
        }

        /// <summary>
        /// Get string from stream, default encoding is UTF-8
        /// </summary>
        /// <param name="stream"></param>
        /// <returns>Converted string, string.Empty if failed</returns>
        private static string GetTextFromStream(Stream stream, Encoding encoding)
        {
            string ret = string.Empty;
            StreamReader reader = new StreamReader(stream, encoding);
            try
            {
                ret = reader.ReadToEnd();
            }
            catch (Exception ex) 
            {
                System.Diagnostics.Debug.WriteLine("GetTextFromStream failed:" + ex.Message);
            }
            finally
            {
                reader.Close();
            }
            return ret;
        }
    }
}
