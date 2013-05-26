using BetStrategy.Common.Configurations;
using BetStrategy.Models;
using BetStrategy.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WSQ.CSharp.Net;
using WSQ.CSharp.Serialization;

namespace BetStrategy.ViewModels
{
    public class DataInternal
    {
        public DateTime LastUpdateTime { get; set; }

        public List<Person> TopPersons { get; set; }

        public List<string> PreferMost { get; set; }

        private bool IsLatest()
        {
            return LastUpdateTime != null &&
                TopPersons != null &&
                TopPersons.Count > 0 &&
                DateTime.Now.Subtract(LastUpdateTime).TotalMinutes < Constants.Instance.INT_MINUTES_UPDATE_TOP_PERSON;
        }

        public bool IsReady
        {
            get
            {
                return IsLatest();
            }
        }
    }

    public class TopPersonProvider
    {
        private static string FILE = "TopPersonCaches.txt";
        private DataInternal data;
        private static FileStreamSerializer<DataInternal> serializer = new JsonSerializer<DataInternal>();

        private static TopPersonProvider _instance;
        public static TopPersonProvider Instance
        {
            get
            {
                lock (typeof(TopPersonProvider))
                {
                    if (_instance == null)
                    {
                        _instance = new TopPersonProvider();
                    }
                    return _instance;
                }
            }
        }

        public TopPersonProvider()
        {
            var saved = serializer.Deserialize(FILE);
            if (saved == null)
            {
                Update();
            }
            else
            {
                data = saved;
            }
        }

        private void Update()
        {
            UpdateTopPerson(Save);
        }

        private void Save(List<Person> result)
        {
            if (data == null)
            {
                data = new DataInternal();
            }
            if (data.TopPersons == null)
            {
                data.TopPersons = new List<Person>();
            }
            if (data.PreferMost == null)
            {
                data.PreferMost = new List<string>();
            }

            data.LastUpdateTime = DateTime.Now;
            data.TopPersons.Clear();
            foreach (var p in result)
            {
                data.TopPersons.Add(p);
            }

            if (data.PreferMost.Count == 0)
            {
                int max = Math.Min(result.Count, 8);
                var list = result.Take(max);
                foreach (var item in list)
                {
                    data.PreferMost.Add(item.Name);
                }
            }
            serializer.Serialize(FILE, data);
        }

        private void UpdateTopPerson(Action<List<Person>> finished)
        {
            NetworkUtils.DownloadString(Constants.Instance.URL_BASE + Constants.Instance.URL_GAME_TOP, (ok, html, error) =>
            {
                if (ok)
                {
                    HtmlParser.ParseTopPerson(html, (rs) =>
                    {
                        Save(rs);
                        finished(rs);
                    });
                }
                else if (data != null && data.TopPersons != null && data.TopPersons.Count > 0)
                {
                    finished(data.TopPersons);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("ERROR WHEN DOWNLOADING TOP PERSON.");
                }
            });
        }


        public void GetTopPerson(Action<DateTime, List<Person>> finished)
        {
            if (data != null && data.IsReady)
            {
                finished(data.LastUpdateTime, data.TopPersons);
            }
            else
            {
                UpdateTopPerson((result) =>
                {
                    finished(DateTime.Now, result);
                });
            }
        }

        public List<string> PreferMost
        {
            get
            {
                if (data != null && data.PreferMost != null && data.PreferMost.Count > 0)
                {
                    return data.PreferMost;
                }
                return new List<string>();
            }
        }
    }
}
