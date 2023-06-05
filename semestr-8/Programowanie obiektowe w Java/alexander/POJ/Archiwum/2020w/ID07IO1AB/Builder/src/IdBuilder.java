
import java.util.ArrayList;

public class IdBuilder
{
   private final ArrayList<Long> list=new ArrayList<>();
   private String IfEmpty="null";
   private String Separator=", ";
   public IdBuilder clear() { list.clear(); return this; }
   public IdBuilder append(long id) { list.add(id); return this; }
   public IdBuilder setIfEmpty(String IfEmpty) { this.IfEmpty=IfEmpty; return this; }
   public IdBuilder setSeparator(String Separator) { this.Separator=Separator; return this; }

   @Override public String toString()
   {
      if(list.isEmpty()) return IfEmpty;
      list.sort((long a,long b) -> { return a<b; });
      StringBuilder sb=new StringBuilder();
      /*
      for(int i=0;i<list.size();++i)
      {
         if(i>0) sb.append(Separator);
         sb.append(list.get(i));
      }
      */
      for(int i=0;i<list.size();sb.append(list.get(i++))) if(i>0) sb.append(Separator);
      /*
      boolean first=true;
      for(long Id:list)
      {
         if(first) first=false;
         else sb.append(Separator);
         sb.append(Id);
      }
      */
      return sb.toString();
   }
}
