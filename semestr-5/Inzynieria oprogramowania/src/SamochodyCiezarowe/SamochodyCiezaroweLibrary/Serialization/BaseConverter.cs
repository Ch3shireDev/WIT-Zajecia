using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweLibrary.Serialization
{
    public class BaseConverter : JsonConverter
    {
        private static readonly JsonSerializerSettings SpecifiedSubclassConversion =
            new() { ContractResolver = new BaseSpecifiedConcreteClassConverter() };

        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            return objectType != null && objectType == typeof(Vehicle);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            switch ((VehicleType)jo["VehicleType"].Value<int>())
            {
                case VehicleType.Car:
                    return JsonConvert.DeserializeObject<CargoSpaceCar>(jo.ToString(), SpecifiedSubclassConversion);
                case VehicleType.Trailer:
                    return JsonConvert.DeserializeObject<Trailer>(jo.ToString(), SpecifiedSubclassConversion);
                default:
                    throw new Exception();
            }

            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException(); // won't be called because CanWrite returns false
        }
    }
}