using BetStrategy.ViewModels;

namespace BetStrategy.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : BaseWindow
    {
        private MainViewModel ViewModel
        {
            get
            {
                return _viewModel as MainViewModel;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += (s, e) => ViewModel.Init();
        }
    }
}
