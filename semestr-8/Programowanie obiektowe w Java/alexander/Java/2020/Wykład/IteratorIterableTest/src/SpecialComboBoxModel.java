
import java.util.ArrayList;
import java.util.Collection;
import java.util.Iterator;
import java.util.List;
import javax.swing.AbstractListModel;
import javax.swing.MutableComboBoxModel;

public class SpecialComboBoxModel<E> extends AbstractListModel<E> implements MutableComboBoxModel<E>, Collection<E>
{
   private List<E> list;
   private E selected=null;

   public SpecialComboBoxModel() { this.list=new ArrayList<E>(); }
   public SpecialComboBoxModel(ArrayList<E> list) { this.list=list; }
   public boolean addAll(Collection<? extends E> c)
   {
      list.addAll(c);
      return list.size() != 0;
   }
   public boolean addAll(E[] tbl)
   {
      for(E e:tbl) list.add(e);
      return list.size() != 0;
   }
   @Override public int getSize() { return list.size(); }
   @Override public E getElementAt(int index) { return list.get(index); }
   @Override public void addElement(E item) { list.add(item); }
   @Override public void removeElement(Object obj) { list.remove(obj); }
   @Override public void insertElementAt(E item,int index) { list.add(index,item); }
   @Override public void removeElementAt(int index) { list.remove(index); }
   @Override public void setSelectedItem(Object anItem) { selected = (E)anItem; }
   @Override public Object getSelectedItem() { return selected; }
   @Override public int size() { return list.size(); }
   @Override public boolean isEmpty() { return  list.isEmpty(); }
   @Override public boolean contains(Object o) { return list.contains(o); }
   class InnerIterator implements Iterator<E>
   {
      private int index=0;
      @Override public boolean hasNext() { return (index<list.size()); }
      @Override public E next() { return list.get(index++); }
   }
   @Override public Iterator<E> iterator()
   {
      return new InnerIterator();
      //return list.iterator();
   }
   @Override public Object[] toArray() { return list.toArray(); }
   @Override public <T> T[] toArray(T[] a) { return list.toArray(a); }
   @Override public boolean add(E e) { return list.add(e); }
   @Override public boolean remove(Object o) { return list.remove(o); }
   @Override public boolean containsAll(Collection<?> c) { return list.containsAll(c); }
   @Override public boolean removeAll(Collection<?> c) { return list.removeAll(c); }
   @Override public boolean retainAll(Collection<?> c) { return list.retainAll(c); }
   @Override public void clear() { list.clear(); }
}
