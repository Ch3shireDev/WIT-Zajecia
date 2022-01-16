using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace SamochodyCiezaroweLibrary.Persistence
{
    public class PersistentStorage : IPersistentStorage
    {
        public PersistentStorage(string filename)
        {
            Filename = filename;
        }

        private string Filename { get; }

        public void Save(PersistentData data)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data);
                File.WriteAllText(Filename, json, Encoding.UTF8);
            }
            catch (Exception e)
            {
                throw new Exception($"Nie można zapisać danych w {Filename}. Informacja o błędzie: {e.Message}");
            }
        }

        public PersistentData Load()
        {
            try
            {
                string json = File.ReadAllText(Filename);
                return JsonConvert.DeserializeObject<PersistentData>(json);
            }
            catch (Exception e)
            {
                throw new Exception($"Nie można odczytać danych z {Filename}. Informacja o błędzie: {e.Message}", e);
            }
        }
    }
}