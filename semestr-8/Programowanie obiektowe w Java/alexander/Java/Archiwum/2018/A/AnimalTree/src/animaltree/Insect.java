package animaltree;

public class Insect extends Animal
{
   public Insect(String name) 
   {
      super(name);
   }
   public @Override String hierarhy()
   {
      return super.hierarhy()+"Insect";
   }
}
