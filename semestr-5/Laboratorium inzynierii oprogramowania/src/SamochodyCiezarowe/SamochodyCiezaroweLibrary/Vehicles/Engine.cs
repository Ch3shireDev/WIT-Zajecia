namespace SamochodyCiezaroweLibrary.Vehicles
{
    public class Engine
    {
        public Engine()
        {
        }

        public Engine(Engine engine)
        {
            Name = engine.Name;
            Capacity = engine.Capacity;
            Power = engine.Power;
        }

        public string Name { get; set; } = "Silnik spalinowy";
        public int Capacity { get; set; } = 5;
        public int Power { get; set; } = 200;
    }
}