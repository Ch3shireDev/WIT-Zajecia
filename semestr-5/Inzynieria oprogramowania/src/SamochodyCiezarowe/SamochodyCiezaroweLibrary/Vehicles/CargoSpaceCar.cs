namespace SamochodyCiezaroweLibrary.Vehicles
{
    public class CargoSpaceCar : Vehicle
    {
        public CargoSpaceCar(){}
        public CargoSpaceCar(Vehicle vehicle) : base(vehicle)
        {

        }

        public override VehicleType VehicleType => VehicleType.Car;
        public override string TypeDescription => "Samochód z przestrzenią ładunkową";
    }
}