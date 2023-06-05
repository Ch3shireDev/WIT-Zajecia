
import java.util.ArrayList;
import java.util.Collection;
import java.util.Iterator;
import java.util.function.Consumer;
import javax.swing.ListModel;
import javax.swing.event.ListDataEvent;
import javax.swing.event.ListDataListener;

public class SmartListModel<E> implements ListModel<E>, Iterable<E>
{
   private final ArrayList<E> list=new ArrayList<>();
   private final ArrayList<ListDataListener> listeners=new ArrayList<>();
   @Override public int getSize() { return list.size(); }
   @Override public E getElementAt(int index) { return list.get(index); }
   @Override public void addListDataListener(ListDataListener l) { listeners.add(l); }
   @Override public void removeListDataListener(ListDataListener l) { listeners.remove(l); }
   private void callAdded(int type,int idx1,int idx2)
   {
      for(ListDataListener l:listeners)
      {
         l.intervalAdded(new ListDataEvent(this,type,idx1,idx2));
      }
   }
   private void addElement(E e)
   {
      int pos=list.size();
      list.add(e);
      callAdded(ListDataEvent.INTERVAL_ADDED,pos,pos);
   }
   public boolean addAll(Collection<? extends E> c)
   {
      int first=list.size();
      c.forEach((e) -> list.add(e));
      int last=list.size()-1;
      callAdded(ListDataEvent.INTERVAL_ADDED,first,last);
      return last>=first;
   }

   class SmartIterator<E> implements Iterator<E>
   {
      private final ArrayList<E> list;
      private int index=0;
      public SmartIterator(ArrayList<E> list) { this.list=list; }
      @Override public boolean hasNext() { return index<list.size(); }
      @Override public E next() { return list.get(index++); }
   }
   @Override public Iterator<E> iterator() { return new SmartIterator<>(list); }
   @Override public void forEach(Consumer<? super E> action) { Iterable.super.forEach(action); }
}
