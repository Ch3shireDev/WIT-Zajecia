public class Product 
{
   private String name;
   private String unit;
   private double count;
   public Product(String name,String unit,double count)
   {
      this.name=name;
      this.unit=unit;
      this.count=count;
   }

   public String getName() { return name; }
   public String getUnit() { return unit; }
   public double getCount() { return count; }
   
   interface GetField { public Object get(Product p); }
   
   private static GetField[] fld=new GetField[]
   {
      new GetField() { public Object get(Product p) { return p.getName(); } },
      new GetField() { public Object get(Product p) { return p.getUnit(); } },
      new GetField() { public Object get(Product p) { return new Double(p.getCount()); } }
   };
   
   Object getFieldByCol(int col)
   {
      return fld[col].get(this);
   }
}
