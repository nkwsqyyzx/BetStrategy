using BetStrategy.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.ComponentModel;
using System.Collections.Generic;

namespace BetStrategy.Windows
{
    /// <summary>
    /// Interaction logic for YieldRoiWindow.xaml
    /// </summary>
    public partial class YieldRoiWindow : BaseWindow
    {
        private Dictionary<string, ListSortDirection> SortDict = new Dictionary<string, ListSortDirection>();
        private YieldRoiViewModel ViewModel
        {
            get
            {
                return _viewModel as YieldRoiViewModel;
            }
        }

        public YieldRoiWindow()
        {
            InitializeComponent();
        }
        private void Sort_Click(object sender, RoutedEventArgs e) { }

        private void GridViewColumnHeaderClickedHandler(object sender, RoutedEventArgs e)
        {
            if (!(e.OriginalSource is GridViewColumnHeader))
            {
                return;
            }
            var sortBy = ((e.OriginalSource as GridViewColumnHeader).Column.DisplayMemberBinding as Binding).Path.Path;
            var dir = ListSortDirection.Ascending;
            if (SortDict.ContainsKey(sortBy))
            {
                dir = SortDict[sortBy] == ListSortDirection.Ascending ? ListSortDirection.Descending : ListSortDirection.Ascending;
            }
            SortDict[sortBy] = dir;
            ViewModel.Sort(sortBy, dir);
        }
    }
}
