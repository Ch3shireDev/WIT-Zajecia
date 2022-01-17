using System.Windows;

namespace SamochodyCiezaroweAppWpf.Users
{
    /// <summary>
    ///     Interaction logic for UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        public UsersWindow()
        {
            InitializeComponent();
        }

        public UsersModel Model { get; set; } = new();
    }

    public class UsersModel
    {
    }
}