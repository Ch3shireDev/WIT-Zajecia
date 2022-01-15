using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SamochodyCiezaroweLibrary.Items;

namespace SamochodyCiezaroweAppWpf.Vehicles.Editor
{
    public class ItemsModel
    {
        public ObservableCollection<Item> Items = new ObservableCollection<Item>();

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
    
    /// <summary>
    /// Interaction logic for ItemsEditor.xaml
    /// </summary>
    public partial class ItemsEditor : Window
    {
        public ItemsModel ItemsModel = new ItemsModel();

        public ItemsEditor()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void AddGoodsButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new ItemEditor();
            var result = window.ShowDialog();
        }

        private void EditGoodsButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new ItemEditor();
            var result = window.ShowDialog();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
