using System.Windows;
using OperacjeMacierzoweApp.Models;
using OperacjeMacierzoweApp.ViewModels;

namespace OperacjeMacierzoweApp;

/// <summary>
///     Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        var model = new MainModel();
        var viewModel = new MainViewModel(model);

        var mainWindow = new MainWindow
        {
            DataContext = viewModel
        };

        mainWindow.Show();

        base.OnStartup(e);
    }
}