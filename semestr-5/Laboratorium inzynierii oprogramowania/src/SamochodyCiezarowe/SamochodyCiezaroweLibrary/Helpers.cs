using System.Collections.Generic;
using System.Linq;
using SamochodyCiezaroweLibrary.Storages;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweLibrary
{
    public static class Helpers
    {
        public static List<Vehicle> GetAvailableVehicles()
        {
            return new List<Vehicle>
            {
                new CargoSpaceCar(),
                new SemiTrailer(),
                new Trailer(),
                new TrailerCar(),
                new Truck()
            }.ToList();
        }

        public static List<Storage> GetAvailableStorages()
        {
            return new List<Storage>
            {
                new BoxStorage(),
                new ContainerStorage(),
                new TankStorage()
            };
        }
    }
}