using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BetStrategy.ViewModels;

namespace BetStrategy.Windows
{
    /// <summary>
    /// Interaction logic for RecommendModifyWindow.xaml
    /// </summary>
    public partial class RecommendModifyWindow : BaseWindow
    {
        public RecommendModifyWindow()
        {
            InitializeComponent();
        }

        private RecommendModifyViewModel ViewModel
        {
            get
            {
                return _viewModel as RecommendModifyViewModel;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Save();
        }
    }
}
