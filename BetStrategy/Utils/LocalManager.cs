
namespace BetStrategy.Utils
{
    public class LocalManager
    {
        private static ILocal _instance = FileHelper.Instance;
        public static ILocal Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
