using System.Windows;
using SamochodyCiezaroweLibrary.Items;
using SamochodyCiezaroweLibrary.Storages;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweAppWpf.Vehicles.Editor
{
    /// <summary>
    ///     Interaction logic for StorageEditor.xaml
    /// </summary>
    public partial class StorageEditor : Window
    {
        public StorageEditor(ILoadable loadableVehicle)
        {
            Owner = Application.Current.MainWindow;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            ShowInTaskbar = false;
            StorageModel = new StorageModel(loadableVehicle);
            InitializeComponent();
        }

        public StorageModel StorageModel { get; set; }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void AddGoodsButton_Click(object sender, RoutedEventArgs e)
        {
            ItemEditor window = new(StorageModel.GetNewItem());
            bool? result = window.ShowDialog();
            if (result == true) StorageModel.AddItem(window.GetItem());
            Refresh();
        }

        private void EditGoodsButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedItem == null) return;
            ItemEditor window = new(SelectedItem.Item);
            bool? result = window.ShowDialog();
            if (result == true) SelectedItem.Item = window.GetItem();
            Refresh();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        public ItemProxy SelectedItem => StorageModel.SelectedItem;

        public Storage GetStorage()
        {
            return StorageModel.GetStorage();
        }

        void Refresh()
        {
            var itemsSource = ItemsListView.ItemsSource;
            ItemsListView.ItemsSource = null;
            ItemsListView.ItemsSource = itemsSource;
        }
    }
}