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
                        if (WinGameShow == null)
                        {
                            WinGameShow = new PersonRecommendsWindow();
                            WinGameShow.Closed += (o, e) => WinGameShow = null;
                        }
                        WinGameShow.Show();
                    });
                }
                return _cmdGameShow;
            }
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
                        if (WinGameTop == null)
                        {
                            WinGameTop = new GameTopWindow();
                            WinGameTop.Closed += (o, e) => WinGameTop = null;
                        }
                        WinGameTop.Show();
                    });
                }
                return _cmdGameTop;
            }
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
                        if (WinGameBest == null)
                        {
                            WinGameBest = new PersonRecommendsWindow();
                            WinGameBest.Closed += (o, e) => WinGameBest = null;
                        }
                        WinGameBest.Show();
                    });
                }
                return _cmdBest;
            }
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

