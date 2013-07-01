using BetStrategy.Common.Configurations;
using BetStrategy.Converters;
using BetStrategy.Models;
using BetStrategy.Utils;
using BetStrategy.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WSQ.CSharp.Extensions;
using WSQ.CSharp.Helper;

namespace BetStrategy.ViewModels
{
    public class PersonRecommendsViewModel : BaseViewModel
    {
        private PreferResultToStringConverter converter = new PreferResultToStringConverter();

        private ObservableCollection<YieldRoiRecommend> _recommends = new ObservableCollection<YieldRoiRecommend>();

        #region BINDABLE PROPERTIES
        private bool _isPreferMostChecked = true;
        public bool CheckBoxPreferMostIsChecked
        {
            get { return _isPreferMostChecked; }
            set
            {
                _isPreferMostChecked = value;
                NotifyPropertyChange(() => CheckBoxPreferMostIsChecked);
                ReloadList();
            }
        }

        private bool _useSelfDefined = false;
        public bool UseSelfDefined
        {
            get { return _useSelfDefined; }
            set
            {
                _useSelfDefined = value;
                NotifyPropertyChange(() => UseSelfDefined);
            }
        }

        private bool _showSQLText = false;
        public bool ShowSQLText
        {
            get { return _showSQLText; }
            set { _showSQLText = value; NotifyPropertyChange(() => ShowSQLText); }
        }

        private bool _isViewFinished = true;
        public bool CheckBoxViewFinishedIsChecked
        {
            get { return _isViewFinished; }
            set
            {
                _isViewFinished = value;
                NotifyPropertyChange(() => CheckBoxViewFinishedIsChecked);
                ReloadList();
            }
        }

        private Single _selectedProfit = 0;
        public Single SelectedProfit
        {
            get { return _selectedProfit; }
            set
            {
                _selectedProfit = value;
                Constants.Instance.COUNT_MIN_PROFIT = value;
                ReloadList();
            }
        }

        private bool _enableEmail = false;
        public bool EnableEmailNotify
        {
            get { return _enableEmail; }
            set
            {
                _enableEmail = value;
                NotifyPropertyChange(() => EnableEmailNotify);
            }
        }

        private bool _enable = true;
        public bool EnableControl
        {
            get { return _enable; }
            set
            {
                _enable = value;
                NotifyPropertyChange(() => EnableControl);
                CheckBoxViewFinishedIsChecked = true;
                CheckBoxPreferMostIsChecked = false;
            }
        }

        private string _sqlText = BetStrategy.Properties.Settings.Default.dbSelectRecommends;
        public string SQLText
        {
            get { return _sqlText; }
            set { _sqlText = value; NotifyPropertyChange(() => SQLText); }
        }
        #endregion

        #region BINDABLE COLLECTIONS
        private List<YieldRoiRecommend> AllRecommends = new List<YieldRoiRecommend>();
        public ObservableCollection<YieldRoiRecommend> Recommends
        {
            get { return _recommends; }
        }
        #endregion

        #region COMMANDS
        private ICommand _cmdRefresh = null;
        public ICommand CommandRefresh
        {
            get { return _cmdRefresh.RelayCommand(() => RefreshRecommends()); }
        }

        private ICommand _cmdViewYield = null;
        public ICommand CommandViewYield
        {
            get { return _cmdViewYield.RelayCommand(() => ShowYieldWindow()); }
        }

        private Window YieldView;
        private void ShowYieldWindow()
        {
            if (YieldView == null)
            {
                YieldView = new YieldRoiWindow();
                YieldView.Closed += (o, e) => { YieldView = null; };
            }
            YieldView.Show();
            YieldView.Activate();
        }

        private ICommand _viewPerson = null;
        public ICommand CommandViewPerson
        {
            get { return _viewPerson.RelayCommand<YieldRoiRecommend>((rec) => ViewHelper.ViewPerson(rec.Recommend.Person)); }
        }
        #endregion

        private Predicate<YieldRoiRecommend> Predicate = null;
        private void ReloadList()
        {
            _recommends.Clear();
            AllRecommends.Enumerate(Predicate == null ? (i) => IsValidRecommend(i) : Predicate, (j) => _recommends.Add(j));
        }

        private bool IsValidRecommend(YieldRoiRecommend rec)
        {
            bool result = !_isViewFinished ? rec.Recommend.PreferResult == PreferResult.Waiting : true;
            result = result && IsTopPerson(rec.Recommend.Person);
            return result;
        }

        private bool IsTopNewRecommend(Recommend item)
        {
            return IsTopPerson(item.Person) && item.PreferResult == PreferResult.Waiting;
        }

        private bool IsTopPerson(string name)
        {
            if (_isPreferMostChecked)
            {
                return TopPersonProvider.Instance.PreferMost.Contains(name);
            }
            else
            {
                var personInTopPerson = TopPerson.FindLast((i) => i.Name == name);
                return personInTopPerson != null && personInTopPerson.Profit >= SelectedProfit;
            }
        }

        public PersonRecommendsViewModel()
        {
            StartUpdate();
        }

        public void StartUpdate()
        {
            GetTopPerson();
        }

        private DateTime LastTimeUpdatePerson;
        private List<Person> TopPerson = new List<Person>();
        private void GetTopPerson()
        {
            TopPersonProvider.Instance.GetTopPerson((last, persons) =>
            {
                if (last == LastTimeUpdatePerson)
                    return;
                LastTimeUpdatePerson = last;
                (new Action(() =>
                {
                    TopPerson.Clear();
                    foreach (var p in persons)
                    {
                        TopPerson.Add(p);
                    }

                    if (TopPerson.Count > 0)
                    {
                        RefreshRecommends();
                    }
                })).RunOnUI();
            });
        }

        private Action lastRefreshCommand = null;
        private void RefreshRecommends()
        {
            if (lastRefreshCommand != null)
            {
                lastRefreshCommand();
            }
        }

        public void Sort(string sortBy, ListSortDirection direction)
        {
            List<YieldRoiRecommend> rms = new List<YieldRoiRecommend>();
            foreach (var rec in _recommends)
            {
                rms.Add(rec);
            }

            var sorted = direction == ListSortDirection.Ascending ?
                rms.OrderBy((i) => i.Property(sortBy)) :
                rms.OrderByDescending((i) => i.Property(sortBy));

            _recommends.Clear();
            foreach (var item in sorted)
            {
                _recommends.Add(item);
            }
        }

        #region ......
        public void Load(int count)
        {
            RefreshRecommends(count);
            lastRefreshCommand = new Action(() => RefreshRecommends(count));
        }

        public void LoadUnFinished()
        {
            RefreshUnfinishedRecommends();
            lastRefreshCommand = new Action(() => RefreshUnfinishedRecommends());
        }

        public void LoadBest()
        {
            RefreshTheBest();
            lastRefreshCommand = new Action(() => RefreshTheBest());
        }

        public void LoadUnknown()
        {
            RefreshUnknownRecommends();
            lastRefreshCommand = new Action(() => RefreshUnknownRecommends());
        }

        public void LoadSelfDefined()
        {
            RefreshSelfDefined();
            lastRefreshCommand = new Action(() => RefreshSelfDefined());
        }

        private void OnRecommend(Recommend rec)
        {
            AllRecommends.Add(new YieldRoiRecommend(rec));
        }

        private void RefreshFinish()
        {
            new Action(() => ReloadList()).RunOnUI();
        }

        private void RefreshRecommends(int count)
        {
            AllRecommends.Clear();
            LocalManager.Instance.GetLatestRecommends(count, OnRecommend, RefreshFinish);
        }

        private void RefreshUnfinishedRecommends()
        {
            AllRecommends.Clear();
            LocalManager.Instance.GetUnFinishedRecommends(OnRecommend, RefreshFinish);
        }

        private void RefreshUnknownRecommends()
        {
            AllRecommends.Clear();
            LocalManager.Instance.GetAllWaitingRecommends(OnRecommend, RefreshFinish);
        }

        private void RefreshTheBest()
        {
            Predicate = (i) => i.Person.Total >= 120 && i.Person.TotalYield >= 0.07;
            AllRecommends.Clear();
            LocalManager.Instance.GetAllWaitingRecommends(OnRecommend, RefreshFinish);
        }

        private void RefreshSelfDefined()
        {
            Action<Exception> onSqlError = (ex) =>
            {
                MessageBox.Show("SQL 语法错误:" + ex.Message);
            };
            AllRecommends.Clear();
            LocalManager.Instance.GetRecommendsBySql(SQLText, OnRecommend, RefreshFinish, onSqlError);
        }
        #endregion

        public void Modify(YieldRoiRecommend recommend)
        {
            RecommendModifyWindow window = new RecommendModifyWindow();
            window.DataContext = new RecommendModifyViewModel(recommend.Recommend);
            window.Activate();
            window.Show();
        }
    }
}
