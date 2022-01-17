using System;
using System.Collections;
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

        public ItemProxy SelectedItem => StorageModel.SelectedItem;

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void AddGoodsButton_Click(object sender, RoutedEventArgs e)
        {
            AddGoods();
        }

        private void AddGoods()
        {
            try
            {
                ItemEditor window = new(StorageModel.GetNewItem());
                bool? result = window.ShowDialog();
                if (result == true) StorageModel.AddItem(window.GetItem());
                Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void EditGoodsButton_Click(object sender, RoutedEventArgs e)
        {
            EditGoods();
        }

        private void EditGoods()
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

        public Storage GetStorage()
        {
            return StorageModel.GetStorage();
        }

        private void Refresh()
        {
            IEnumerable itemsSource = ItemsListView.ItemsSource;
            ItemsListView.ItemsSource = null;
            ItemsListView.ItemsSource = itemsSource;
        }

        private void AddItemContextMenu_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AddGoods();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void EditItemContextMenu_Click(object sender, RoutedEventArgs e)
        {
            EditGoods();
        }

        private void DeleteItemContextMenu_Click(object sender, RoutedEventArgs e)
        {
            DeleteGoods();
        }

        private void DeleteGoods()
        {
            if (SelectedItem == null) return;
            StorageModel.DeleteItem(SelectedItem);
            Refresh();
        }

        private void DeleteGoodsButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteGoods();
        }
    }
}