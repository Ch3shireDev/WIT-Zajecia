
import java.util.ArrayList;
import java.util.Collection;
import java.util.Iterator;
import java.util.function.Consumer;
import javax.swing.ListModel;
import javax.swing.event.ListDataEvent;
import javax.swing.event.ListDataListener;

public class SmartListModel<E> implements ListModel<E>,Iterable<E>
{
   private final ArrayList<E> list=new ArrayList<>();
   private final ArrayList<ListDataListener> listeners=new ArrayList<>();
   public void addElement(E e)
   {
      list.add(e);
      int pos=list.size()-1;
      call(ListDataEvent.CONTENTS_CHANGED,pos,pos);
   }
   @Override public int getSize() { return list.size(); }
   @Override public E getElementAt(int index) { return list.get(index); }
   @Override public void addListDataListener(ListDataListener l) { listeners.add(l); }
   @Override public void removeListDataListener(ListDataListener l) { listeners.remove(l); }

   private void call(int type,int index1,int index2)
   {
      listeners.forEach
      (
         (l) -> l.contentsChanged(new ListDataEvent(this,type,index1,index2))
      );
   }

   class SmartIterator<E> implements Iterator<E>
   {
      private int index=0;
      private final ArrayList<E> list;
      public SmartIterator(ArrayList<E> list) { this.list=list; }
      @Override public boolean hasNext() { return index<list.size(); }
      @Override public E next() { return list.get(index++); }
   }

   @Override public Iterator<E> iterator() { return new SmartIterator<E>(list); }
   @Override public void forEach(Consumer<? super E> action) { Iterable.super.forEach(action); }
   public boolean addAll(Collection<? extends E> c)
   {
      int pos=list.size();
      c.forEach((e) -> list.add(e));
      if(!c.isEmpty()) call(ListDataEvent.CONTENTS_CHANGED,pos,list.size()-1);
      return !c.isEmpty();
   }
}
