using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using NotifyIcon = System.Windows.Forms.NotifyIcon;

namespace BetStrategy
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public static NotifyIcon Icon;

        protected override void OnStartup(StartupEventArgs e)
        {
            App.Icon = new NotifyIcon();
	    Icon.MouseUp +=Icon_MouseUp;
            Icon.Icon = new System.Drawing.Icon("Resources\\SysTray.ico");
            Icon.Visible = true;
            base.OnStartup(e);
        }

        private void Icon_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.MainWindow.Show();
            }
            else
            {
                ContextMenu menu = (ContextMenu)this.FindResource("NotifierContextMenu");
                menu.IsOpen = true;
            }
        }

        private void Menu_Close(object sender, RoutedEventArgs e)
        {
           var result = MessageBox.Show("确定退出?", "确认退出?", MessageBoxButton.YesNo);
           if (result == MessageBoxResult.Yes)
           {
               App.Current.Shutdown();
           }
           else
           {
                ContextMenu menu = (ContextMenu)this.FindResource("NotifierContextMenu");
                menu.IsOpen = false;
           }
        }
    }
}
