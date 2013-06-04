using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using BetStrategy.Models;
using WSQ.CSharp.Extensions;
using WSQ.CSharp.Helper;
using BetStrategy.Utils;

namespace BetStrategy.ViewModels
{
    public class TheViewModel : BaseViewModel
    {
        private ObservableCollection<YieldRoiRecommend> _recommends = new ObservableCollection<YieldRoiRecommend>();
        public ObservableCollection<YieldRoiRecommend> Recommends 
        {
            get 
            {
                return _recommends;
            }
        }

        private List<YieldRoiRecommend> AllRecommends = new List<YieldRoiRecommend>();

        public void Load(int count)
        {
            RefreshRecommends(count);
        }

        private void RefreshFinish(int count)
        {
            //AllRecommends.Sort(AllRecommends[0].ComparerFromProperty("Time2", true));
            var list = new List<YieldRoiRecommend>();
            var latest = AllRecommends.Take(count);
            foreach (var i in latest)
            {
                list.Add(i);
            }
            AllRecommends.Clear();
            AllRecommends.AddRange(list);
            new Action(() => ReloadList()).RunOnUI();
        }

        private void RefreshRecommends(int count)
        {
            AllRecommends.Clear();
            FileHelper.GetAllWaitingRecommends((rec) => AllRecommends.Add(new YieldRoiRecommend(rec)), ()=>RefreshFinish(count));
        }
        
        private void ReloadList()
        {
            _recommends.Clear();
            AllRecommends.Enumerate((i) => _recommends.Add(i));
        }
    }
}
