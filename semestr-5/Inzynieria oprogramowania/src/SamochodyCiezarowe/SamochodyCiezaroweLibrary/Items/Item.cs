
namespace SamochodyCiezaroweLibrary.Items
{
    public abstract class Item
    {
        protected Item(){}
        protected Item(Item item)
        {
            Name = item.Name;
            GrossMass = item.GrossMass;
        }

        public string Name { get; set; } = "Nowy towar";
        public decimal GrossMass { get; set; } = 1;
        public abstract string GetDimensions();
        public string Description { get; set; } = "Opis towaru. Tutaj podać rozwinięte informacje.";
        
    }
}