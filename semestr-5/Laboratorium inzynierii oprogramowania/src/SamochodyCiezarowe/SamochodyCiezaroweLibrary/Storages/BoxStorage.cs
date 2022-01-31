using System.Linq;
using SamochodyCiezaroweLibrary.Items;

namespace SamochodyCiezaroweLibrary.Storages
{
    public class BoxStorage : Storage
    {
        public BoxStorage()
        {
        }

        public BoxStorage(BoxStorage storage)
        {
            Items = storage.Items.Select(item => new BoxItem(item as BoxItem) as Item).ToList();
        }

        public override string StorageDescription => "Przestrzeń skrzyniowa";
        public override bool IsSingle => false;
    }
}