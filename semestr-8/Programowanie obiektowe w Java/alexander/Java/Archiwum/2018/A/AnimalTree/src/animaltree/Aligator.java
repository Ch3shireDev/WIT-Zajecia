package animaltree;

public class Aligator extends Reptile
{
   public Aligator(String name)
   {
      super(name);
   }
   public @Override String hierarhy()
   {
      return super.hierarhy()+"-Turtle";
   }
}
