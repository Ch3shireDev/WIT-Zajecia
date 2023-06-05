public class Fly extends Insect
{
   public Fly(String name) { super(name); }
   @Override protected String path() { return super.path()+"/Fly"; }
}