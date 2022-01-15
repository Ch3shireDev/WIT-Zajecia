using System;

namespace SamochodyCiezaroweLibrary.Vehicles
{
    public class VehicleBuilder
    {
        public Vehicle BuildFromType(Vehicle selectedVehicleType, Vehicle vehicle)
        {
            Type selectedType = selectedVehicleType.GetType();

            if (selectedType == vehicle.GetType())
            {
                return Build(vehicle);
            }
            
            if (selectedType == typeof(CargoSpaceCar))
            {
                if (vehicle is MotorizedVehicle motorizedVehicle) return new CargoSpaceCar(motorizedVehicle);
                return new CargoSpaceCar(vehicle);
            }

            if (selectedType == typeof(Truck))
            {
                if (vehicle is MotorizedVehicle motorizedVehicle) return new Truck(motorizedVehicle);
                return new Truck(vehicle);
            }

            if (selectedType == typeof(TrailerCar))
            {
                if (vehicle is MotorizedVehicle motorizedVehicle) return new TrailerCar(motorizedVehicle);
                return new TrailerCar(vehicle);
            }

            if (selectedType == typeof(Trailer))
            {
                return new Trailer(vehicle);
            }

            if (selectedType == typeof(SemiTrailer))
            {
                return new SemiTrailer(vehicle);
            }

            throw new NotImplementedException($"Otrzymano niepoprawny typ pojazdu: {selectedType}.");
        }

        public Vehicle Build(Vehicle vehicle)
        {
            if (vehicle is CargoSpaceCar cargoSpaceCar) return new CargoSpaceCar(cargoSpaceCar);
            if (vehicle is Truck truck) return new Truck(truck);
            if (vehicle is TrailerCar trailerCar) return new TrailerCar(trailerCar);
            if (vehicle is Trailer trailer) return new Trailer(trailer);
            if (vehicle is SemiTrailer semitrailer) return new SemiTrailer(semitrailer);
            throw new Exception($"Nieznany typ pojazdu: {vehicle.GetType()}");
        }
    }
}