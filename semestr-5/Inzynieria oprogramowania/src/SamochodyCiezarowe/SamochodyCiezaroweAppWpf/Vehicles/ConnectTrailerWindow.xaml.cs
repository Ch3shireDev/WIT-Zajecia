using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweAppWpf.Vehicles
{
    /// <summary>
    ///     Interaction logic for ConnectTrailerWindow.xaml
    /// </summary>
    public partial class ConnectTrailerWindow : Window
    {
        public ConnectTrailerWindow(List<VehicleProxy> vehicles)
        {
            Model = new ConnectTrailerModel(vehicles);
            InitializeComponent();
            if (vehicles.FirstOrDefault()?.IsTrailer == true) Title = "Wybierz przyczepę";
            Title = "Wybierz naczepę";
        }

        public ConnectTrailerModel Model { get; set; }

        public Vehicle GetVehicle()
        {
            return Model.GetVehicle();
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (Model.GetVehicle() == null)
            {
                MessageBox.Show("Należy wybrać pojazd!");
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

    public class ConnectTrailerModel
    {
        public ConnectTrailerModel(List<VehicleProxy> vehicles)
        {
            Vehicles = vehicles;
        }

        public List<VehicleProxy> Vehicles { get; set; }
        public VehicleProxy SelectedVehicle { get; set; }

        public Vehicle GetVehicle()
        {
            return SelectedVehicle?.Vehicle;
        }
    }
}