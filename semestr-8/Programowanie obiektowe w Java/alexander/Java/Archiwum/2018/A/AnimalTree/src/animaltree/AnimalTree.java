package animaltree;

import java.util.ArrayList;

public class AnimalTree 
{
   public static void main(String[] args) 
   {
      Animal[] tb=new Animal[6];
      tb[0]=new Horse("h");
      tb[1]=new Cat("c");
      tb[2]=new Fly("f");
      tb[3]=new Batterfly("b");
      tb[4]=new Turtle("t");
      tb[5]=new Aligator("a");
      for(int i=0;i<tb.length;++i) tb[i].introduce();
      System.out.println("----");
      for(Animal a:tb) a.introduce();
      
      ArrayList<Animal> lst=new ArrayList<>();
      lst.add(new Horse("h"));
      lst.add(new Cat("c"));
      lst.add(new Fly("f"));
      lst.add(new Batterfly("b"));
      lst.add(new Turtle("t"));
      lst.add(new Aligator("a"));
      for(int i=0;i<lst.size();++i) lst.get(i).introduce();
      System.out.println("----");
      for(Animal a:lst) a.introduce();
   }
}
