using BetStrategy.Models;
using BetStrategy.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using WSQ.CSharp.Extensions;
using WSQ.CSharp.Helper;

namespace BetStrategy.ViewModels
{
    public class YieldRoiViewModel : BaseViewModel
    {
        #region BINDABLE_PROPERTIES
        private List<YieldRoiPerson> Persons = new List<YieldRoiPerson>();
        private ObservableCollection<YieldRoiPerson> _topYieldRoiPerson = new ObservableCollection<YieldRoiPerson>();
        public ObservableCollection<YieldRoiPerson> TopYieldRoiPerson
        {
            get
            {
                return _topYieldRoiPerson;
            }
        }

        private int _min = 30;
        public int Min
        {
            get
            {
                return _min;
            }
            set
            {
                _min = value;
                Filter(_min);
            }
        }

        private int _current = 1;
        public int Current 
        {
            get 
            {
                return _current;
            }
            set
            {
                _current = value;
                // Filter(_current);
            }
        }

        private void Filter(int min)
        {
            TopYieldRoiPerson.Clear();
            foreach (var p in Persons)
            {
                if (p.Total >= min)
                {
                    TopYieldRoiPerson.Add(p);
                }
            }
        }

        private ICommand _viewPerson = null;
        public ICommand CommandViewPerson
        {
            get
            {
                return _viewPerson.RelayCommand<Person>((p) => ViewHelper.ViewPerson(p.Name));
            }
        }

        private ICommand _cmdRefresh = null;
        public ICommand CommandRefresh
        {
            get
            {
                return _cmdRefresh.RelayCommand(() => RefreshList());
            }
        }

        private void RefreshList()
        {
            foreach (var p in Persons)
            {
                p.Refresh();
            }
        }
        #endregion

        public YieldRoiViewModel()
        {
            InitTopYieldRoiPerson();
        }

        private void InitTopYieldRoiPerson()
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += (o, e) =>
            {
                Action<string> action = (dir) =>
                {
                    Persons.Add(YieldRoiProvider.Instance.GetPerson(dir));
                };
                Action finish = (() =>
                {
                    new Action(() => Filter(Min)).RunOnUI();
                });
                FileHelper.GetAllPerson((dir) => action(dir), finish);
            };
            bw.RunWorkerAsync();
        }

        public void Sort(string sortBy, ListSortDirection direction)
        {
            List<YieldRoiPerson> rms = new List<YieldRoiPerson>();
            foreach (var rec in _topYieldRoiPerson)
            {
                rms.Add(rec);
            }
            Comparison<YieldRoiPerson> com = rms[0].ComparerFromProperty(sortBy, direction == ListSortDirection.Descending);
            rms.Sort(com);

            _topYieldRoiPerson.Clear();
            foreach (var item in rms)
            {
                _topYieldRoiPerson.Add(item);
            }
        }
    }
}
