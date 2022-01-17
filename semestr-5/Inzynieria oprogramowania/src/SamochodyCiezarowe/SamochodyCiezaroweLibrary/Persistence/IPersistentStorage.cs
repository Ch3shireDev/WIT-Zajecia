using System.IO;

namespace SamochodyCiezaroweLibrary.Persistence
{
    public interface IPersistentStorage
    {
        void Save(PersistentData data, StreamWriter writer);
        PersistentData Load(StreamReader reader);
    }
}