namespace SamochodyCiezaroweLibrary.Vehicles
{
    public abstract class MotorizedVehicle : Vehicle
    {
        protected MotorizedVehicle(){}

        protected MotorizedVehicle(Vehicle vehicle) : base(vehicle)
        {

        }

        protected MotorizedVehicle(MotorizedVehicle vehicle) : base(vehicle)
        {
            Engine = vehicle.Engine;
        }
        public Engine Engine { get; set; } = new();
    }
}