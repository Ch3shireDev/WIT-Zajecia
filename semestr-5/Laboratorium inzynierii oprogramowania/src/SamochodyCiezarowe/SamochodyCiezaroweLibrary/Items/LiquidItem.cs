
namespace SamochodyCiezaroweLibrary.Items
{
    public class LiquidItem : Item
    {
        public LiquidItem(){}
        public LiquidItem(LiquidItem item) : base(item)
        {
            Volume = item.Volume;
        }

        public decimal Volume { get; set; }

        public override string GetDimensions()
        {
            return $"{Volume} dm3";
        }
        
    }
}