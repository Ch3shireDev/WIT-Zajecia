package animaltree;

public class Batterfly extends Insect
{
   public Batterfly(String name)
   {
      super(name);
   }
   public @Override String hierarhy()
   {
      return super.hierarhy()+"-Batterfly";
   }
}
