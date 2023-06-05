
import java.util.Iterator;
import javax.swing.DefaultListModel;

public class IterableListModel<Item> extends DefaultListModel<Item> implements Iterable<Item>
{
   @Override public Iterator<Item> iterator() 
   {
      return new Iterator<Item>()
      {
         private int index=0;
         @Override public boolean hasNext() { return index<size(); }
         @Override public Item next() { return get(index++); }         
      };
   }   
}
