using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;
using SamochodyCiezaroweAppWpf.Vehicles.Editor;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweAppWpf.Vehicles
{
    /// <summary>
    ///     Interaction logic for VehiclesView.xaml
    /// </summary>
    public partial class VehiclesView : Window
    {
        private readonly string filename = "data.json";

        public VehiclesView()
        {
            Model.Load(filename);
            InitializeComponent();
            VehiclesList.SelectionChanged += (s, e) => VehiclesList.ScrollIntoView(VehiclesList.SelectedItem);
            Title = $"Samochody Ciężarowe v{Assembly.GetEntryAssembly()?.GetName().Version}";
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
            else vehicle.Vehicle = editor.Vehicle;
            RefreshVehiclesList();
            Model.Save(filename);
        }

        private void RefreshVehiclesList()
        {
            IEnumerable itemsSource = VehiclesList.ItemsSource;
            VehiclesList.ItemsSource = null;
            VehiclesList.ItemsSource = itemsSource;
            Model.RefreshConnections();
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
            if (result == true) vehicle.Vehicle = editor.Vehicle;
            //Model.Save();
            RefreshVehiclesList();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.N && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control) AddVehicle();
        }

        private void LoadMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void SaveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Save();
        }

        private void Save()
        {
            SaveFileDialog dialog = new()
            {
                AddExtension = true,
                DefaultExt = "json",
                FileName = $"{DateTime.Now:s}.json"
            };
            if (dialog.ShowDialog(this) == true) Model.Save(dialog.FileName);
        }

        private void Load()
        {
            OpenFileDialog dialog = new()
            {
                AddExtension = true,
                CheckFileExists = true
            };
            if (dialog.ShowDialog(this) == true) Model.Load(dialog.FileName);
            RefreshVehiclesList();
        }

        private void LogoutMenuItem_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialog = MessageBox.Show(this, "Czy zapisać pracę?", Title, MessageBoxButton.YesNoCancel);
            if (dialog == MessageBoxResult.Cancel) return;
            if (dialog == MessageBoxResult.Yes) Save();
            Environment.Exit(0);
        }
    }
}