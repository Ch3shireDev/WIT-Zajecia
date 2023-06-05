using MandelbrotApp.Models;
using MandelbrotApp.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MandelbrotApp.ViewModels;

namespace MandelbrotApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var model = new MainModel();
            var viewModel = new MainViewModel(model);
            var view = new MainWindow
            {
                DataContext = viewModel
            };

            view.Show();

        }
    }
}
