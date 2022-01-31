using System;
using System.Windows;
using System.Windows.Input;
using SamochodyCiezaroweLibrary.Users;

namespace SamochodyCiezaroweAppWpf.Users
{
    /// <summary>
    ///     Interaction logic for UserEditorWindow.xaml
    /// </summary>
    public partial class UserEditorWindow : Window
    {
        public UserEditorWindow(UserEditorMode mode, UserProxy user = null)
        {
            Model = new UserEditorModel(mode, user);
            InitializeComponent();
            UsernameTextBox.Text = user?.Name ?? "";
            UsernameTextBox.IsEnabled = mode != UserEditorMode.Edit;
            if (mode != UserEditorMode.Edit) UsernameTextBox.Focus();
            else PasswordBoxA.Focus();

            switch (mode)
            {
                case UserEditorMode.CreateOperator:
                    Title = "Nowy Operator";
                    break;
                case UserEditorMode.CreateAdministrator:
                    Title = "Nowy Administrator";
                    break;
                case UserEditorMode.Edit:
                    Title = "Edycja Użytkownika";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }

        public UserEditorModel Model { get; set; }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Save();
        }

        private void Save()
        {
            string passwordA = PasswordBoxA.Password;
            string passwordB = PasswordBoxB.Password;
            Model.Username = UsernameTextBox.Text;

            try
            {
                Model.Save(passwordA, passwordB);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
                return;
            }

            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Cancel();
        }

        private void Cancel()
        {
            DialogResult = false;
            Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) Save();
            if (e.Key == Key.Escape) Cancel();
        }
    }
}