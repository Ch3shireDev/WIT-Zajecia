using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SamochodyCiezaroweLibrary;

namespace SamochodyCiezaroweAppWpf.Vehicles
{
    public class VehiclesSingleton
    {
        public ObservableCollection<VehicleProxy> Vehicles = new();

        private VehiclesSingleton()
        {
        }

        public static VehiclesSingleton Instance { get; } = new();

        public VehicleProxy GetVehicleProxyById(int id)
        {
            return Vehicles.FirstOrDefault(proxy => proxy.Vehicle.Id == id);
        }

        public string GetNameById(int id)
        {
            return GetVehicleProxyById(id)?.Vehicle.Name ?? "-";
        }

        public List<VehicleProxy> GetTrailersList()
        {
            return Vehicles.Where(vehicle => vehicle.IsTrailer && !vehicle.IsConnected).ToList();
        }
    }
}