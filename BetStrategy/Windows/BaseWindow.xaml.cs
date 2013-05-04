using System;
using System.Windows;
using BetStrategy.ViewModels;

namespace BetStrategy.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BaseWindow : System.Windows.Window
    {
        protected BaseViewModel _viewModel = null;

        public BaseWindow()
        {
            InitializeComponent();
            this.DataContextChanged += BaseWindow_DataContextChanged;
        }

        private void BaseWindow_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is BaseViewModel)
            {
                _viewModel = e.NewValue as BaseViewModel;
                _viewModel.UiDispatcher = this.Dispatcher;
            }
            else
            {
                throw new ArgumentException("DataContext is not BaseViewModel");
            }
        }
    }
}
