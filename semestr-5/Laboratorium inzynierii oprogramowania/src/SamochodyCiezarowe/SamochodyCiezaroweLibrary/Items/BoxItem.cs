
namespace SamochodyCiezaroweLibrary.Items
{
    public class BoxItem : Item
    {
        public BoxItem(){}
        public BoxItem(BoxItem item) : base(item)
        {
            Width = item.Width;
            Height = item.Height;
            Length = item.Length;
        }

        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Length { get; set; }

        public override string GetDimensions()
        {
            return $"{Width} cm, {Height} cm, {Length} cm";
        }
        
    }
}