﻿using System;
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
    /// Interaction logic for TestWindow.xaml
    /// </summary>
    public partial class TestWindow : BaseWindow
    {
        public BaseViewModel ViewModel
        {
            get
            {
                return _viewModel as BaseViewModel;
            }
        }

        public TestWindow()
        {
            InitializeComponent();
            this.DataContext = new BaseViewModel();

            System.Diagnostics.Debug.WriteLine(this.ViewModel.GetType().ToString());
        }
    }
}
