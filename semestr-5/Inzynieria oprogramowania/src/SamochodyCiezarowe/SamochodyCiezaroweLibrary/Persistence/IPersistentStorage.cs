namespace SamochodyCiezaroweLibrary.Persistence
{
    public interface IPersistentStorage
    {
        void Save(PersistentData data);
        PersistentData Load();
    }
}