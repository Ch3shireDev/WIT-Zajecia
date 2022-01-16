using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SamochodyCiezaroweLibrary;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweAppWpf.Vehicles
{
    public class VehiclesSingleton
    {
        public ObservableCollection<VehicleProxy> Vehicles = new();

        private VehiclesSingleton()
        {
        }

        public static VehiclesSingleton Instance { get; } = new();

        public VehicleProxy GetVehicleProxy(int id)
        {
            return Vehicles.FirstOrDefault(proxy => proxy.Vehicle.Id == id);
        }

        public string GetNameById(int id)
        {
            return GetVehicleProxy(id)?.Vehicle.Name ?? "-";
        }

        public List<VehicleProxy> GetTrailersList()
        {
            return Vehicles.Where(vehicle => vehicle.IsTrailer && !vehicle.IsConnected).ToList();
        }

        public Vehicle GetVehicle(int id)
        {
            return GetVehicleProxy(id)?.Vehicle;
        }
    }
}