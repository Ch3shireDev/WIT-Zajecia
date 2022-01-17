namespace SamochodyCiezaroweLibrary.Vehicles
{
    public class TrailerCar : MotorizedVehicle, ITrailerable
    {
        public TrailerCar()
        {
        }

        public TrailerCar(MotorizedVehicle motorizedVehicle) : base(motorizedVehicle)
        {
        }

        public TrailerCar(Vehicle vehicle) : base(vehicle)
        {
        }

        public TrailerCar(TrailerCar trailerCar) : base(trailerCar)
        {
            TrailerId = trailerCar.TrailerId;
        }
        
        public override string TypeDescription => "Samochód ciężarowy";

        public Trailer Trailer { get; private set; }

        public void Hook(Trailer trailer)
        {
            TrailerId = trailer.Id;
        }

        public int TrailerId { get; set; }

        public void Unhook()
        {
            Trailer trailer = Trailer;
            Trailer = null;
        }
    }
}