using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweLibrary.Serialization
{
    public class BaseConverter : JsonConverter
    {
        private static readonly JsonSerializerSettings conversion =
            new() { ContractResolver = new BaseSpecifiedConcreteClassConverter() };

        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            return objectType != null && objectType == typeof(Vehicle);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject json = JObject.Load(reader);
            string jsonData = json.ToString();
            switch ((VehicleType)json["VehicleType"].Value<int>())
            {
                case VehicleType.Car:
                    return JsonConvert.DeserializeObject<CargoSpaceCar>(jsonData, conversion);
                case VehicleType.Trailer:
                    return JsonConvert.DeserializeObject<Trailer>(jsonData, conversion);
                case VehicleType.SemiTrailer:
                    return JsonConvert.DeserializeObject<SemiTrailer>(jsonData, conversion);
                case VehicleType.TrailerCar:
                    return JsonConvert.DeserializeObject<TrailerCar>(jsonData, conversion);
                case VehicleType.Truck:
                    return JsonConvert.DeserializeObject<Truck>(jsonData, conversion);
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