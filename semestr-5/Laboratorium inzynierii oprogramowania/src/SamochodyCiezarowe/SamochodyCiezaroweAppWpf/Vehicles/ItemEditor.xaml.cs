using System.Windows;
using System.Windows.Input;
using SamochodyCiezaroweLibrary.Items;

namespace SamochodyCiezaroweAppWpf.Vehicles
{
    /// <summary>
    ///     Interaction logic for ItemEditor.xaml
    /// </summary>
    public partial class ItemEditor : Window
    {
        public ItemEditor(Item item)
        {
            ShowInTaskbar = false;
            Model = new ItemEditorModel(item);
            InitializeComponent();
            if (Model.IsBoxItem) Title = "Edycja towaru skrzyniowego";
            if (Model.IsContainerItem) Title = "Edycja towaru kontenerowego";
            if (Model.IsLiquidItem) Title = "Edycja towaru płynnego";
        }

        public ItemEditorModel Model { get; set; }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Save();
        }

        private void Save()
        {
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

        public Item GetItem()
        {
            return Model.Item;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) Save();
            if (e.Key == Key.Escape) Cancel();
        }
    }
}