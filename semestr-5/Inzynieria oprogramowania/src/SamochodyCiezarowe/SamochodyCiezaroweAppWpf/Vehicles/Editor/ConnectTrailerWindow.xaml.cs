using System.Collections.Generic;
using System.Windows;
using SamochodyCiezaroweLibrary;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweAppWpf.Vehicles.Editor
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
        }

        public ConnectTrailerModel Model { get; set; }
        public Vehicle GetVehicle()
        {
            return Model.GetVehicle();
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
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
            DialogResult = false;
            Close();
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