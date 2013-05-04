using BetStrategy.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace BetStrategy.Windows
{
    /// <summary>
    /// Interaction logic for GameTopWindow.xaml
    /// </summary>
    public partial class GameTopWindow : BaseWindow
    {
        private GridViewColumnHeader _lastHeaderClicked;
        private ListSortDirection _lastDirection;

        private GameTopViewModel ViewModel
        {
            get
            {
                return _viewModel as GameTopViewModel;
            }
        }

        public GameTopWindow()
        {
            InitializeComponent();
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            var contextMenu = (sender as MenuItem).Parent as ContextMenu;
            var headerClicked = contextMenu.PlacementTarget as GridViewColumnHeader;
            ListSortDirection direction;

            if (headerClicked != null)
            {
                if (headerClicked.Role != GridViewColumnHeaderRole.Padding)
                {
                    if (headerClicked != _lastHeaderClicked)
                    {
                        direction = ListSortDirection.Ascending;
                    }
                    else
                    {
                        if (_lastDirection == ListSortDirection.Ascending)
                        {
                            direction = ListSortDirection.Descending;
                        }
                        else
                        {
                            direction = ListSortDirection.Ascending;
                        }
                    }

                    string header = (headerClicked.Column.DisplayMemberBinding as Binding).Path.Path;
                    Sort(header, direction);

                    if (direction == ListSortDirection.Ascending)
                    {
                        headerClicked.Column.HeaderTemplate = Resources["HeaderTemplateArrowUp"] as DataTemplate;
                    }
                    else
                    {
                        headerClicked.Column.HeaderTemplate = Resources["HeaderTemplateArrowDown"] as DataTemplate;
                    }

                    // Remove arrow from previously sorted header
                    if (_lastHeaderClicked != null && _lastHeaderClicked != headerClicked)
                    {
                        _lastHeaderClicked.Column.HeaderTemplate = null;
                    }


                    _lastHeaderClicked = headerClicked;
                    _lastDirection = direction;
                }
            }
        }

        private void Sort(string sortBy, ListSortDirection direction)
        {
            ViewModel.Sort(sortBy, direction);
        }
    }
}
