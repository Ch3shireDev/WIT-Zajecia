namespace SamochodyCiezaroweLibrary.Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle()
        {
        }

        protected Vehicle(Vehicle vehicle)
        {
            Id = vehicle.Id;
            Name = vehicle.Name;
            VIN = vehicle.VIN;
            Year = vehicle.Year;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; } = 2000;
        public abstract string TypeDescription { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}