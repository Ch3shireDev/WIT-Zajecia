using System.Collections.ObjectModel;
using System.Linq;
using SamochodyCiezaroweLibrary.Items;
using SamochodyCiezaroweLibrary.Storages;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweAppWpf.Vehicles.Editor
{
    public class StorageModel
    {
        public StorageModel(ILoadable vehicle)
        {
            Vehicle = vehicle;
            var list = vehicle.Storage.Items.Select(item => new ItemProxy(item));
            Items = new ObservableCollection<ItemProxy>(list);
        }

        public ObservableCollection<ItemProxy> Items { get; set; }

        private ILoadable Vehicle { get; }
        public ItemProxy SelectedItem { get; set; }

        public void AddItem(Item item)
        {
            Items.Add(new ItemProxy(item));
            int index = 1;
            foreach (ItemProxy itemProxy in Items) itemProxy.Id = index++;
        }

        public Item GetNewItem()
        {
            return new ItemBuilder().Build(Vehicle.Storage);
        }

        public Storage GetStorage()
        {
            Storage storage = new StorageBuilder().Build(Vehicle.Storage);
            storage.Items = Items.Select(ip => ip.Item).ToList();
            return storage;
        }
    }
}