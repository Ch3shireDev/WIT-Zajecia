using System.Collections.Generic;
using SamochodyCiezaroweLibrary.Items;

namespace SamochodyCiezaroweLibrary.Storages
{
    public abstract class Storage
    {
        public abstract string StorageDescription { get; }
        public List<Item> Items { get; set; } = new();
        public abstract bool IsSingle { get; }
    }
}