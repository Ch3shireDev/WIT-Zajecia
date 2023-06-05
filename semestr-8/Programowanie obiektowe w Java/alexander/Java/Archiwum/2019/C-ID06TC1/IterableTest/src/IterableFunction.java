
import java.util.Iterator;

class IterableFunction
{
   static Iterable<String> Arr(String... Tb)
   {
      return new Iterable<String>()
      {
         @Override public Iterator<String> iterator()
         {
            return new Iterator<String>()
            {
               private int index=0;
               @Override public boolean hasNext() { return index<Tb.length; }
               @Override public String next() { return Tb[index++]; }
            };
         }
      };
   }
}
