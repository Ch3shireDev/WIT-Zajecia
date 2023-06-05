
import java.util.HashSet;

public class IdBuilder
{
   private final HashSet<Long> data=new HashSet<>();
   /// .... where Id in (3,7,9)
   public void add(long id) { data.add(id); }
   public void remove(long id) { data.remove(id); }
   public void clear() { data.clear(); }

   @Override public String toString()
   {
      StringBuilder sb=new StringBuilder();
      boolean first=true;
      //data.stream().forEach((id)->sb.append(id));
      if(data.size()>0)
      {
         for(long id:data)
         {
            if(first) first=false; else sb.append(',');
            sb.append(id);
         }
      }
      else sb.append("null");
      return sb.toString();
   }

}
