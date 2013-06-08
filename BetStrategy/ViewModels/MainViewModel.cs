using BetStrategy.Common.Configurations;
using BetStrategy.Utils;
using BetStrategy.Windows;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using WSQ.CSharp.Extensions;

namespace BetStrategy.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private Window WinGameShow;
        private Window WinGameTop;
        private Window WinGameBest;
        private Window WinGameUnknown;

        private ICommand _cmdGameShow;
        public ICommand CommandGameShow
        {
            get
            {
                return _cmdGameShow.RelayCommand(() => GameShow());
            }
        }

        /// <summary>
        /// 展示擂台参赛纪录
        /// </summary>
        private void GameShow()
        {
            if (WinGameShow == null)
            {
                var vm = new PersonRecommendsViewModel();
                WinGameShow = new PersonRecommendsWindow();
                WinGameShow.DataContext = vm;
                WinGameShow.Loaded += (o, e) => vm.Load(500);
                WinGameShow.Closed += (o, e) => WinGameShow = null;
            }
            WinGameShow.Activate();
            WinGameShow.Show();
        }

        private ICommand _cmdGameTop;
        public ICommand CommandGameTop
        {
            get
            {
                return _cmdGameTop.RelayCommand(() => GameTop());
            }
        }

        /// <summary>
        /// 推荐牛人排行榜
        /// </summary>
        private void GameTop()
        {
            if (WinGameTop == null)
            {
                WinGameTop = new YieldRoiWindow();
                WinGameTop.Closed += (o, e) => WinGameTop = null;
            }
            WinGameTop.Activate();
            WinGameTop.Show();
        }

        private ICommand _cmdBest;
        public ICommand CommandBestPrefer
        {
            get
            {
                return _cmdBest.RelayCommand(() => BestRecommends());
            }
        }

        /// <summary>
        /// 牛人的最新推荐
        /// </summary>
        private void BestRecommends()
        {
            if (WinGameBest == null)
            {
                WinGameBest = new RecommendsWindow();
                WinGameBest.Closed += (o, e) => WinGameBest = null;
            }
            WinGameBest.Activate();
            WinGameBest.Show();
        }

        private ICommand _cmdUnkown;
        public ICommand CommandUnkownRecommends
        {
            get
            {
                return _cmdUnkown.RelayCommand(() => UnknownRecommends());
            }
        }

        /// <summary>
        /// 查看尚未出结果的比赛
        /// </summary>
        private void UnknownRecommends()
        {
            if (WinGameUnknown == null)
            {
                var vm = new PersonRecommendsViewModel();
                WinGameUnknown = new PersonRecommendsWindow();
                WinGameUnknown.DataContext = vm;
                WinGameUnknown.Loaded += (o, e) => vm.LoadUnFinished();
                WinGameUnknown.Closed += (o, e) => WinGameUnknown = null;
            }
            WinGameUnknown.Activate();
            WinGameUnknown.Show();
        }

        private bool _check = true;
        public bool CheckBoxIsChecked
        {
            get
            {
                return _check;
            }
            set
            {
                _check = value;
                NotifyPropertyChange(() => CheckBoxIsChecked);
                Start(_check);
            }
        }

        public MainViewModel()
        {
        }

        private DispatcherTimer _timer;
        public void Init()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, Constants.Instance.INT_MINUTES_UPDATE_RECOMMEND, 30);
            _timer.Tick += timer_Tick;
            _timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
#if !TEST
            Downloader.DownloadRecommends(1, null, null);
#endif
        }

        private void Start(bool flag)
        {
            if (!flag)
            {
                _timer.Stop();
            }
            else
            {
                _timer.Start();
                timer_Tick(null, null);
            }
        }
    }
}