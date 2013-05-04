using BetStrategy.ViewModels;
using System;
using System.Windows;

namespace BetStrategy.Windows
{
    /// <summary>
    /// Interaction logic for BaseWindow
    /// </summary>
    public class BaseWindow : Window
    {
        protected BaseViewModel _viewModel = null;

        public BaseWindow()
        {
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
