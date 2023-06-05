
import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Iterator;
import javax.swing.ListModel;
import javax.swing.event.ListDataEvent;
import javax.swing.event.ListDataListener;

public class SmartListModel<E> implements ListModel<E>, Iterable<E>
{
   private final ArrayList<E> lst=new ArrayList<>();
   private final ArrayList<ListDataListener> listeners=new ArrayList<>();

   public void call(int type,int idx1,int idx2)
   {
      for(ListDataListener l:listeners)
      {
         l.contentsChanged(new ListDataEvent(this,type,idx1,idx2));
      }
   }

   public void addElement(E e)
   {
      lst.add(e);
      int idx=lst.size()-1;
      call(ListDataEvent.CONTENTS_CHANGED,idx,idx);
   }

   public void addAll(Iterable<E> it)
   {
      for(E e:it) lst.add(e);
      call(ListDataEvent.INTERVAL_ADDED,0,lst.size()-1);
   }

   @Override public int getSize() { return lst.size(); }
   @Override public E getElementAt(int index) { return lst.get(index); }
   @Override public Iterator<E> iterator() { return new SmartIterator<>(this); }

   @Override public void addListDataListener(ListDataListener l) { listeners.add(l); }
   @Override public void removeListDataListener(ListDataListener l) { listeners.remove(l); }

   class SmartIterator<E> implements Iterator<E>
   {
      private int index=0;
      private final SmartListModel<E> me;
      public SmartIterator(SmartListModel<E> me) { this.me=me; }
      @Override public boolean hasNext() { return index<me.getSize(); }
      @Override public E next() { return me.getElementAt(index++); }
   }
}
