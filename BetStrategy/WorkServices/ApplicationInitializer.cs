using BetStrategy.Properties;
using BetStrategy.Services.Factories;

namespace BetStrategy.WorkServices
{
    public class ApplicationInitializer
    {
        public void Init()
        {
            InitRecommendManager();
            InitEmailNotification();
        }

        private void InitRecommendManager()
        {
            RecommendManager.Instance.Init(Settings.Default.dbConnectionString, Settings.Default.urlBase);
        }

        private void InitEmailNotification()
        {
            EmailNotificationService.Instance.Init(Settings.Default.dbSelectRecommends);
        }
    }
}
