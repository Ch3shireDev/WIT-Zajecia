using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            List<Vehicle> poco  = new List<Vehicle>
                {
                    new Trailer
                    {
                        Storage = new ContainerStorage
                        {
                            Items = new List<Item>
                            {
                                new ContainerItem()
                            }
                        }
                    }
                
            };

            PersistentStorage<List<Vehicle>> persistentStorage = new();

            using MemoryStream memoryStreamIn = new();
            using StreamWriter streamwriter = new(memoryStreamIn);
            persistentStorage.Save(poco, streamwriter);
            streamwriter.Close();

            using MemoryStream memorystreamout = new(memoryStreamIn.GetBuffer());
            using StreamReader streamreader = new(memorystreamout);
            var persistentData = persistentStorage.Load(streamreader);
            streamreader.Close();

            Assert.IsNotNull(persistentData);

            Vehicle vehicle = persistentData.First();
            Assert.IsTrue(vehicle is  Trailer);
            Storage storage = (vehicle as ILoadable)?.Storage;
            Assert.IsTrue(storage is ContainerStorage);
            Item item = storage.Items.First();
            Assert.IsTrue(item is ContainerItem);
        }
    }
}