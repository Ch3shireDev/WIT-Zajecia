using System;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using SamochodyCiezaroweAppWpf.Users;
using SamochodyCiezaroweAppWpf.Vehicles;
using SamochodyCiezaroweLibrary.Users;

namespace SamochodyCiezaroweAppWpf
{
    /// <summary>
    ///     Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Model.Load();
            InitializeComponent();
            UsernameTextbox.Focus();
        }

        public LoginModel Model { get; set; } = new();

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }

        private void Login()
        {
            try
            {
                Model.Password = Password.Password;
                UserProxy user = Model.GetUser();
                if (user.IsAdministrator) new UsersWindow().Show();
                if (user.IsOperator) new VehiclesWindow().Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) Login();
            if (e.Key == Key.Escape) Close();
        }
    }

    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        private UsersService Users => UsersSingleton.Instance.Service;

        public UserProxy GetUser()
        {
            return Users.Authorize(Username, Password);
        }

        public void Load()
        {
            try
            {
                new UsersService(Users.Users).Load();
            }
            catch
            {
                //
            }
        }
    }
}