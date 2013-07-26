using BetStrategy.Utils;
using BetStrategy.Views;
using System.Windows;
using System.Windows.Threading;
using BetStrategy.WorkServices;

namespace BetStrategy
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public App()
            : base()
        {
            ResolveSQLite3264.ResolveSQLiteDll();
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            WSQ.CSharp.Helper.DispatcherHelper.InitializeDispatcher();
            new TrayIcon().Init(this);
            new ApplicationInitializer().Init();
            base.OnStartup(e);
        }
    }
}
