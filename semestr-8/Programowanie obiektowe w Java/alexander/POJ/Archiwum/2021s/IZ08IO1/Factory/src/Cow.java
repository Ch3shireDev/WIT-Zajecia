public class Cow extends Mammal
{
   public Cow(String name) { super(name); }
   @Override public String path() { return super.path()+"/Cow"; }
}
