package animaltree;

public class Reptile extends Animal
{
   public Reptile(String name) 
   {
      super(name);
   }
   public @Override String hierarhy()
   {
      return super.hierarhy()+"Reptile";
   }
}