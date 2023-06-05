
import java.util.HashSet;
import java.util.stream.Collectors;

public class IdBuilder
{
   private final HashSet<Long> list=new HashSet<>();
   // ... where id in (3,7,11);
   public void add(long id) { list.add(id); }
   public void remove(long id) { list.remove(id); }
   public void clear() { list.clear(); }

   @Override public String toString()
   {
      StringBuilder sb=new StringBuilder();
      boolean first=true;
      for(long id:list.stream().sorted().collect(Collectors.toList()))
      {
         if(first) first=false; else sb.append(',');
         sb.append(id);
      }
      if(first) sb.append("null");
      return sb.toString();
   }
}
