using System.Collections.Generic;
using System.Text;
using System.Web;

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
	/// encoding url.
	/// </summary>
	/// <param name="url"></param>
	/// <param name="coding"></param>
	/// <returns></returns>
        public static string UrlEncode(string url, Encoding coding) 
        {
            return HttpUtility.UrlEncode(url, coding);
        }
    }
}
