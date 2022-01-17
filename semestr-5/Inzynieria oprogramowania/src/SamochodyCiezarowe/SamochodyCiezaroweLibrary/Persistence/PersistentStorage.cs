using System;
using System.IO;
using Newtonsoft.Json;

namespace SamochodyCiezaroweLibrary.Persistence
{
    public class PersistentStorage : IPersistentStorage
    {
        public void Save(PersistentData data, StreamWriter writer)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
                writer.Write(json);
            }
            catch (Exception e)
            {
                throw new Exception($"Nie można zapisać danych. Informacja o błędzie: {e.Message}", e);
            }
        }

        public PersistentData Load(StreamReader reader)
        {
            try
            {
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<PersistentData>(json, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
            }
            catch (Exception e)
            {
                throw new Exception($"Nie można odczytać danych. Informacja o błędzie: {e.Message}", e);
            }
        }
    }
}