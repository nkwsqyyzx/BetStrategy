using BetStrategy.ViewModels;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace BetStrategy.Windows
{
    /// <summary>
    /// Interaction logic for PersonRecommendsWindow.xaml
    /// </summary>
    public partial class PersonRecommendsWindow : BaseWindow
    {
        private GridViewColumnHeader _lastHeaderClicked;
        private ListSortDirection _lastDirection;
        private PersonRecommendsViewModel ViewModel
        {
            get
            {
                return _viewModel as PersonRecommendsViewModel;
            }
        }

        public PersonRecommendsWindow()
        {
            InitializeComponent();
        }

        private void TopPersonRecommendsWindow_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void listViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListViewItem item = sender as ListViewItem;
            YieldRoiRecommend recommend = item.Content as YieldRoiRecommend;
            if (recommend != null)
            {
                ViewModel.Modify(recommend);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var headerClicked = e.OriginalSource as GridViewColumnHeader;
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

                    string header = "Person";
                    if (headerClicked.Column.DisplayMemberBinding != null)
                    {
                        header = (headerClicked.Column.DisplayMemberBinding as Binding).Path.Path;
                    }
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
