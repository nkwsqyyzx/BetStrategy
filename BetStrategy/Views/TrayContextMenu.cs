using System.Windows;
using System.Windows.Controls;

namespace BetStrategy.Views
{
    internal class TrayContextMenu
    {
        private ContextMenu ContextMenu;
        private App app;
        public TrayContextMenu(App app)
        {
            this.app = app;
            InitContextMenu();
        }

        private void InitContextMenu()
        {
            ContextMenu = new ContextMenu();
            ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.MousePoint;
            var menu = new MenuItem() { Header = "Close Application" };
            menu.Click += menu_Click;
            ContextMenu.Items.Add(menu);
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            var result = System.Windows.MessageBox.Show("退出后不再会收到新通知", "确认退出?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                app.Shutdown();
            }
            else
            {
                Close();
            }
        }

        internal void Open()
        {
            ContextMenu.IsOpen = true;
        }

        internal void Close()
        {
            ContextMenu.IsOpen = false;
        }
    }
}
