
import java.util.HashSet;

public class IdBuilder 
{
   private final HashSet<Long> lst=new HashSet<>();
   private String emptyValue,delimeter;
   public IdBuilder()
   {
      this("null",", ");
   }
   public IdBuilder(String delimeter)
   {
      this("null",delimeter);
   }
   public IdBuilder(String emptyValue,String delimeter)
   {
      this.emptyValue=emptyValue;
      this.delimeter=delimeter;
   }
   public String getEmptyValue() { return emptyValue; }
   public void setEmptyValue(String emptyValue) { this.emptyValue = emptyValue; }
   public String getDelimeter() { return delimeter; }
   public void setDelimeter(String delimeter) { this.delimeter = delimeter; }
   public void clear() { lst.clear(); }
   public void add(long value) { lst.add(value); }
   @Override public String toString() 
   {
      if(lst.size()<=0) return emptyValue;
      final StringBuilder sb=new StringBuilder();
      //for(long value:lst) sb.append(", ").append(value);
      lst.forEach((value) -> { sb.append(delimeter).append(value); } );
      return sb.toString().substring(delimeter.length());
   }   
}
