using System.Windows;

namespace SamochodyCiezaroweAppWpf
{
    /// <summary>
    ///     Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginModel Model { get; set; } = new LoginModel();
        public LoginWindow()
        {
            InitializeComponent();
        }
    }

    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}