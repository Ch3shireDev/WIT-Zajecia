public class Food 
{
   private String Name;
   private long Count, Price;

   public Food(String Name, double Count, double Price) 
   {
      this.Name = Name;
      setCountUseDouble(Count);
      setPriceUseDouble(Price);
   }

   public String getName() { return Name; }
   public void setName(String Name) { this.Name = Name; }
   public long getCount() { return Count; }
   public void setCount(long Count) { this.Count = Count; }
   public long getPrice() { return Price; }
   public void setPrice(long Price) { this.Price = Price; } 
   public long getValue() { return Math.round(0.001*Count*Price); }
   public String getCountAsString() { return toDoubleStr(3, Count); }
   public String getPriceAsString() { return toDoubleStr(2, Price); }
   public String getValueAsString() { return toDoubleStr(2, getValue()); }
   public void setCountUseDouble(double Count) { this.Count = fromDouble(3, Count); }
   public void setPriceUseDouble(double Price) { this.Price = fromDouble(2, Price);} 

   public static long fromDouble(int signs,double value)
   {
      return Math.round(Math.pow(10, signs) * value);
   }
   
   public static double toDouble(int signs,long value)
   {
      return Math.pow(10, -signs) * value;
   }
   
   public static String toDoubleStr(int signs,long value)
   {
      String fmt=String.format("%%.%df",signs);
      return String.format(fmt,toDouble(signs,value));
   }
   
   @Override public String toString() {
      return 
         Name+" "+
         getCountAsString()+" * "+
         getPriceAsString()+" = "+
         getValueAsString()
      ;
   }   
}
