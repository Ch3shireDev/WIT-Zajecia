
import java.util.Comparator;

public class Student implements Comparable<Student>
{
   private String name,surname;
   private int index;

   public Student(String name,String surname,int index)
   {
      this.name=name;
      this.surname=surname;
      this.index=index;
   }

   @Override public int compareTo(Student s)
   {
      return new FullComparator().compare(this,s);
   }

   public static class FullComparator implements Comparator<Student>
   {
      @Override public int compare(Student a,Student b)
      {
         int ret=a.surname.compareTo(b.surname);
         if(ret==0) ret=a.name.compareTo(a.name);
         if(ret==0) ret=(a.index>b.index?1:0)-(a.index<b.index?1:0);
         return ret;
      }
   }
   public static class IndexComparator implements Comparator<Student>
   {
      @Override public int compare(Student a,Student b)
      {
         return (a.index>b.index?1:0)-(a.index<b.index?1:0);
      }
   }
   @Override public String toString()
   {
      return "name="+name+", surname="+surname+", index="+index;
   }
}
