using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweAppWpf.Vehicles
{
    /// <summary>
    ///     Interaction logic for VehiclesWindow.xaml
    /// </summary>
    public partial class VehiclesWindow : Window
    {
        private readonly string savefile = "data.json";

        public VehiclesWindow()
        {
            Model.Load(savefile, false);
            InitializeComponent();
            VehiclesList.SelectionChanged += (s, e) => VehiclesList.ScrollIntoView(VehiclesList.SelectedItem);
            Title = $"Samochody Ciężarowe v{Version}";
        }

        private string Version => Assembly.GetEntryAssembly()?.GetName().Version?.ToString() ?? "1.0";

        public VehiclesModel Model { get; set; } = new();

        private void AddVehicleButton_Click(object sender, RoutedEventArgs e)
        {
            AddVehicle();
        }

        private void AddVehicleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AddVehicle();
        }

        private void AddVehicleMenuItemDockPanel_Click(object sender, RoutedEventArgs e)
        {
            AddVehicle();
        }

        private void AddVehicle()
        {
            try
            {
                VehicleProxy vehicle = Model.AddNewVehicle();
                VehiclesList.SelectedValue = vehicle;
                VehicleEditor editor = new(vehicle);
                bool? result = editor.ShowDialog();
                if (result == false) Model.RemoveVehicle(vehicle);
                else vehicle.Vehicle = editor.Vehicle;
                RefreshVehiclesList();
                Model.Save(savefile);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void EditVehicleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            EditVehicle();
        }

        private void EditVehicleMenuItemDockPanel_Click(object sender, RoutedEventArgs e)
        {
            EditVehicle();
        }

        private void EditVehicle()
        {
            if (VehiclesList.SelectedValue is not VehicleProxy vehicle) return;
            VehicleEditor editor = new(vehicle);
            if (editor.ShowDialog() == true) vehicle.Vehicle = editor.Vehicle;
            Model.Save(savefile);
            RefreshVehiclesList();
        }

        private void DeleteVehicleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            DeleteVehicle();
        }

        private void DeleteVehicleMenuItemDockPanel_Click(object sender, RoutedEventArgs e)
        {
            DeleteVehicle();
        }

        private void DeleteVehicle()
        {
            IEnumerable<VehicleProxy> vehicles = VehiclesList.SelectedItems.Cast<VehicleProxy>();
            Model.RemoveVehicles(vehicles.ToList());
        }

        private void RefreshVehiclesList()
        {
            IEnumerable itemsSource = VehiclesList.ItemsSource;
            VehiclesList.ItemsSource = null;
            VehiclesList.ItemsSource = itemsSource;
            Model.RefreshConnections();
        }

        private void LoadMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Load();
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
                FileName = $"{DateTime.Now:yyyy-MM-ddTHH-mm-ss}.json",
                Filter = "Pliki json (*.json)|Wszystkie pliki (*.*)"
            };
            if (dialog.ShowDialog(this) == true) Model.Save(dialog.FileName);
            Model.Save(savefile);
        }

        private void LogoutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Model.Save(savefile);
            LoginWindow window = new();
            window.Show();
            Close();
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialog = MessageBox.Show(this, "Czy zapisać pracę?", Title, MessageBoxButton.YesNoCancel);
            if (dialog == MessageBoxResult.Cancel) return;
            if (dialog == MessageBoxResult.Yes) Save();
            Model.Save(savefile);
            Environment.Exit(0);
        }
    }
}