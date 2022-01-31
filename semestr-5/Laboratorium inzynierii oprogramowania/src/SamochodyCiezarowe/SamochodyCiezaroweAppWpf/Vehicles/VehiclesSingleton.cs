using System.Collections.ObjectModel;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweAppWpf.Vehicles
{
    public class VehiclesSingleton
    {
        public static VehiclesSingleton Instance { get; } = new();

        public ObservableCollection<VehicleProxy> Vehicles { get; } = new();
    }
}