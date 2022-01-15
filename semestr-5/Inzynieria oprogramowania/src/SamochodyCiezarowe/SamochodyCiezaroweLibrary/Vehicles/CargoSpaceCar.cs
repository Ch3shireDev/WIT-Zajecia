using SamochodyCiezaroweLibrary.Items;

namespace SamochodyCiezaroweLibrary.Vehicles
{
    public class CargoSpaceCar : MotorizedVehicle, ILoadable
    {
        public CargoSpaceCar(){}
        public CargoSpaceCar(Vehicle vehicle) : base(vehicle)
        {

        }
        public CargoSpaceCar(MotorizedVehicle vehicle) : base(vehicle)
        {

        }

        public CargoSpaceCar(CargoSpaceCar vehicle) : base(vehicle)
        {

        }

        public override VehicleType VehicleType => VehicleType.Car;
        public override string TypeDescription => "Samochód z przestrzenią ładunkową";
        public void Load(Item item)
        {
            throw new System.NotImplementedException();
        }

        public void Unload()
        {
            throw new System.NotImplementedException();
        }
    }
}