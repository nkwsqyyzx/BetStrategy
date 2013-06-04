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
        private Window WinGameBest;

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
                var vm = new TheViewModel();
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

        }

        private bool _check;
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

        private static MainViewModel _instance;
        public static MainViewModel Instance
        {
            get
            {
                return _instance;
            }
        }

        private DispatcherTimer _timer;
        public MainViewModel()
        {
            _instance = this;
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, Constants.Instance.INT_MINUTES_UPDATE_RECOMMEND, 30);
            _timer.Tick += timer_Tick;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
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