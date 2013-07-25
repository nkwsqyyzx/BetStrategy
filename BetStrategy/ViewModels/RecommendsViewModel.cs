using BetStrategy.Domain.Models;
using BetStrategy.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WSQ.CSharp.Helper;

namespace BetStrategy.ViewModels
{
    public class RecommendsViewModel : BaseViewModel
    {
        #region BIND_PROPERTIES
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

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                NotifyPropertyChange(() => Title);
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
        #endregion

        private Person Person;

	/// <summary>
	/// 加载某个人的记录
	/// </summary>
	/// <param name="name"></param>
        public void Load(string name)
        {
            Title = name;

            Person = new Person() { Name = name };

            Action<Recommend> refresh = (rec) =>
            {
                new Action(() => AddRecommend(rec)).RunOnUI();
            };

            Action refreshFinish = () =>
            {
                new Action(() => RefreshRecommends()).RunOnUI();
            };
            YieldRoiProvider.Instance.GetPersonRecommends(name, refresh, refreshFinish);
        }

        private void RefreshRecommends()
        {
            List<Recommend> recs = new List<Recommend>();
            recs.AddRange(Recommends);

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
            Recommends.Clear();
            foreach (var r in recs)
            {
                Recommends.Add(r);
            }

            CalculatePerson();
        }

        private void CalculatePerson()
        {
            YieldRoiHelper.RefreshProfit(Recommends, Person);
            float totalYield = YieldRoiHelper.CalculateYield(Recommends);
            float totalRoi = YieldRoiHelper.CalculateRoi(Recommends);

            var current = from item in Recommends where item.Current == Recommends.FirstOrDefault().Current select item;
            float currentYield = YieldRoiHelper.CalculateYield(current);
            float currentRoi = YieldRoiHelper.CalculateRoi(current);

            Summary = GetDescription(Person, totalYield, totalRoi, currentYield, currentRoi);
        }

        private void AddRecommend(Recommend rec)
        {
            if (!Recommends.Any((i) => i.Time2 == rec.Time2))
            {
                Recommends.Add(rec);
            }
        }

        private string GetDescription(Person p, float totalYield, float totalRoi, float currentYield, float currentRoi)
        {
            return string.Format("共推荐{0}场,{1}胜{2}半胜{3}走{4}输{5}输半,总Yield:{6},当前期Yield:{7},总ROI:{8},当前期ROI:{9}",
                p.Total, p.Win, p.WinHalf, p.Draw, p.Lose, p.LoseHalf, totalYield, currentYield, totalRoi, currentRoi);
        }
    }
}
