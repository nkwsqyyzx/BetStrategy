using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using NotifyIcon = System.Windows.Forms.NotifyIcon;
using DataBase;

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
            DB db = new DB();
            db.Test();
            App.Icon = new NotifyIcon();
	    Icon.MouseUp +=Icon_MouseUp;
	    Icon.DoubleClick += Icon_DoubleClick;
	    Icon.BalloonTipClicked += Icon_BalloonTipClicked;
            Icon.Icon = new System.Drawing.Icon("Resources\\SysTray.ico");
            Icon.Visible = true;
            WSQ.CSharp.Helper.DispatcherHelper.InitializeDispatcher();
            base.OnStartup(e);
        }

        private void Icon_BalloonTipClicked(object sender, System.EventArgs e)
        {
            this.MainWindow.Activate();
            this.MainWindow.Show();
        }

        private void Icon_DoubleClick(object sender, System.EventArgs e)
        {
            this.MainWindow.Activate();
            this.MainWindow.Show();
        }

        private void Icon_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.MainWindow.Activate();
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
