using System;
using System.Net;

namespace WSQ.CSharp.Net
{
    /// <summary>
    /// Task for get request.
    /// </summary>
    internal class GetTextHttpTask : TextHttpTask
    {

        /// <summary>
        /// Consturctor.
        /// </summary>
        /// <param name="url">the url to request.</param>
        public GetTextHttpTask(string url)
            : base(url)
        {
            _webClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(WebClient_DownloadStringCompleted);
        }

        /// <summary>
        /// Callback from webclient.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WebClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error == null && !e.Cancelled)
            {
                NotifyCompleted(true, e.Result, string.Empty);
            }
            else
            {
                NotifyCompleted(false, string.Empty, e.Error.Message);
            }
        }

        /// <summary>
        /// Start to download strings from url.
        /// </summary>
        protected override void DoStart()
        {
            _webClient.DownloadStringAsync(new Uri(_url, UriKind.Absolute));
        }
    }
}
