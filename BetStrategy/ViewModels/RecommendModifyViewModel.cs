using BetStrategy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using BetStrategy.Utils;

namespace BetStrategy.ViewModels
{
    public class RecommendModifyViewModel : BaseViewModel
    {
        private ObservableCollection<Recommend> _recommends = new ObservableCollection<Recommend>();
        public ObservableCollection<Recommend> Recommends
        {
            get
            {
                return _recommends;
            }
        }

        public RecommendModifyViewModel(Recommend rec)
        {
            Recommends.Add(rec);
        }

        public void Save()
        {
            //TODO. 如果开赛时间一样,主队客队一样,盘口和推荐都一样,一并保存
            LocalManager.Instance.SaveRecommends(_recommends);
        }
    }
}
