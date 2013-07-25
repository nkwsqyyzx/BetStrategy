﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace WSQ.CSharp.Net
{
    /// <summary>
    /// Task for posting string to server
    /// </summary>
    internal class PostTextHttpTask : TextHttpTask
    {
        private string _postData;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="parameters"></param>
        public PostTextHttpTask(string url, List<KeyValuePair<string, string>> parameters)
            : base(url)
        {
            _postData = ParseParameters(parameters);
            _webClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            _webClient.UploadStringCompleted += new UploadStringCompletedEventHandler(WebClient_UploadStringCompleted);
        }

        /// <summary>
        /// Start to request.
        /// </summary>
        protected override void DoStart()
        {
            _webClient.UploadStringAsync(new Uri(_url, UriKind.Absolute), _postData);
        }

        /// <summary>
        /// Parse parameters to form upload string.
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private string ParseParameters(List<KeyValuePair<string, string>> parameters)
        {
            string uploadMessage = string.Empty;
            if (parameters != null && parameters.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var param in parameters)
                {
                    sb.Append(param.Key);
                    sb.Append("=");
                    sb.Append(param.Value);
                    sb.Append("&");
                }
                uploadMessage = sb.ToString().TrimEnd('&');
            }
            return uploadMessage;
        }

        /// <summary>
        /// Call back from web client.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WebClient_UploadStringCompleted(object sender, UploadStringCompletedEventArgs e)
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
    }
}
