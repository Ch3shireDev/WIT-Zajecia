using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweLibrary
{
    public class VehicleProxy
    {
        public VehicleProxy(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }
        public Vehicle Vehicle { get; set; }
        public string TypeDescription { get; set; }
    }
}