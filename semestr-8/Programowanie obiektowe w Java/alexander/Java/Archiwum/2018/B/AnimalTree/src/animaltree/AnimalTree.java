package animaltree;

import java.util.ArrayList;
import java.util.List;

public class AnimalTree 
{
   public static void main(String[] args) 
   {
      Animal[] tb=new Animal[6];
      tb[0]=new Horse("h");
      tb[1]=new Cat("c");
      tb[2]=new Fly("f");
      tb[3]=new Butterfly("b");
      tb[4]=new Turtle("t");
      tb[5]=new Aligator("a");
      for(int i=0;i<tb.length;++i) System.out.println(tb[i]);
      System.out.println("----");
      for(Animal a:tb) System.out.println(a);
      System.out.println("----");
      
      Animal[] tbl=
      {
         new Horse("h"),
         new Cat("c"),
         new Fly("f"),
         new Butterfly("b"),
         new Turtle("t"),
         new Aligator("a")
      };
      for(int i=0;i<tbl.length;++i) System.out.println(tbl[i]);
      System.out.println("----");
      for(Animal a:tbl) System.out.println(a);
      System.out.println("----");
      
      ArrayList<Animal> lst=new ArrayList<>();
      lst.add(new Horse("h"));
      lst.add(new Cat("c"));
      lst.add(new Fly("f"));
      lst.add(new Butterfly("b"));
      lst.add(new Turtle("t"));
      lst.add(new Aligator("a"));
      for(int i=0;i<lst.size();++i) System.out.println(lst.get(i));
      System.out.println("----");
      for(Animal a:lst) System.out.println(a);
      System.out.println("----");
   }   
}
