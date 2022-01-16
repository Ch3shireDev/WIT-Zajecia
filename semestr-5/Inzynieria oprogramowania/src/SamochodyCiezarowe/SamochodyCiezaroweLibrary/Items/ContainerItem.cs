using SamochodyCiezaroweLibrary.Serialization;

namespace SamochodyCiezaroweLibrary.Items
{
    public class ContainerItem : Item
    {
        public ContainerItem(){}
        public ContainerItem(ContainerItem item) : base(item)
        {
        }

        public override string GetDimensions()
        {
            return "-";
        }

        public override ItemType ItemType => ItemType.ContainerItem;
    }
}