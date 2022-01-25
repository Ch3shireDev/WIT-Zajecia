using SamochodyCiezaroweLibrary.Storages;

namespace SamochodyCiezaroweLibrary.Vehicles
{
    public class SemiTrailer : NonMotorizedVehicle, ILoadable
    {
        public SemiTrailer()
        {
        }

        public SemiTrailer(Vehicle vehicle) : base(vehicle)
        {
        }

        public SemiTrailer(SemiTrailer semiTrailer) : base(semiTrailer)
        {
            ParentId = semiTrailer.ParentId;
            Storage = new StorageBuilder().Build(semiTrailer.Storage);
        }

        public override string TypeDescription => "Naczepa";
        public int ParentId { get; set; }

        public Storage Storage { get; set; } = new BoxStorage();
    }
}