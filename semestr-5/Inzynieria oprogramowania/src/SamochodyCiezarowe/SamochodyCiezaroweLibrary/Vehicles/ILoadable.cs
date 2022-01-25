using SamochodyCiezaroweLibrary.Storages;

namespace SamochodyCiezaroweLibrary.Vehicles
{
    public interface ILoadable
    {
        public Storage Storage { get; set; }
    }
}