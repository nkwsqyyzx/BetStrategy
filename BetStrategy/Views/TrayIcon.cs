using BetStrategy.Messages;
using BetStrategy.Properties;
using GalaSoft.MvvmLight.Messaging;

namespace BetStrategy.Views
{
    public class TrayIcon
    {
        private System.Windows.Forms.NotifyIcon Icon;
        private TrayContextMenu ContextMenu;
        private App app;

        public TrayIcon()
        {
            InitIcon();
            Messenger.Default.Register<BalloonMessage>(this, ShowBalloonMessage);
        }

        private void InitIcon()
        {
            Icon = new System.Windows.Forms.NotifyIcon();
            Icon.MouseUp += Icon_MouseUp;
            Icon.DoubleClick += Icon_DoubleClick;
            Icon.BalloonTipClicked += Icon_BalloonTipClicked;
            Icon.Icon = new System.Drawing.Icon("Resources\\SysTray.ico");
            Icon.Text = Settings.Default.forumName;
            Icon.Visible = true;
        }

        private void ShowBalloonMessage(BalloonMessage obj)
        {
            Icon.BalloonTipText = obj.Message;
            Icon.ShowBalloonTip(2);
        }

        public void Init(App app)
        {
            this.app = app;
            ContextMenu = new TrayContextMenu(app);
        }

        private void Icon_BalloonTipClicked(object sender, System.EventArgs e)
        {
            app.MainWindow.Activate();
            app.MainWindow.Show();
        }

        private void Icon_DoubleClick(object sender, System.EventArgs e)
        {
            app.MainWindow.Activate();
            app.MainWindow.Show();
        }

        private void Icon_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                app.MainWindow.Activate();
                app.MainWindow.Show();
            }
            else
            {
                ContextMenu.Open();
            }
        }
    }
}
