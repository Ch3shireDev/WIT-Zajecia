using SamochodyCiezaroweLibrary.Storages;

namespace SamochodyCiezaroweLibrary.Vehicles
{
    public class Trailer : NonMotorizedVehicle, ILoadable
    {
        public Trailer()
        {
        }

        public Trailer(Vehicle vehicle) : base(vehicle)
        {
        }

        public Trailer(Trailer trailer) : base(trailer)
        {
            ParentId = trailer.ParentId;
            Storage = new StorageBuilder().Build(trailer.Storage);
        }

        public override string TypeDescription => "Przyczepa";
        public int ParentId { get; set; }

        public Storage Storage { get; set; } = new BoxStorage();
    }
}