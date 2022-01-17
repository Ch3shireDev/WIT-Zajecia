using System.Linq;
using SamochodyCiezaroweLibrary.Items;

namespace SamochodyCiezaroweLibrary.Storages
{
    public class TankStorage : Storage
    {
        public TankStorage()
        {
        }

        public TankStorage(TankStorage storage)
        {
            Items = storage.Items.Select(item => new LiquidItem(item as LiquidItem) as Item).ToList();
        }

        public override string StorageDescription => "Cysterna";
        public override bool IsSingle => true;
    }
}