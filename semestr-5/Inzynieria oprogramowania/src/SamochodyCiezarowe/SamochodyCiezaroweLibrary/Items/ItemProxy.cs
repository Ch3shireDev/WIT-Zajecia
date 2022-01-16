namespace SamochodyCiezaroweLibrary.Items
{
    public class ItemProxy
    {
        public int Id { get; set; }
        public ItemProxy(Item item)
        {
            Item = item;
        }

        public Item Item { get; set; }

        public string Name => Item.Name;
        public string GrossMass => $"{Item.GrossMass} kg";
        public string Dimensions => GetDimensions();
        public string TypeDescription => GetTypeDescription();

        string GetTypeDescription()
        {
            if (Item.GetType() == typeof(BoxItem)) return "Towar skrzyniowy";
            if (Item.GetType() == typeof(ContainerItem)) return "Towar kontenerowy";
            if (Item.GetType() == typeof(LiquidItem)) return "Towar płynny";
            return "-";
        }
        private string GetDimensions()
        {
            return Item.GetDimensions();
        }
    }
}