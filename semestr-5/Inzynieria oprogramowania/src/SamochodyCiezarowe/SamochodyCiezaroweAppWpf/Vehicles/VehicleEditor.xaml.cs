using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweAppWpf.Vehicles
{
    /// <summary>
    ///     Interaction logic for VehicleEditor.xaml
    /// </summary>
    public partial class VehicleEditor : Window
    {
        public VehicleEditor(VehicleProxy vehicleProxy)
        {
            ShowInTaskbar = false;
            Model = new VehicleEditorModel(vehicleProxy);
            InitializeComponent();
            SetVehicleType();
            VehicleNameTextBox.Focus();
            VehicleNameTextBox.SelectAll();
        }

        public VehicleEditorModel Model { get; set; }

        public Vehicle Vehicle => Model.Vehicle;


        private void VehicleEditorSaveButton_Click(object sender, RoutedEventArgs e)
        {
            Save();
        }

        private void VehiclEditorCancelButton_Click(object sender, RoutedEventArgs e)
        {
            Cancel();
        }

        private void Cancel()
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
            if (e.Key == Key.Escape) Cancel();
        }

        private void VehicleTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetVehicleType();
        }

        private void SetVehicleType()
        {
            if (!IsInitialized) return;
            Model.SetVehicleType();
            Refresh();
        }

        private bool GetEngineIsEnabled()
        {
            return Model.SelectedVehicleType is MotorizedVehicle;
        }

        private Visibility GetSelectTrailerVisibility()
        {
            if (Model.IsTrailerable && !Model.IsConnected) return Visibility.Visible;
            return Visibility.Collapsed;
        }

        private Visibility GetDisconnectTrailerVisibility()
        {
            if (Model.IsTrailerable && Model.IsConnected) return Visibility.Visible;
            return Visibility.Collapsed;
        }

        private Visibility GetSelectSemiTrailerVisibility()
        {
            if (Model.IsSemiTrailerable && !Model.IsConnected) return Visibility.Visible;
            return Visibility.Collapsed;
        }

        private Visibility GetDisconnectSemiTrailerVisibility()
        {
            if (Model.IsSemiTrailerable && Model.IsConnected) return Visibility.Visible;
            return Visibility.Collapsed;
        }

        private bool GetStorageSpaceIsEnabled()
        {
            return Model.SelectedVehicleType is ILoadable;
        }

        private bool GetStorageSpaceButtonIsEnabled()
        {
            return Model.SelectedVehicleType is ILoadable || Model.IsConnected;
        }

        private void Refresh()
        {
            EngineGrid.IsEnabled = GetEngineIsEnabled();
            TrailerGrid.Visibility = GetSelectTrailerVisibility();
            DisconnectTrailer.Visibility = GetDisconnectTrailerVisibility();
            SemiTrailerGrid.Visibility = GetSelectSemiTrailerVisibility();
            DisconnectSemiTrailerGrid.Visibility = GetDisconnectSemiTrailerVisibility();
            StorageSpaceButton.IsEnabled = GetStorageSpaceButtonIsEnabled();
            Refresh(VehicleNameTextBox);
            Refresh(VehicleVINTextBox);
            Refresh(VehicleYearTextBox);
            Refresh(EngineNameTextBox);
            Refresh(EngineCapacityTextBox);
            Refresh(EnginePowerTextBox);
            SelectedTrailerNameText3.Text = Model.SelectedTrailerName;
            SelectedTrailerNameText4.Text = Model.SelectedTrailerName;
            StorageSpaceLabel.IsEnabled = GetStorageSpaceIsEnabled();
            StorageSpaceComboBox.IsEnabled = GetStorageSpaceIsEnabled();
        }

        private void Refresh(FrameworkElement textBox)
        {
            textBox.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();
        }

        private void SetTrailerButton_Click(object sender, RoutedEventArgs ev)
        {
            List<VehicleProxy> trailers = Model.GetTrailersList();
            ConnectTrailerWindow dialog = new(trailers);
            bool? result = dialog.ShowDialog();
            if (result != true) return;
            Trailer selectedTrailer = dialog.Model.GetVehicle() as Trailer;
            if (selectedTrailer == null) return;
            try
            {
                Model.Connect(selectedTrailer);
                Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void SetSemiTrailerButton_Click(object sender, RoutedEventArgs ev)
        {
            SetTrailer();
        }

        private void SetTrailer()
        {
            var semiTrailers = Model.GetSemiTrailersList();
            if (semiTrailers.Count == 0)
            {
                MessageBox.Show("Nie istnieją żadne naczepy w systemie. Należy utworzyć przynajmniej jedną naczepę.");
                return;
            }

            ConnectTrailerWindow dialog = new(semiTrailers);
            bool? result = dialog.ShowDialog();
            if (result != true) return;
            SemiTrailer selectedSemiTrailer = dialog.Model.GetVehicle() as SemiTrailer;
            try
            {
                Model.Connect(selectedSemiTrailer);
                Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void DisconnectTrailerButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Model.Disconnect();
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisconnectSemiTrailerButton_Click(object sender, RoutedEventArgs e)
        {
            DisconnectSemiTrailer();
        }

        private void DisconnectSemiTrailer()
        {
            try
            {
                Model.Disconnect();
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StorageSpaceButton_Click(object sender, RoutedEventArgs e)
        {
            ILoadable loadable = null;
            if (Vehicle is ILoadable) loadable = Vehicle as ILoadable;
            else if (Vehicle is ITrailerable trailerable)
                loadable = new VehiclesService().GetVehicle(trailerable.TrailerId) as ILoadable;
            else if (Vehicle is ISemiTrailerable semiTrailerable)
                loadable = new VehiclesService().GetVehicle(semiTrailerable.SemiTrailerId) as ILoadable;
            if (loadable == null) return;
            StorageEditor window = new(loadable);
            bool? result = window.ShowDialog();
            if (result != true) return;
            loadable.Storage = window.GetStorage();
        }

        private void StorageSpaceComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.SetStorage();
        }
    }
}