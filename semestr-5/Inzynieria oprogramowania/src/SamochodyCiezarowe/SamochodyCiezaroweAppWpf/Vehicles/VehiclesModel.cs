using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using SamochodyCiezaroweLibrary.Persistence;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweAppWpf.Vehicles
{
    public class VehiclesModel
    {
        //private readonly string filename = "data.json";
        public IPersistentStorage<List<Vehicle>> PersistentStorage = new PersistentStorage<List<Vehicle>>();

        private PersistentData PersistentData => new()
        {
            Vehicles = Vehicles.Select(v => v.Vehicle).ToList()
        };

        public ObservableCollection<VehicleProxy> Vehicles => new VehiclesService().Vehicles;

        private List<Vehicle> vehicles => Vehicles.Select(v => v.Vehicle).ToList();

        public void Save(string filename)
        {
            using FileStream filestream = File.Create(filename);
            using StreamWriter stream = new(filestream);
            PersistentStorage.Save(vehicles, stream);
        }

        public void Load(string filename, bool verbose = true)
        {
            try
            {
                using FileStream filestream = File.Open(filename, FileMode.Open, FileAccess.Read);
                using StreamReader stream = new(filestream);
                List<Vehicle> data = PersistentStorage.Load(stream);

                Vehicles.Clear();
                foreach (Vehicle vehicle in data) Vehicles.Add(new VehicleProxy(vehicle));
            }
            catch (Exception e)
            {
                if (verbose) MessageBox.Show(e.Message);
            }

            RefreshConnections();
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

        public void RefreshConnections()
        {
            Dictionary<int, VehicleProxy> vehiclesSet = Vehicles.ToDictionary(vp => vp.Vehicle.Id, vp => vp);

            foreach (VehicleProxy vehicle in Vehicles)
            {
                int parentId = vehicle.ParentId;

                if (parentId > 0)
                {
                    if (!vehiclesSet.ContainsKey(parentId)) vehicle.ParentId = 0;
                    VehicleProxy parent = vehiclesSet[parentId];
                    if (parent.ChildId != vehicle.Id) vehicle.ParentId = 0;
                }

                int childId = vehicle.ChildId;

                if (childId > 0)
                {
                    if (!vehiclesSet.ContainsKey(childId)) vehicle.ChildId = 0;
                    VehicleProxy child = vehiclesSet[childId];
                    if (child.ParentId != vehicle.Id) vehicle.ChildId = 0;
                }
            }
        }
    }
}