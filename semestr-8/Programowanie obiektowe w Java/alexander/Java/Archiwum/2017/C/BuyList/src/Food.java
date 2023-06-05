public class Food 
{
   private String Name;
   private long Count,Price;

   public Food(String Name, long Count, long Price) 
   {
      this.Name = Name;
      this.Count = Count;
      this.Price = Price;
   }

   public String getName() { return Name; }
   public void setName(String Name) { this.Name = Name; }
   public long getCount() { return Count; }
   public void setCount(int Count) { this.Count = Count; }
   public long getPrice() { return Price; }
   public void setPrice(int Price) { this.Price = Price; }
   public long getValue() { return Math.round(0.001 * Count * Price); }

   @Override public String toString()
   {
      return String.format
      (
         "%s: %.3f * %.2f = %.2f", 
         Name, 0.001 * Count, 0.01 * Price, 0.01 * getValue()
      );
   }
}
