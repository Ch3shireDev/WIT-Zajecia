package animaltree;

public class Mammal extends Animal
{
   public Mammal(String name) 
   {
      super(name);
   }
   public @Override String hierarhy()
   {
      return super.hierarhy()+"Mammal";
   }
}