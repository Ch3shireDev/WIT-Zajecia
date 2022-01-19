using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweAppWpf.Vehicles
{
    public class VehiclesService
    {
        public ObservableCollection<VehicleProxy> Vehicles => VehiclesSingleton.Instance.Vehicles;

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

        public List<VehicleProxy> GetSemiTrailersList()
        {
            return Vehicles.Where(vehicle => vehicle.IsSemiTrailer).ToList();
        }
    }
}