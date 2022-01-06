using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using SamochodyCiezaroweAppWpf.Vehicles.Editor;
using SamochodyCiezaroweLibrary;

namespace SamochodyCiezaroweAppWpf.Vehicles
{
    /// <summary>
    ///     Interaction logic for VehiclesView.xaml
    /// </summary>
    public partial class VehiclesView : Window
    {
        public VehiclesView()
        {
            Model.Load();
            InitializeComponent();
            VehiclesList.SelectionChanged += (s, e) => VehiclesList.ScrollIntoView(VehiclesList.SelectedItem);
        }

        public VehiclesModel Model { get; set; } = new();

        private void AddVehicleButton_Click(object sender, RoutedEventArgs e)
        {
            AddVehicle();
        }

        private void AddVehicleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AddVehicle();
        }

        private void AddVehicle()
        {
            VehicleProxy vehicle = Model.AddNewVehicle();
            VehiclesList.SelectedValue = vehicle;
            VehicleEditor editor = new(vehicle);
            bool? result = editor.ShowDialog();
            if (result == false) Model.RemoveVehicle(vehicle);
            else vehicle.Vehicle = editor.GetVehicle();
            RefreshVehiclesList();
            Model.Save();
        }

        private void RefreshVehiclesList()
        {
            IEnumerable itemsSource = VehiclesList.ItemsSource;
            VehiclesList.ItemsSource = null;
            VehiclesList.ItemsSource = itemsSource;
        }

        private void DeleteVehicleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<VehicleProxy> vehicles = VehiclesList.SelectedItems.Cast<VehicleProxy>();
            Model.RemoveVehicles(vehicles.ToList());
        }

        private void EditVehicleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            EditVehicle();
        }

        private void EditVehicle()
        {
            if (VehiclesList.SelectedValue is not VehicleProxy vehicle) return;
            VehicleEditor editor = new(vehicle);
            bool? result = editor.ShowDialog();
            if (result == true) vehicle.Vehicle = editor.GetVehicle();
            Model.Save();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.N && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control) AddVehicle();
        }
    }
}