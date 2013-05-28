using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WSQ.CSharp.Helper;
using WSQ.CSharp.Extensions;
using BetStrategy.Utils;

namespace BetStrategy.ViewModels
{
    public class YieldRoiViewModel : BaseViewModel
    {
        private ObservableCollection<YieldRoiPerson> _topYieldRoiPerson = null;
        public ObservableCollection<YieldRoiPerson> TopYieldRoiPerson
        {
            get
            {
                return _topYieldRoiPerson;
            }
        }

        public YieldRoiViewModel() 
        {
            InitTopYieldRoiPerson();
        }

        private void InitTopYieldRoiPerson()
        {
            _topYieldRoiPerson = new ObservableCollection<YieldRoiPerson>();
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += (o, e) =>
            {
                Action<string> action = (dir) => 
                {
                    new Action(() => 
                    {
                        _topYieldRoiPerson.Add(YieldRoiProvider.Instance.GetPerson(dir)); 
                    }).RunOnUI();
                };
                FileHelper.GetAllPerson((dir) => action(dir));
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
