using SamochodyCiezaroweLibrary.Serialization;

namespace SamochodyCiezaroweLibrary.Storages
{
    public class TankStorage : Storage
    {
        public TankStorage()
        {
        }

        public TankStorage(TankStorage storage)
        {
        }

        public override string StorageDescription => "Cysterna";
        public override StorageType StorageType => StorageType.TankStorage;
    }
}