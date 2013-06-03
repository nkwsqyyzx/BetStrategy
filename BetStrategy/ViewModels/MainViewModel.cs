using HtmlAgilityPack;
using System.Collections.ObjectModel;
using WSQ.CSharp.Net;
using BetStrategy.Models;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using BetStrategy.Windows;
using System.Windows.Threading;
using BetStrategy.Common.Configurations;
using System.ComponentModel;
using System.Linq;
using WSQ.CSharp.Helper;
using System.Text;

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
                if (_cmdGameShow == null)
                {
                    _cmdGameShow = new RelayCommand(() =>
                    {
                        GameShow();
                    });
                }
                return _cmdGameShow;
            }
        }

        /// <summary>
        /// 展示擂台参赛纪录
        /// </summary>
        private void GameShow()
        {
            if (WinGameShow == null)
            {
                WinGameShow = new RecommendsWindow();
                WinGameShow.Closed += (o, e) => WinGameShow = null;
            }
            WinGameShow.Show();
        }

        private ICommand _cmdGameTop;
        public ICommand CommandGameTop
        {
            get
            {
                if (_cmdGameTop == null)
                {
                    _cmdGameTop = new RelayCommand(() =>
                    {
                        GameTop();
                    });
                }
                return _cmdGameTop;
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
            WinGameTop.Show();
        }

        private ICommand _cmdBest;
        public ICommand CommandBestPrefer
        {
            get
            {
                if (_cmdBest == null)
                {
                    _cmdBest = new RelayCommand(() =>
                    {
                        BestRecommends();
                    });
                }
                return _cmdBest;
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
            WinGameBest.Show();
        }

        private ICommand _cmdUnkown;
        public ICommand CommandUnkownRecommends
        {
            get
            {
                if (_cmdUnkown == null)
                {
                    _cmdUnkown = new RelayCommand(() =>
                    {
                        UnknownRecommends();
                    });
                }
                return _cmdUnkown;
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

