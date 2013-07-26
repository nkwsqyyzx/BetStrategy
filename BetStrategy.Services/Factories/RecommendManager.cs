using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BetStrategy.Services.Recommends.Services;
using BetStrategy.Services.Impl.Wrappers;

namespace BetStrategy.Services.Factories
{
    public class RecommendManager
    {
        private IRecommendCenter recommendCenter = null;
        public IRecommendCenter RecommendCenter
        {
            get
            {
                return recommendCenter;
            }
        }

        private static RecommendManager recommendManager = new RecommendManager();
        private RecommendManager() { }
        public static RecommendManager Instance
        {
            get
            {
                return recommendManager;
            }
        }

        public void Init(string connectionString, string urlBase)
        {
            var localHelper = new DatabaseWrapper(new SqliteDbCommandFactory(connectionString));
            var serverHelper = new RecommendDownloader(urlBase);
            recommendCenter = new RecommendCenter(localHelper, serverHelper);
        }
    }
}
