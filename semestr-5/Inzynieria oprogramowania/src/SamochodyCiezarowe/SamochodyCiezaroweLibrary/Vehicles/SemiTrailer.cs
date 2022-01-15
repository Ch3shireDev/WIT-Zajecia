using SamochodyCiezaroweLibrary.Items;

namespace SamochodyCiezaroweLibrary.Vehicles
{
    public class SemiTrailer : NonMotorizedVehicle, ILoadable
    {
        public SemiTrailer(){}
        public SemiTrailer(Vehicle vehicle):base(vehicle){}

        public SemiTrailer(SemiTrailer semiTrailer) : base(semiTrailer)
        {
            ParentId = semiTrailer.ParentId;
        }
        public override VehicleType VehicleType => VehicleType.SemiTrailer;
        public override string TypeDescription => "Naczepa";
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