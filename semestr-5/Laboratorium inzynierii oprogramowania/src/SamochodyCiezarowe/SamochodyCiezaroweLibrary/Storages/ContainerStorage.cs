using System.Linq;
using SamochodyCiezaroweLibrary.Items;

namespace SamochodyCiezaroweLibrary.Storages
{
    public class ContainerStorage : Storage
    {
        public ContainerStorage()
        {
        }

        public ContainerStorage(ContainerStorage storage)
        {
            Items = storage.Items.Select(item => new ContainerItem(item as ContainerItem) as Item).ToList();
        }

        public override string StorageDescription => "Przestrzeń kontenerowa";
        public override bool IsSingle => true;
    }
}