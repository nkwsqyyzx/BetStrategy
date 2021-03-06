﻿using BetStrategy.ViewModels;
using System.ComponentModel;
using System.Windows;

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
            this.Close();
        }
    }
}
