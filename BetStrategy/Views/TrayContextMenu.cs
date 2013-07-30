using System.Windows;
using System.Windows.Controls;
using BetStrategy.Properties;

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
            var menu = new MenuItem() { Header = "退出" + Settings.Default.forumName };
            menu.Click += menu_Click;
            ContextMenu.Items.Add(menu);
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            app.Shutdown();
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
