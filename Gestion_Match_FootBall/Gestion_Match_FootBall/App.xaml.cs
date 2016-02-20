using System.Windows;
using Gestion_Match_FootBall.ViewModel;

namespace Gestion_Match_FootBall
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // To tell how to start My Application
        protected override void OnStartup(StartupEventArgs e)
        { 
            base.OnStartup(e);
            MainWindow window = new MainWindow();
            var viewModel = new MainWindow_ViewMode();
            window.DataContext = viewModel;
            window.Show();
        }
    }
}
