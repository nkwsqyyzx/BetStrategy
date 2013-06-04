using BetStrategy.Common.Configurations;
using BetStrategy.Models;
using BetStrategy.Utils;
using GalaSoft.MvvmLight.Command;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using WSQ.CSharp.Helper;
using WSQ.CSharp.Extensions;
using WSQ.CSharp.Net;
using WSQ.CSharp.Serialization;

namespace BetStrategy.ViewModels
{
    public class GameTopViewModel : BaseViewModel
    {
        private ObservableCollection<Person> _topPerson = null;
        public ObservableCollection<Person> TopPerson
        {
            get
            {
                if (_topPerson == null)
                {
                    _topPerson = new ObservableCollection<Person>();
                }
                return _topPerson;
            }
        }

        private ICommand _cmdRefresh = null;
        public ICommand CommandRefresh
        {
            get
            {
                return _cmdRefresh.RelayCommand(() => DownloadTopPerson());
            }
        }

        public GameTopViewModel()
        {
            DownloadTopPerson();
        }

        public void DownloadTopPerson()
        {
            NetworkUtils.DownloadString(Constants.Instance.URL_BASE + Constants.Instance.URL_GAME_TOP, (ok, html, error) =>
            {
                if (ok)
                {
                    ParseTopPersonFromHtml(html);
                }
            });
        }

        private void ParseTopPersonFromHtml(string html)
        {
            HtmlParser.ParseTopPerson(html, (persons) =>
            {
                (new Action(() =>
                {
                    TopPerson.Clear();
                    persons.ForEach((i) => TopPerson.Add(i));
                })).RunOnUI();
            });
        }

        public void Sort(string sortBy, ListSortDirection direction)
        {
            List<Person> ps = new List<Person>();
            ps.AddRange(TopPerson);

            ps.Sort(ps[0].ComparerFromProperty(sortBy, direction == ListSortDirection.Descending));

            TopPerson.Clear();
            ps.ForEach((i) => TopPerson.Add(i));
        }

        private void SaveBestPerson()
        {
            List<Person> best = new List<Person>();
            TopPerson.Enumerate(IsBest, (i) => best.Add(i));
            IFileSerializer serializer = SerializationManager.Instance.GetInstance();
            serializer.Serialize(Constants.Instance.FILEPATH_GAME_TOP_BEST, best);
        }

        private static bool IsBest(Person p) 
        {
            return p.Profit >= (float)(Constants.Instance.COUNT_MIN_PROFIT);
        }
    }
}
