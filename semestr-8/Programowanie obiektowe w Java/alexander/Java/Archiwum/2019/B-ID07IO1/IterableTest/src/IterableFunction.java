
import java.util.Arrays;
import java.util.Comparator;
import java.util.Iterator;

class IterableFunction
{
   static Iterable<Student> Arr(final Student... Tb)
   {
      Student[] Cp=Arrays.copyOf(Tb,Tb.length);
      Arrays.sort(Cp);
      return new Iterable<Student>()
      {
         private int index=0;
         @Override public Iterator<Student> iterator()
         {
            return new Iterator<Student>()
            {
               @Override public boolean hasNext() { return index<Cp.length; }
               @Override public Student next() { return Cp[index++]; }
            };
         }
      };
   }
   static Iterable<Student> Arr(final Comparator<Student> cmp,final Student... Tb)
   {
      Student[] Cp=Arrays.copyOf(Tb,Tb.length);
      Arrays.sort(Cp,cmp);
      return new Iterable<Student>()
      {
         private int index=0;
         @Override public Iterator<Student> iterator()
         {
            return new Iterator<Student>()
            {
               @Override public boolean hasNext() { return index<Cp.length; }
               @Override public Student next() { return Cp[index++]; }
            };
         }
      };
   }
}
