using System;
using SamochodyCiezaroweLibrary.Storages;

namespace SamochodyCiezaroweLibrary.Items
{
    public class ItemBuilder
    {
        public Item Build(Item item)
        {
            if (item is BoxItem boxItem) return new BoxItem(boxItem);
            if (item is ContainerItem containerItem) return new ContainerItem(containerItem);
            if (item is LiquidItem liquidItem) return new LiquidItem(liquidItem);
            throw new NotImplementedException($"Nieznany typ przedmiotu: {item.GetType()}");
        }

        public Item Build(Storage vehicleStorage)
        {
            if (vehicleStorage is BoxStorage) return new BoxItem();
            if (vehicleStorage is ContainerStorage) return new ContainerItem();
            if (vehicleStorage is TankStorage) return new LiquidItem();
            throw new NotImplementedException($"Nieznany typ przestrzeni ładunkowej: {vehicleStorage.GetType()}");
        }
    }
}