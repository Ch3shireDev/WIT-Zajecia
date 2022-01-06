namespace SamochodyCiezaroweLibrary.Vehicles
{
    public class Trailer : Vehicle
    {
        public override VehicleType VehicleType => VehicleType.Trailer;
        public override string TypeDescription => "Przyczepa";
    }
}