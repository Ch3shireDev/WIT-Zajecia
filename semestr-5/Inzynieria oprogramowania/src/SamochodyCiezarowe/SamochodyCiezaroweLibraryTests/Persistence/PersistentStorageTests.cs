using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using SamochodyCiezaroweLibrary.Items;
using SamochodyCiezaroweLibrary.Persistence;
using SamochodyCiezaroweLibrary.Storages;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweLibraryTests.Persistence
{
    [TestClass]
    public class PersistentStorageTests
    {
        [TestMethod]
        public void LoadTest()
        {
            string json = @"{""Vehicles"": [
        {
            ""VehicleType"": 1,
            ""ParentId"": 0,
            ""Storage"": {
                ""StorageType"": 1,
                ""Items"": [{
                        ""ItemType"": 1,
                        ""Name"": ""Nowy towar"",
                        ""GrossMass"": 1.0,
                        ""Description"": ""Opis towaru. Tutaj podać rozwinięte informacje.""
                    }
                ]
            },
            ""Id"": 4,
            ""Name"": ""Nowy samochód"",
            ""VIN"": ""123456"",
            ""Year"": 2000
        }]}";

            PersistentData persistentData = JsonConvert.DeserializeObject<PersistentData>(json);
            Assert.IsNotNull(persistentData);

            Vehicle vehicle = persistentData.Vehicles.First();
            Assert.AreEqual(1, (int)vehicle.VehicleType);
            Storage storage = (vehicle as ILoadable)?.Storage;
            Assert.AreEqual(1, (int)storage.StorageType);
            Item item = storage.Items.First();
            Assert.AreEqual(1, item.ItemType);
        }
    }
}