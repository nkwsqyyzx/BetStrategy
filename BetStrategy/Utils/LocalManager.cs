
namespace BetStrategy.Utils
{
    public class LocalManager
    {
        private static ILocal _instance = DB.Instance;
        public static ILocal Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
