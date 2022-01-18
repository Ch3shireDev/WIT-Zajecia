using System;
using System.Collections;
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

        void Save()
        {
            Model.Save();
        }
        private void AddOperatorButton_Click(object sender, RoutedEventArgs e)
        {
            UserEditorWindow window = new UserEditorWindow(UserEditorMode.CreateOperator);
            if (window.ShowDialog() != true) return;
            Refresh();
            Save();
        }

        private void AddAdministratorButton_Click(object sender, RoutedEventArgs e)
        {
            UserEditorWindow window = new UserEditorWindow(UserEditorMode.CreateAdministrator);
            if (window.ShowDialog() != true) return;
            Refresh();
            Save();
        }

        private void EditUserButton_Click(object sender, RoutedEventArgs e)
        {
            UserEditorWindow window = new UserEditorWindow(UserEditorMode.Edit, Model.SelectedUser);
            if (window.ShowDialog() != true) return;
            Refresh();
            Save();
        }

        private void DeleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Model.DeleteUser();
                Refresh();
                Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message);
            }
        }

        private void Refresh()
        {
            IEnumerable itemsSource = UsersListView.ItemsSource;
            UsersListView.ItemsSource = null;
            UsersListView.ItemsSource = itemsSource;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow window = new LoginWindow();
            window.Show();
            Close();
        }
    }
}