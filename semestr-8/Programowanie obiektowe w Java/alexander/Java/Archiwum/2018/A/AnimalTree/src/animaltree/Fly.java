package animaltree;

public class Fly extends Insect
{
   public Fly(String name)
   {
      super(name);
   }
   public @Override String hierarhy()
   {
      return super.hierarhy()+"-Fly";
   }
}
