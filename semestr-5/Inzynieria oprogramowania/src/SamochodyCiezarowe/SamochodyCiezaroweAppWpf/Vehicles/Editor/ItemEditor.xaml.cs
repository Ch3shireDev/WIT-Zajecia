using System.Windows;
using SamochodyCiezaroweLibrary.Items;

namespace SamochodyCiezaroweAppWpf.Vehicles.Editor
{
    /// <summary>
    ///     Interaction logic for ItemEditor.xaml
    /// </summary>
    public partial class ItemEditor : Window
    {
        public ItemEditor(Item item)
        {
            Owner = Application.Current.MainWindow;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            ShowInTaskbar = false;
            Model = new ItemEditorModel(item);
            InitializeComponent();
        }

        public ItemEditorModel Model { get; set; }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        public Item GetItem()
        {
            return Model.Item;
        }
    }
}