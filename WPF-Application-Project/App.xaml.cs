using System.Windows;
using WPF_Application_Project.ViewModel;

namespace WPF_Application_Project
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var app = new View.MainWindow();
            var context = new MainWindowViewModel();
            app.DataContext = context;
            app.Show();
        }
    }
}
