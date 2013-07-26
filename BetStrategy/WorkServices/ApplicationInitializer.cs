using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BetStrategy.Services.Factories;
using BetStrategy.Properties;

namespace BetStrategy.WorkServices
{
    public class ApplicationInitializer
    {
        public void Init()
        {
            InitRecommendManager();
        }

        private void InitRecommendManager()
        {
            RecommendManager.Instance.Init(Settings.Default.dbConnectionString,Settings.Default.urlBase);
        }
    }
}
