using BetStrategy.Domain.Models;
using BetStrategy.Services.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using WSQ.CSharp.Helper;

namespace BetStrategy.ViewModels
{
    public class YieldRoiPerson : Person, INotifyPropertyChanged
    {
        public YieldRoiPerson()
        {
            _recommends = new List<Recommend>();
        }

        public YieldRoiPerson(string dir)
            : this()
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += (o, e) => LoadPerson(dir);
            bw.RunWorkerAsync();
        }

        /// <summary>
        /// 刷新Yield/ROI等数据
        /// </summary>
        public void Refresh()
        {
            LoadPerson(this.Name);
        }

        private void LoadPerson(string dir)
        {
            Name = dir;
            YieldRoiProvider pro = YieldRoiProvider.Instance;
            Action<Recommend> callback = (rec) =>
            {
                Add(rec);
            };
            pro.GetPersonRecommends(dir, callback, LoadFinish);
        }

        private void LoadFinish()
        {
            new Action(() =>
            {
                RefreshYieldAndRoi();

                YieldRoiHelper.RefreshProfit(_recommends, this);
                // notify all properties.
                NotifyPropertyChange(string.Empty);
                YieldRoiProvider.Instance.SavePerson(this);
            }).RunOnUI();
        }

        private void Add(Recommend rec)
        {
            Name = rec.Person;
            Action action = () =>
            {
                if (!_recommends.Any((m) => m.Time2 == rec.Time2))
                {
                    _recommends.Add(rec);
                }
            };
            action.RunOnUI();
        }

        private void Sort(List<Recommend> recs)
        {
            recs.Sort(new Comparison<Recommend>((s, r) =>
            {
                int first = r.Current.CompareTo(s.Current);
                if (first == 0)
                {
                    return r.Time2.CompareTo(s.Time2);
                }
                else
                {
                    return first;
                }
            }));
        }

        private void RefreshYieldAndRoi()
        {
            Sort(_recommends);
            TotalYield = YieldRoiHelper.CalculateYield(_recommends);
            TotalROI = YieldRoiHelper.CalculateRoi(_recommends);

            var list = (from item in _recommends where item.Current == _recommends[0].Current select item);
            CurrentYield = YieldRoiHelper.CalculateYield(list);
            CurrentROI = YieldRoiHelper.CalculateRoi(list);
            Current = list.Count();
        }


        private List<Recommend> _recommends = null;
        /// <summary>
        /// 所有推荐列表
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
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

        private int _current;
        /// <summary>
        /// 当前期推荐
        /// </summary>
        public int Current
        {
            get
            {
                return _current;
            }
            set
            {
                _current = value;
                NotifyPropertyChange(() => Current);
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
