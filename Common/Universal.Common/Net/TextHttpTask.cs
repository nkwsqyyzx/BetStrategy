using System;
using System.Net;

namespace WSQ.CSharp.Net
{
    /// <summary>
    /// GET/POST text request task
    /// </summary>
    internal abstract class TextHttpTask : HttpTask
    {

	/// <summary>
	/// the web client to handle request.
	/// </summary>
        protected WebClient _webClient;

        protected string _url;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="url"></param>
        public TextHttpTask(string url)
        {
            _url = url;
            _webClient = new WebClient();
            _webClient.Credentials = CredentialCache.DefaultCredentials;
        }

        /// <summary>
        /// Start to request
        /// </summary>
        public override void Start()
        {
            try
            {
                DoStart();
            }
            catch (Exception ex)
            {
                Cancel(ex.ToString());
            }
        }

        protected abstract void DoStart();

        /// <summary>
        /// Cancel the task
        /// </summary>
        public override void Cancel()
        {
            Cancel("request cancelled.");
        }

        /// <summary>
        /// Cancel the task
        /// </summary>
        /// <param name="reason">reason for cancel the task</param>
        public void Cancel(string reason)
        {
            try
            {
                OnError(reason);
                if (_webClient.IsBusy)
                {
                    _webClient.CancelAsync();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
