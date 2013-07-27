using BetStrategy.Common.Configurations;
using BetStrategy.Domain.Models;
using BetStrategy.Services.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using GalaSoft.MvvmLight.Messaging;
using BetStrategy.Messages;

namespace BetStrategy.WorkServices
{
    public class RecommendService
    {
        private RecommendService() { }
        private static RecommendService instance = new RecommendService();
        public static RecommendService Instance { get { return instance; } }

        public void EnableAutoDownload(bool trueToEnable)
        {
            if (trueToEnable)
            {
                EnsureTimer();
                _timer.Start();
            }
            else if (_timer != null)
            {
                _timer.Stop();
            }
        }

        public void Download(int pages)
        {
            if (pages > 0)
            {
                RecommendManager.Instance.RecommendCenter.Download(0, pages, SaveRecommend, DownloadFinish);
            }
        }

        private DispatcherTimer _timer;
        private void EnsureTimer()
        {
            if (_timer != null)
            {
                return;
            }
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, Constants.Instance.INT_MINUTES_UPDATE_RECOMMEND, 30);
            _timer.Tick += timer_Tick;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RecommendManager.Instance.RecommendCenter.Download(1, 0, SaveRecommend, DownloadFinish);
        }

        private void DownloadFinish(int count)
        {
            Messenger.Default.Send(new DownloadFinishedMessage() { Count = count });
            Messenger.Default.Send(new BalloonMessage() { Message = "成功下载" + count + "条推荐" });
        }

        private void SaveRecommend(IEnumerable<Recommend> obj)
        {
            RecommendManager.Instance.RecommendCenter.SaveRecommends(obj);
        }
    }
}
