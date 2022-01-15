namespace SamochodyCiezaroweLibrary.Vehicles
{
    public class Truck : MotorizedVehicle, ISemiTrailerable
    {
        public Truck()
        {
        }

        public Truck(MotorizedVehicle motorizedVehicle) : base(motorizedVehicle)
        {
        }

        public Truck(Vehicle vehicle) : base(vehicle)
        {
        }

        public Truck(Truck truck) : base(truck)
        {
            SemiTrailerId = truck.SemiTrailerId;
        }

        public override VehicleType VehicleType => VehicleType.Truck;
        public override string TypeDescription => "Samochód ciężarowy";

        public int SemiTrailerId { set; get; }
    }
}