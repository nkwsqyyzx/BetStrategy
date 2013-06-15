using BetStrategy.Models;
using System;
using System.Collections.Generic;
using System.IO;
using WSQ.CSharp.Extensions;
using WSQ.CSharp.Serialization;

namespace BetStrategy.Utils
{
    /// <summary>
    /// 处理文件读写的类
    /// </summary>
    public class FileHelper : ILocal
    {
        private static FileHelper _instance = new FileHelper();
        public static FileHelper Instance { get { return _instance; } }

        private IFileSerializer Serializer = SerializationManager.Instance.GetInstance();

        public void SaveRecommend(Recommend rec)
        {
            var path = PathHelper.RecommendPath(rec);
            if (File.Exists(path))
            {
                //该文件已经存在.且推荐的状态没有改变.
            }
            else
            {
                //第一次写或者状态从等待状态改为有结果状态.
                DeleteWaitingRecommendsRecord(rec);
                Serializer.Serialize(path, rec);
            }
        }

        private void DeleteWaitingRecommendsRecord(Recommend rec)
        {
            if (rec.PreferResult != PreferResult.Waiting)
            {
                var result = rec.PreferResult;
                rec.PreferResult = PreferResult.Waiting;
                DeleteRecommend(rec);
                rec.PreferResult = result;
            }
        }

        /// <summary>
        /// 从本地删除推荐.慎用!
        /// </summary>
        /// <param name="rec"></param>
        public void DeleteRecommend(Recommend rec)
        {
            var path = PathHelper.RecommendPath(rec);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public void SaveRecommends(IEnumerable<Recommend> recs)
        {
            recs.Enumerate((i) => SaveRecommend(i));
        }

        public void GetAllPerson(Action<string> onPerson, Action finish = null)
        {
            var persons = PathHelper.AllPersons();
            foreach (var p in persons)
            {
                onPerson(p);
            }
            if (finish != null)
            {
                finish();
            }
        }

        /// <summary>
        /// 获取用户所有已结算的推荐
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="onRecommend"></param>
        /// <param name="finish"></param>
        public void GetRecommends(string name, Action<Recommend> onRecommend, Action finish = null)
        {
            var recommends = PathHelper.Recommends(name);
            foreach (var rpath in recommends)
            {
                var rec = Serializer.Deserialize<Recommend>(rpath);
                onRecommend(rec);
            }
            if (finish != null)
            {
                finish();
            }
        }

        /// <summary>
        /// 所有未结算的推荐
        /// </summary>
        /// <param name="onRecommend"></param>
        /// <param name="finish"></param>
        public void GetAllWaitingRecommends(Action<Recommend> onRecommend, Action finish = null)
        {
            var paths = PathHelper.WaitingRecommends();
            foreach (var p in paths)
            {
                var rec = Serializer.Deserialize<Recommend>(p);
                onRecommend(rec);
            }
            if (finish != null)
            {
                finish();
            }
        }

        /// <summary>
        /// 获取最新推荐
        /// </summary>
        /// <param name="count"></param>
        /// <param name="onRecommend"></param>
        /// <param name="finish"></param>
        public void GetLatestRecommends(int count, Action<Recommend> onRecommend, Action finish = null)
        {
            var latest = PathHelper.LatestRecommends(count);
            foreach (var p in latest)
            {
                var rec = Serializer.Deserialize<Recommend>(p);
                onRecommend(rec);
            }
            if (finish != null)
            {
                finish();
            }
        }


        public void GetUnFinishedRecommends(Action<Recommend> onRecommend, Action finish = null)
        {
            throw new NotImplementedException();
        }


        public void GetPersons(Action<Person> onPerson, Action finish = null)
        {
            throw new NotImplementedException();
        }
    }
}
