using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using BetStrategy.Models;
using System.ComponentModel;
using WSQ.CSharp.Helper;

namespace BetStrategy.ViewModels
{
    public class PersonRecommendsViewModel : BaseViewModel
    {
        private string _summary;
        public string Summary
        {
            get
            {
                return _summary;
            }
            set
            {
                _summary = value;
                NotifyPropertyChange(() => Summary);
            }
        }

        private ObservableCollection<Recommend> _recommends = new ObservableCollection<Recommend>();
        public ObservableCollection<Recommend> Recommends
        {
            get
            {
                return _recommends;
            }
        }

        public void Load(string name)
        {
            YieldRoiPerson person = YieldRoiProvider.Instance.GetPerson(name);
            person.PropertyChanged += person_PropertyChanged;

            Action<Recommend> refresh = (rec) =>
            {
                new Action(() => AddRecommend(rec)).RunOnUI();
            };
            YieldRoiProvider.Instance.GetPersonRecommends(name, refresh);
        }

        private void AddRecommend(Recommend rec)
        {
            if (!Recommends.Any((i) => i.Time2 == rec.Time2))
            {
                Recommends.Add(rec);
            }
        }

        private string GetDescription(YieldRoiPerson p)
        {
            return string.Format("共推荐{0}场,{1}胜{2}半胜{3}走{4}输{5}输半,总Yield:{6},当前期Yield:{7},总ROI:{8},当前期ROI:{9}",
                p.Recommends.Count, p.Win, p.WinHalf, p.Draw, p.Lose, p.LoseHalf, p.TotalYield, p.CurrentYield, p.TotalROI, p.CurrentROI);
        }

        private void person_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Summary = GetDescription(sender as YieldRoiPerson);
        }
    }
}
