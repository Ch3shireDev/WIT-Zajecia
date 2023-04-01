using Kalkulator.Models;
using Kalkulator.ViewModels;
using Kalkulator.Views;

namespace Kalkulator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var model = new MainModel();
            var viewModel = new MainViewModel(model);

            var view = new MainView();
            view.DataContext = viewModel;

            Application.Run(view);
        }
    }
}