using SamochodyCiezaroweLibrary.Items;

namespace SamochodyCiezaroweAppWpf.Vehicles
{
    public class ItemEditorModel
    {
        public ItemEditorModel(Item item)
        {
            Item = new ItemBuilder().Build(item);
        }

        public Item Item { get; set; }

        public decimal Volume
        {
            get => GetItemVolume();
            set => SetItemVolume(value);
        }

        public decimal Width
        {
            get => GetItemWidth();
            set => SetItemWidth(value);
        }

        public decimal Length
        {
            get => GetItemLength();
            set => SetItemLength(value);
        }

        public decimal Height
        {
            get => GetItemHeight();
            set => SetItemHeight(value);
        }

        private decimal GetItemVolume()
        {
            if (Item is LiquidItem liquidItem) return liquidItem.Volume;
            return 0;
        }

        private void SetItemVolume(decimal volume)
        {
            if (Item is LiquidItem liquidItem) liquidItem.Volume = volume;
        }

        public decimal GetItemWidth()
        {
            if (Item is BoxItem boxItem) return boxItem.Width;
            return 0;
        }

        public decimal GetItemHeight()
        {
            if (Item is BoxItem boxItem) return boxItem.Height;
            return 0;
        }

        public decimal GetItemLength()
        {
            if (Item is BoxItem boxItem) return boxItem.Length;
            return 0;
        }

        public void SetItemWidth(decimal value)
        {
            if (Item is BoxItem boxItem) boxItem.Width = value;
        }

        public void SetItemLength(decimal value)
        {
            if (Item is BoxItem boxItem) boxItem.Length = value;
        }

        public void SetItemHeight(decimal value)
        {
            if (Item is BoxItem boxItem) boxItem.Height = value;
        }

        public bool IsBoxItem => Item is BoxItem;
        public bool IsContainerItem => Item is ContainerItem;
        public bool IsLiquidItem => Item is LiquidItem;

        public string ItemTypeDescription => new ItemProxy(Item).TypeDescription;
    }
}