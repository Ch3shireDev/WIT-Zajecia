using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SamochodyCiezaroweLibrary.Storages;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweLibrary.Serialization
{
    public class StorageConverter : JsonConverter
    {
        private static readonly JsonSerializerSettings conversion =
            new() { ContractResolver = new BaseSpecifiedConcreteClassConverter() };

        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            return objectType != null && objectType == typeof(Storage);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject json = JObject.Load(reader);
            string jsonData = json.ToString();
            switch ((StorageType)json["StorageType"].Value<int>())
            {
                case StorageType.BoxStorage:
                    return JsonConvert.DeserializeObject<BoxStorage>(jsonData, conversion);
                case StorageType.ContainerStorage:
                    return JsonConvert.DeserializeObject<ContainerStorage>(jsonData, conversion);
                case StorageType.TankStorage:
                    return JsonConvert.DeserializeObject<TankStorage>(jsonData, conversion); 
                default:
                    throw new Exception();
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException(); // won't be called because CanWrite returns false
        }
    }
}