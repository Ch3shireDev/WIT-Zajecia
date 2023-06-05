public class Fly extends Insect
{
   public Fly(String name) { super(name); }
   @Override public String path() { return super.path()+"/Fly"; }
}
