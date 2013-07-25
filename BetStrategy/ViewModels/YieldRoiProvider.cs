using BetStrategy.Domain.Models;
using BetStrategy.Utils;
using System;
using WSQ.CSharp.Serialization;

namespace BetStrategy.ViewModels
{
    internal class _YieldRoi
    {
        public string Name { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public YieldRoiPerson Person { get; set; }

        /// <summary>
        /// 数据保留24小时.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public bool IsLatest
        {
            get
            {
                return Person != null && DateTime.Now.Subtract(LastUpdateTime).TotalMinutes < 24 * 60;
            }
        }
    }

    public class YieldRoiProvider
    {
        #region INSTANCE
        private static YieldRoiProvider _instance = new YieldRoiProvider();
        public static YieldRoiProvider Instance
        {
            get
            {
                return _instance;
            }
        }
        #endregion

        private IFileSerializer serializer = SerializationManager.Instance.GetInstance();
        private YieldRoiProvider() { }
        public void GetPersonRecommends(string name, Action<Recommend> onRecommend, Action finish = null)
        {
            LocalManager.Instance.GetRecommends(name, onRecommend, finish);
        }

        private string GetCachedYieldRoiPerson(string name)
        {
            return PathHelper.PersonYield(name);
        }

        public YieldRoiPerson GetPerson(string name)
        {
            var data = serializer.Deserialize<_YieldRoi>(GetCachedYieldRoiPerson(name));
            if (data != null && data.IsLatest)
            {
                return data.Person;
            }
            else
            {
                var person = new YieldRoiPerson(name);
                return person;
            }
        }

        public void SavePerson(YieldRoiPerson person)
        {
            var data = new _YieldRoi();
            data.LastUpdateTime = DateTime.Now;
            data.Name = person.Name;
            data.Person = person;
            serializer.Serialize(GetCachedYieldRoiPerson(person.Name), data);
        }
    }
}
