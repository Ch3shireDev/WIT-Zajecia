public class Reptile extends Animal
{
   public Reptile(String name) { super(name); }
   @Override protected String path() { return super.path() + "/Reptile"; }
}
