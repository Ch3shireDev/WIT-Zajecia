using SamochodyCiezaroweLibrary.Items;

namespace SamochodyCiezaroweLibrary.Vehicles
{
    public interface ILoadable
    {
        void Load(Item item);
        void Unload();
    }
}