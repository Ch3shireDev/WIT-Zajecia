
import java.util.HashSet;

public class IdBuilder 
{
   private final HashSet<Long> lst;
   public IdBuilder()
   {
      lst=new HashSet<>();
   }
   public void clear()
   {
      lst.clear();
   }
   public void add(long idvalue)
   {
      lst.add(idvalue);
   }
   @Override public String toString() 
   {
      if(lst.size()<=0) return "null";
      final StringBuilder sb=new StringBuilder();
      for(Long idvalue:lst) sb.append(",").append(idvalue);
      return sb.toString().substring(1);
   }
}
