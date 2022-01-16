using System.Collections.Generic;
using Newtonsoft.Json;
using SamochodyCiezaroweLibrary.Items;
using SamochodyCiezaroweLibrary.Serialization;

namespace SamochodyCiezaroweLibrary.Storages
{
    [JsonConverter(typeof(StorageConverter))]
    public abstract class Storage
    {
        [JsonIgnore] public abstract string StorageDescription { get; }
        public List<Item> Items { get; set; } = new();
        public abstract StorageType StorageType { get; }
    }
}