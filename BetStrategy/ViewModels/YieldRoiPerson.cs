using BetStrategy.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using WSQ.CSharp.Helper;

namespace BetStrategy.ViewModels
{
    public class YieldRoiPerson : Person, INotifyPropertyChanged
    {
        public YieldRoiPerson(string name)
        {
            _recommends = new List<Recommend>();
            LoadPerson(name);
        }

        private void LoadPerson(string name)
        {
            YieldRoiProvider pro = YieldRoiProvider.Instance;
            Action<List<Recommend>> callback = (recommends) =>
            {
                Refresh(name, recommends);
            };
            pro.GetPersonRecommends(name, callback);
        }

        private void Refresh(string name, List<Recommend> recommends)
        {
            // must run on UITHREAD.
            Action action = () =>
            {
                Name = name;
                _recommends.Clear();
                foreach (var i in recommends)
                {
                    _recommends.Add(i);
                }
                Draw = _recommends.Count((i) => i.PreferResult == PreferResult.Useless);
                Lose = _recommends.Count((i) => i.PreferResult == PreferResult.Lose);
                LoseHalf = _recommends.Count((i) => i.PreferResult == PreferResult.LoseHalf);
                WinHalf = _recommends.Count((i) => i.PreferResult == PreferResult.WinHalf);
                Win = _recommends.Count((i) => i.PreferResult == PreferResult.Win);

                RefreshYieldAndRoi();
                // notify all properties.
                NotifyPropertyChange(string.Empty);
            };
            action.RunOnUI();
        }

        private static float GainLose(Recommend rc)
        {
            float radio = 0.0f;
            switch (rc.PreferResult)
            {
                case PreferResult.Lose: radio = -1.0f; break;
                case PreferResult.LoseHalf: radio = -0.5f; break;
                case PreferResult.Useless: radio = 0; break;
                case PreferResult.Win: radio = 1.0f; break;
                case PreferResult.WinHalf: radio = 0.5f; break;
                case PreferResult.Waiting: radio = 0; break;
                default: break;
            }
            return rc.Odds * radio;
        }

        private void RefreshYieldAndRoi()
        {
            TotalYield = CaluculateYield(_recommends);
            TotalROI = CalculateRoi(_recommends);

            var list = (from item in _recommends where item.Current == _recommends[0].Current select item).ToList();
            CurrentYield = CaluculateYield(list);
            CurrentROI = CalculateRoi(list);
        }

        private float CalculateRoi(IList<Recommend> list)
        {
            var roi = 0.0f;
            foreach (var item in list)
            {
                roi += GainLose(item);
            }
            return roi;
        }

        private float CaluculateYield(IList<Recommend> newItems)
        {
            var totalYield = 0.0f;
            foreach (var rc in newItems)
            {
                var rec = rc as Recommend;
                totalYield += GainLose(rec);
            }
            return newItems.Count > 0 ? totalYield / (float)newItems.Count : 0.0f;
        }

        private List<Recommend> _recommends = null;
        /// <summary>
        /// 所有推荐列表
        /// </summary>
        public List<Recommend> Recommends
        {
            get
            {
                return _recommends;
            }
        }

        private float _totalROI;
        /// <summary>
        /// 总体ROI
        /// </summary>
        public float TotalROI
        {
            get
            {
                return _totalROI;
            }
            set
            {
                _totalROI = value;
                NotifyPropertyChange(() => TotalROI);
            }
        }

        private float _currentROI;
        /// <summary>
        /// 当前期ROI
        /// </summary>
        public float CurrentROI
        {
            get
            {
                return _currentROI;
            }
            set
            {
                _currentROI = value;
                NotifyPropertyChange(() => CurrentROI);
            }
        }

        private float _totalYield;
        /// <summary>
        /// 总体Yield
        /// </summary>
        public float TotalYield
        {
            get
            {
                return _totalYield;
            }
            set
            {
                _totalYield = value;
                NotifyPropertyChange(() => TotalYield);
            }
        }

        private float _currentYield;
        /// <summary>
        /// 当前期Yield
        /// </summary>
        public float CurrentYield
        {
            get
            {
                return _currentYield;
            }
            set
            {
                _currentYield = value;
                NotifyPropertyChange(() => CurrentYield);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChange<T>(Expression<Func<T>> expression)
        {
            var propertyName = ((MemberExpression)expression.Body).Member.Name;
            NotifyPropertyChange(propertyName);
        }

        protected void NotifyPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
