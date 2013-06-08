using BetStrategy.ViewModels;
using System.ComponentModel;

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
            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
