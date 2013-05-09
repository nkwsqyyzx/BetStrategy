using BetStrategy.Common.Configurations;
using BetStrategy.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WSQ.CSharp.Net;
using WSQ.CSharp.Serialization;

namespace BetStrategy.ViewModels
{
    public class TopPersonProvider
    {
        private static string FILE = "TopPersonCaches.txt";
        private static FileStreamSerializer<TopPersonProvider> serializer = new JsonSerializer<TopPersonProvider>();

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

        private TopPersonProvider()
        {
            var saved = serializer.Deserialize(FILE);
            if (saved == null)
            {
                Update();
            }
            else
            {
                LastUpdateTime = saved.LastUpdateTime;
                TopPersons = saved.TopPersons;
            }
        }

        private void Update()
        {
            UpdateTopPerson((result) =>
            {
                LastUpdateTime = DateTime.Now;
                TopPersons = new List<Person>();
                foreach (var p in result)
                {
                    TopPersons.Add(p);
                }
                serializer.Serialize(FILE, this);
            });
        }

        private void UpdateTopPerson(Action<List<Person>> finished)
        {
            NetworkUtils.DownloadString(Constants.Instance.URL_BASE + Constants.Instance.URL_GAME_TOP, (ok, html, error) =>
            {
                if (ok)
                {
                    HtmlParser.HtmlParser.ParseTopPerson(html, finished);
                }
                else if (TopPersons != null && TopPersons.Count > 0)
                {
                    finished(TopPersons);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("ERROR WHEN DOWNLOADING TOP PERSON.");
                }
            });
        }

        private bool IsLatest()
        {
            return LastUpdateTime != null &&
                TopPersons != null &&
                TopPersons.Count > 0 &&
                DateTime.Now.Subtract(LastUpdateTime).TotalMinutes < Constants.Instance.INT_MINUTES_UPDATE_TOP_PERSON;
        }

        public void GetTopPerson(Action<DateTime, List<Person>> finished)
        {
            if (IsLatest())
            {
                finished(LastUpdateTime, TopPersons);
            }
            else
            {
                UpdateTopPerson((result) =>
                {
                    finished(DateTime.Now, result);
                });
            }
        }

        [JsonProperty]
        public DateTime LastUpdateTime { get; set; }

        [JsonProperty]
        private List<Person> TopPersons { get; set; }

        public bool IsReady
        {
            get
            {
                return IsLatest();
            }
        }
    }
}
