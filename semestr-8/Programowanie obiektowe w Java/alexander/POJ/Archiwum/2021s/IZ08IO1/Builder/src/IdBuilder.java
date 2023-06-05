
import java.util.HashSet;
import java.util.stream.Collectors;

public class IdBuilder
{
   //... where id in (1, 13, 666)
   //... where id in (null)
   //IdBuilder ib=new IdBuilder(); ib.setIfEmpty("").append(1).append(13).toString();
   private String Delimeter=", ";
   private String IfEmpty="null";
   private final HashSet<Long> list=new HashSet<>();

   public IdBuilder append(long id)
   {
      list.add(id);
      return this;
   }

   public IdBuilder clear()
   {
      list.clear();
      return this;
   }

   public IdBuilder setDelimeter(String Delimeter)
   {
      this.Delimeter=Delimeter;
      return this;
   }

   public IdBuilder setIfEmpty(String IfEmpty)
   {
      this.IfEmpty=IfEmpty;
      return this;
   }

   @Override public String toString()
   {
      if(list.isEmpty()) return IfEmpty;
      StringBuilder sb=new StringBuilder();
      boolean first=true;
      for(long id:list.stream().sorted().collect(Collectors.toList()))
      {
         if(first) first=false; else sb.append(Delimeter);
         sb.append(id);
      }
      return sb.toString();
   }
}
