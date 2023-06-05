
import java.util.ArrayList;

public class IdBuilder
{
   private final ArrayList<Long> list=new ArrayList<>();
   private String EmptyStr="null",SeparatorStr=", ";
   public IdBuilder clear() { list.clear(); return this; }
   public IdBuilder append(long Id) { list.add(Id); return this; }
   public IdBuilder setEmptyStr(String EmptyStr) { this.EmptyStr=EmptyStr; return this; }
   public IdBuilder setSeparatorStr(String SeparatorStr) { this.SeparatorStr=SeparatorStr; return this; }

   //select Name from emploee where Id in (1, 55, 73);
   //select Name from emploee where Id in (null);
   /*
   String result
   =
     new IdBuilder()
     .claer()
     .append(55)
     .append(73)
     .append(1)
     .setSeparatorStr(";")
     .toString()
   ;
   */

   @Override public String toString()
   {
      if(list.isEmpty()) return EmptyStr;
      StringBuilder sb=new  StringBuilder();
      /*
      for(int i=0;i<list.size();++i)
      {
         sb.append(list.get(i));
         if(i>0) sb.append(", ");
      }
      */
      for(int i=0;i<list.size();sb.append(list.get(i++))) if(i>0) sb.append(SeparatorStr);
      return sb.toString();
   }
}
