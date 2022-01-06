using Newtonsoft.Json;
using SamochodyCiezaroweLibrary.Serialization;
using SamochodyCiezaroweLibrary.Storages;

namespace SamochodyCiezaroweLibrary.Vehicles
{
    [JsonConverter(typeof(BaseConverter))]
    public abstract class Vehicle
    {
        protected Vehicle()
        {
        }

        protected Vehicle(Vehicle vehicle)
        {
            Id = vehicle.Id;
            Name = vehicle.Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; } = 2000;
        public Engine Engine { get; set; }
        public Storage Storage { get; set; }
        public abstract VehicleType VehicleType { get; }
        [JsonIgnore]
        public abstract string TypeDescription { get; }
    }
}