using BetStrategy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;

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
            MessageBox.Show("功能目前尚未实现!尚无法保存");
        }
    }
}
