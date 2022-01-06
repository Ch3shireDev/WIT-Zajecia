using System.Collections.Generic;
using System.Linq;
using SamochodyCiezaroweLibrary;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweAppWpf.Vehicles.Editor
{
    public class VehicleEditorModel
    {
        public VehicleEditorModel(VehicleProxy vehicleProxy)
        {
            Vehicle = new CargoSpaceCar(vehicleProxy.Vehicle);
            Engine = Vehicle.Engine;
            SelectedVehicleType = VehicleTypes.FirstOrDefault(x => x.GetType() == Vehicle.GetType());
        }

        public Vehicle Vehicle { get; set; }
        public Engine Engine { get; set; }
        public Vehicle SelectedVehicleType { get; set; }

        public List<Vehicle> VehicleTypes { get; } = Helpers.GetAvailableVehicles();

        public Vehicle GetVehicle()
        {
            return Vehicle;
        }
    }
}