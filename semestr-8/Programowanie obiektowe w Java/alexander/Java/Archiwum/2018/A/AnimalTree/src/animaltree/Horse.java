package animaltree;

public class Horse extends Mammal
{
   public Horse(String name)
   {
      super(name);
   }
   public @Override String hierarhy()
   {
      return super.hierarhy()+"-Horse";
   }
}
