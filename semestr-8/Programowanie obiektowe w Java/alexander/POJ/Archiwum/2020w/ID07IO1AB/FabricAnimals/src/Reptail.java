public class Reptail extends Animal
{
   public Reptail(String name) { super(name); }
   @Override protected String path() { return super.path()+"/Reptail"; }
}