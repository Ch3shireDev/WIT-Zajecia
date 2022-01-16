using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SamochodyCiezaroweLibrary.Items;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweLibrary.Serialization
{
    public class ItemConverter : JsonConverter
    {
        private static readonly JsonSerializerSettings conversion =
            new() { ContractResolver = new BaseSpecifiedConcreteClassConverter() };

        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            return objectType != null && objectType == typeof(Item);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject json = JObject.Load(reader);
            string jsonData = json.ToString();
            switch ((ItemType)json["ItemType"].Value<int>())
            {
                case ItemType.BoxItem:
                    return JsonConvert.DeserializeObject<BoxItem>(jsonData, conversion);
                case ItemType.ContainerItem:
                    return JsonConvert.DeserializeObject<ContainerItem>(jsonData, conversion);
                case ItemType.LiquidItem:
                    return JsonConvert.DeserializeObject<LiquidItem>(jsonData, conversion); 
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