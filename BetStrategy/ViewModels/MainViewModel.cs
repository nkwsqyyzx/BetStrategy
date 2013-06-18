using BetStrategy.Common.Configurations;
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
        private Window WinViewBest;
        private Window WinGameLatest200;
        private Window WinGameUnknown;

        private ICommand _cmdGameShow = null;
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
                WinGameShow.Title = "未完场推荐";
                WinGameShow.Loaded += (o, e) => vm.LoadUnFinished();
                WinGameShow.Closed += (o, e) => WinGameShow = null;
            }
            WinGameShow.Activate();
            WinGameShow.Show();
        }

        private ICommand _cmdGameTop = null;
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

        private ICommand _cmdViewBest = null;
        public ICommand CommandViewBest
        {
            get
            {
                return _cmdViewBest.RelayCommand(() => ViewBest());
            }
        }

        private void ViewBest()
        {
            if (WinViewBest == null)
            {
                var vm = new PersonRecommendsViewModel();
                vm.EnableControl = Visibility.Collapsed;
                WinViewBest = new PersonRecommendsWindow();
                WinViewBest.DataContext = vm;
                WinViewBest.Title = "最牛逼人的推荐";
                WinViewBest.Loaded += (o, e) => vm.LoadBest();
                WinViewBest.Closed += (o, e) => WinViewBest = null;
            }
            WinViewBest.Activate();
            WinViewBest.Show();
        }

        private ICommand _cmdLatest200 = null;
        public ICommand CommandLatest200
        {
            get
            {
                return _cmdLatest200.RelayCommand(() => GameLatest200());
            }
        }

        private void GameLatest200()
        {
            if (WinGameLatest200 == null)
            {
                var vm = new PersonRecommendsViewModel();
                WinGameLatest200 = new PersonRecommendsWindow();
                WinGameLatest200.DataContext = vm;
                WinGameLatest200.Title = "最近200场推荐";
                WinGameLatest200.Loaded += (o, e) => vm.Load(200);
                WinGameLatest200.Closed += (o, e) => WinGameLatest200 = null;
            }
            WinGameLatest200.Activate();
            WinGameLatest200.Show();
        }

        private ICommand _cmdUnkown = null;
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
                WinGameUnknown.Title = "未知推荐结果的推荐";
                WinGameUnknown.Loaded += (o, e) => vm.LoadUnknown();
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
            BetStrategy.Utils.Downloader.DownloadRecommends(2, null, null);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            BetStrategy.Utils.Downloader.DownloadRecommends(1, null, null);
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
            }
        }
    }
}