using BetStrategy.Common.Configurations;
using BetStrategy.Models;
using BetStrategy.Utils;
using GalaSoft.MvvmLight.Command;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WSQ.CSharp.Extensions;
using WSQ.CSharp.Helper;
using WSQ.CSharp.Net;
using WSQ.CSharp.Serialization;

namespace BetStrategy.ViewModels
{
    public class GameShowViewModel : BaseViewModel
    {

        private List<Recommend> _allRecommends = new List<Recommend>();
        private ObservableCollection<Recommend> _recommends = new ObservableCollection<Recommend>();
        /// <summary>
        /// 推荐列表
        /// </summary>
        public ObservableCollection<Recommend> Recommends
        {
            get
            {
                if (_recommends.Count == 0)
                {
                    foreach (var item in _allRecommends)
                    {
                        _recommends.Add(item);
                    }
                }
                return _recommends;
            }
        }

        private ICommand _cmdRefresh;
        public ICommand CommandRefresh
        {
            get
            {
                return _cmdRefresh.RelayCommand(() => DownloadRecommends());
            }
        }

        private ICommand _cmdViewBest;
        public ICommand CommandViewBest
        {
            get
            {
                return _cmdViewBest.RelayCommand(() => ViewBest());
            }
        }

        public GameShowViewModel()
        {
            DownloadRecommends();
        }

        public void DownloadRecommends()
        {
            NetworkUtils.DownloadString(Constants.Instance.URL_BASE + Constants.Instance.URL_GAME_SHOW, (ok, html, error) =>
            {
                if (ok)
                {
                    ParseRecommendsFromHtml(html);
                }
            });
        }

        private void ParseRecommendsFromHtml(string html)
        {
            HtmlParser.ParseRecommends(html, (results) =>
            {
                (new Action(() =>
                {
                    _allRecommends.Clear();
                    _recommends.Clear();
                    foreach (var rec in results)
                    {
                        _allRecommends.Add(rec);
                        _recommends.Add(rec);
                    }
                })).RunOnUI();
            });
        }

        static IFileSerializer serializer = SerializationManager.Instance.GetInstance();
        private void ViewBest()
        {
            List<Person> best = serializer.Deserialize<List<Person>>(Constants.Instance.FILEPATH_GAME_TOP_BEST);
            List<Recommend> bRs = new List<Recommend>();
            if (best != null && best.Count > 0)
            {
                foreach (var item in _allRecommends)
                {
                    if (best.Any((b) => b.Name == item.Person))
                    {
                        bRs.Add(item);
                    }
                }

                _recommends.Clear();
                foreach (var item in bRs)
                {
                    _recommends.Add(item);
                }
            }
        }

        public void Sort(string sortBy, ListSortDirection direction)
        {
            List<Recommend> rms = new List<Recommend>();
            foreach (var rec in _recommends)
            {
                rms.Add(rec);
            }
            if (sortBy == "Person.Name")
            {
                rms.Sort(new Comparison<Recommend>(delegate(Recommend x, Recommend y)
                    {
                        int result = 0;
                        /* fixme
                                    if (x.Person.Profit > y.Person.Profit)
                                        result = 1;
                                    if (x.Person.Profit < y.Person.Profit)
                                        result = -1;*/
                        return (direction == ListSortDirection.Descending ? -1 : 1) * result;
                    }));
            }
            else
            {
                Comparison<Recommend> com = rms[0].ComparerFromProperty(sortBy, direction == ListSortDirection.Descending);
                rms.Sort(com);
            }

            _recommends.Clear();
            foreach (var item in rms)
            {
                _recommends.Add(item);
            }
        }
    }
}
