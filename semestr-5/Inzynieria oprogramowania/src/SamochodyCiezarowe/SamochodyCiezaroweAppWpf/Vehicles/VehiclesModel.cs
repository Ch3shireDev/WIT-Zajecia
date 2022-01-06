using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using SamochodyCiezaroweAppWpf.Persistence;
using SamochodyCiezaroweLibrary;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweAppWpf.Vehicles
{
    public class VehiclesModel
    {
        public IPersistentStorage PersistentStorage = new PersistentStorage("data.json");

        private PersistentData PersistentData => new()
        {
            Vehicles = Vehicles.Select(v => v.Vehicle).ToList()
        };

        public ObservableCollection<VehicleProxy> Vehicles { get; set; } = new();

        public void Save()
        {
            PersistentStorage.Save(PersistentData);
        }

        public void Load()
        {
            try
            {
                PersistentData data = PersistentStorage.Load();
                Vehicles.Clear();
                foreach (Vehicle vehicle in data.Vehicles) Vehicles.Add(new VehicleProxy(vehicle));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public VehicleProxy AddNewVehicle()
        {
            int id = Vehicles.Count == 0 ? 1 : Vehicles.Select(v => v.Vehicle.Id).Max() + 1;
            VehicleProxy vehicle = new(new CargoSpaceCar { Id = id, Name = "Nowy samochód" });
            Vehicles.Add(vehicle);
            return vehicle;
        }

        public void RemoveVehicle(VehicleProxy vehicle)
        {
            Vehicles.Remove(vehicle);
        }

        public void RemoveVehicles(IEnumerable<VehicleProxy> vehicles)
        {
            foreach (VehicleProxy vehicle in vehicles) Vehicles.Remove(vehicle);
        }
    }
}