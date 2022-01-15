using SamochodyCiezaroweLibrary.Items;

namespace SamochodyCiezaroweLibrary.Vehicles
{
    public class Trailer : NonMotorizedVehicle, ILoadable
    {
        public Trailer(){}
        public Trailer(Vehicle vehicle):base(vehicle){}

        public Trailer(Trailer trailer) : base(trailer)
        {
            ParentId = trailer.ParentId;
        }
        public override VehicleType VehicleType => VehicleType.Trailer;
        public override string TypeDescription => "Przyczepa";
        public int ParentId { get; set; }

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