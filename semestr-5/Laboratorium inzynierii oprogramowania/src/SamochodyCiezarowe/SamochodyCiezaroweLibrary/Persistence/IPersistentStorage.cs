using System.IO;

namespace SamochodyCiezaroweLibrary.Persistence
{
    public interface IPersistentStorage<T>
    {
        void Save(T data, StreamWriter writer);
        T Load(StreamReader reader);
    }
}