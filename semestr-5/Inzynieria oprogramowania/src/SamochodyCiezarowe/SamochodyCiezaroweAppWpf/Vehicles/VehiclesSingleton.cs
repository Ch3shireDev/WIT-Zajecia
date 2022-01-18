using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SamochodyCiezaroweLibrary.Users;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweAppWpf.Vehicles
{

    public class DataSingleton
    {
        public static DataSingleton Instance { get; } = new DataSingleton();

        public ObservableCollection<VehicleProxy> Vehicles { get; } = new();
        public ObservableCollection<UserProxy> Users { get; } = new();

    }

    public class VehiclesService
    {
        public ObservableCollection<VehicleProxy> Vehicles => DataSingleton.Instance.Vehicles;
        
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