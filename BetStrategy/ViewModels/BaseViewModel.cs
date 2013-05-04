using System.Windows.Threading;

namespace BetStrategy.ViewModels
{
    public class BaseViewModel : NotifyModel
    {
        public Dispatcher UiDispatcher { get; set; }
    }
}