using System.Windows;
using WpfApplication.UI.View;
using WpfApplication.UI.ViewModel;

namespace WpfApplication.UI
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainVindow = new MainWindow(new MainViewModel());
            mainVindow.Show();
        }
    }
}
