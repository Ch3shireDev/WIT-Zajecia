using System;
using SamochodyCiezaroweLibrary.Items;
using SamochodyCiezaroweLibrary.Storages;

namespace SamochodyCiezaroweLibrary.Vehicles
{
    public class CargoSpaceCar : MotorizedVehicle, ILoadable
    {
        public CargoSpaceCar()
        {
        }

        public CargoSpaceCar(Vehicle vehicle) : base(vehicle)
        {
        }

        public CargoSpaceCar(MotorizedVehicle vehicle) : base(vehicle)
        {
        }

        public CargoSpaceCar(CargoSpaceCar vehicle) : base(vehicle)
        {
            Storage = new StorageBuilder().Build(vehicle.Storage);
        }
        
        public override string TypeDescription => "Samochód z przestrzenią ładunkową";
        public Storage Storage { get; set; } = new BoxStorage();
    }

    public class StorageBuilder
    {
        public Storage Build(Storage storage)
        {
            if (storage is BoxStorage boxStorage) return new BoxStorage(boxStorage);
            if (storage is ContainerStorage containerStorage) return new ContainerStorage(containerStorage);
            if (storage is TankStorage tankStorage) return new TankStorage(tankStorage);
            throw new NotImplementedException($"Nieznany typ przestrzeni ładunkowej: {storage.GetType()}");
        }
    }
}