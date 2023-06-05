import java.util.Iterator;
import java.util.function.Consumer;

class BaseIterable implements Iterable<String>
{
   public static Iterable<String> ArrayFunc(String ... Tb) { return new BaseIterable(Tb); }
   private String[] Tb;
   private BaseIterable(String[] Tb) { this.Tb=Tb; }
   class BaseIterator implements Iterator<String>
   {
      private int index=0;
      @Override public boolean hasNext() { return index<Tb.length; }
      @Override public String next() { return Tb[index++]; }
   }
   @Override public Iterator<String> iterator() { return new BaseIterator(); }
}
