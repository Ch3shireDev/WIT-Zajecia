using SamochodyCiezaroweLibrary.Serialization;

namespace SamochodyCiezaroweLibrary.Storages
{
    public class ContainerStorage : Storage
    {
        public ContainerStorage()
        {
        }

        public ContainerStorage(ContainerStorage storage)
        {
        }

        public override string StorageDescription => "Przestrzeń kontenerowa";
        public override StorageType StorageType => StorageType.ContainerStorage;
    }
}