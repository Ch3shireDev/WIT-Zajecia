package animaltree;

public class Cat extends Mammal
{
   public Cat(String name)
   {
      super(name);
   }
   public @Override String hierarhy()
   {
      return super.hierarhy()+"-Cat";
   }
}
