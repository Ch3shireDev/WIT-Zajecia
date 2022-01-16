using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SamochodyCiezaroweLibrary.Items;
using SamochodyCiezaroweLibrary.Storages;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweLibrary.Serialization
{
    public class BaseSpecifiedConcreteClassConverter : DefaultContractResolver
    {
        protected override JsonConverter ResolveContractConverter(Type objectType)
        {
            if (typeof(Vehicle).IsAssignableFrom(objectType) && !objectType.IsAbstract)
                return null; // pretend TableSortRuleConvert is not specified (thus avoiding a stack overflow)
            if (typeof(Storage).IsAssignableFrom(objectType) && !objectType.IsAbstract)
                return null;
            if (typeof(Item).IsAssignableFrom(objectType) && !objectType.IsAbstract)
                return null;
            return base.ResolveContractConverter(objectType);
        }
    }
}