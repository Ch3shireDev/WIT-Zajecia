using System.Windows;
using System.Windows.Input;
using SamochodyCiezaroweLibrary;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweAppWpf.Vehicles.Editor
{
    /// <summary>
    ///     Interaction logic for VehicleEditor.xaml
    /// </summary>
    public partial class VehicleEditor : Window
    {
        public VehicleEditor(VehicleProxy vehicleProxy)
        {
            Model = new VehicleEditorModel(vehicleProxy);
            InitializeComponent();
            VehicleNameTextBox.Focus();
            VehicleNameTextBox.SelectAll();
            if (Model.Engine == null) EngineGrid.IsEnabled = false;
        }

        public VehicleEditorModel Model { get; set; }

        public Vehicle GetVehicle()
        {
            return Model.GetVehicle();
        }

        private void VehicleEditorSaveButton_Click(object sender, RoutedEventArgs e)
        {
            Save();
        }

        private void VehiclEditorCancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        public void Save()
        {
            DialogResult = true;
            Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return) Save();
        }
    }
}