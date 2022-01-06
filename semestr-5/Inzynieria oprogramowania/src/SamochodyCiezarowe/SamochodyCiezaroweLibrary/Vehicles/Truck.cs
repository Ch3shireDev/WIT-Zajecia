namespace SamochodyCiezaroweLibrary.Vehicles
{
    public class Truck : Vehicle
    {
        public override VehicleType VehicleType => VehicleType.Truck;
        public override string TypeDescription => "Samochód ciężarowy";
    }
}