using SamochodyApp.Models;
using SamochodyApp.ViewModels;
using SamochodyApp.Views;

namespace SamochodyApp;

internal static class Program
{
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        var model = new MainModel();
        var viewModel = new MainViewModel(model);
        var view = new MainView();
        view.DataContext = viewModel;
        view.LoadData();
        
        Application.Run(view);
    }
}