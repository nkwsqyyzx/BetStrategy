using BetStrategy.Domain.Models;
using BetStrategy.Messages;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BetStrategy.Services.Factories;
using WSQ.CSharp.Extensions;
using WSQ.CSharp.Helper;
using BetStrategy.Common.Configurations;

namespace BetStrategy.WorkServices
{
    public class EmailNotificationService
    {
        public bool IsEnableEmailNotification { get; set; }

        private List<Recommend> NotifiedRecommends;

        private List<Recommend> PendingRecommends = null;

        private EmailNotificationService()
        {
        }

        private static EmailNotificationService _instance = new EmailNotificationService();
        public static EmailNotificationService Instance { get { return _instance; } }

        public void Init(string sql)
        {
            SQL = sql;
            NotifiedRecommends = new List<Recommend>();
            PendingRecommends = new List<Recommend>();
            Messenger.Default.Register<DownloadFinishedMessage>(this, RecommendsDownloadFinish);
        }

        private bool IsFirst = true;
        private string SQL;
        private void RecommendsDownloadFinish(DownloadFinishedMessage msg)
        {
            PendingRecommends.Clear();
            if (IsEnableEmailNotification)
            {
                RecommendManager.Instance.RecommendCenter.GetRecommendsBySql(SQL, PendingRecommends.Add, Finish, (ex) => { });
            }
        }

        private bool Match(Recommend i, Recommend j)
        {
            return i.Time2 == j.Time2;
        }

        private void Finish()
        {
            PendingRecommends.RemoveAll((i) => i.PreferResult != PreferResult.Waiting);
            // 找到今天尚未通知的推荐 发送邮件
            if (!IsFirst)
            {
                // 剔除已经发送过通知的推荐
                NotifiedRecommends.Enumerate((i) => PendingRecommends.RemoveAll((k) => Match(i, k)));
                if (PendingRecommends.Count > 0)
                {
                    var subject = "新推荐：" + DateTime.Now.ToString(" MM-dd HH:mm");
                    var body = RecommendsToString(PendingRecommends);
                    EmailHelper.SendEmailViaGmail(EmailConfig.Instance.ToAddress, EmailConfig.Instance.Username, EmailConfig.Instance.Password, subject, body);
                }
            }
            PendingRecommends.Enumerate((i) => !NotifiedRecommends.Any((k) => Match(i, k)), (j) => NotifiedRecommends.Add(j));
            IsFirst = false;
        }

        private string RecommendsToString(IEnumerable<Recommend> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.AppendLine(RecommendToString(item));
            }
            return sb.ToString();
        }

        private string RecommendToString(Recommend item)
        {
            string body = item.Person + " :"
                + item.Host + " " + item.OddStake + " "
                + item.Guest + " 推荐：" + item.Prefer + " " + item.Odds;
            return body;
        }
    }
}
