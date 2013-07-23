using BetStrategy.Common.Configurations;
using BetStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WSQ.CSharp.Helper;

namespace BetStrategy.Utils
{
    public class NotifyHelper
    {
	/// <summary>
	/// 已经通知过的推荐
	/// </summary>
        private List<Recommend> NotifiedRecommends = new List<Recommend>();

	/// <summary>
	/// 是否允许邮件通知
	/// </summary>
        public bool IsEnabled { get; set; }

	/// <summary>
	/// 通知这些推荐
	/// </summary>
	/// <param name="recs"></param>
        public void SendNotice(IEnumerable<Recommend> recs)
        {
            string subject = null;
            string body = null;
            EmailHelper.SendEmailViaGmail(EmailConfig.Instance.Username, EmailConfig.Instance.ToAddress, EmailConfig.Instance.Username, EmailConfig.Instance.Password, subject, body);
        }
    }
}
