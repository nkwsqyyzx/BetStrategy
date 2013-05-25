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
            //_webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:21.0) Gecko/20100101 Firefox/21.0");
            //_webClient.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
            //_webClient.Headers.Add("Accept-Language", "zh-cn,zh;q=0.8,en-us;q=0.5,en;q=0.3");
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
            _webClient.DownloadStringAsync(new Uri(_url, UriKind.RelativeOrAbsolute));
        }
    }
}
