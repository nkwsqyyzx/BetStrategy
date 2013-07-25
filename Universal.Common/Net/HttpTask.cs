
namespace WSQ.CSharp.Net
{
    /// <summary>
    /// Base task for http request
    /// </summary>
    internal abstract class HttpTask 
    {
        /// <summary>
        /// the request finished event.
        /// </summary>
        public event RequestFinished HttpRequestCompleted;

        /// <summary>
        /// start the request task.
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// cancel the request task.
        /// </summary>
        public abstract void Cancel();

        /// <summary>
        /// error occured
        /// </summary>
        /// <param name="errorString">error message</param>
        protected void OnError(string errorString)
        {
            NotifyCompleted(false, null, errorString);
        }

        /// <summary>
        /// notify the request has finished.
        /// </summary>
        /// <param name="succeeded"></param>
        /// <param name="response">the response</param>
        /// <param name="errorResult">error reason</param>
        protected virtual void NotifyCompleted(bool succeeded, string response, string errorResult)
        {
            if (HttpRequestCompleted != null)
            {
                HttpRequestCompleted(succeeded, response, errorResult);
            }
        }
    }
}
