public abstract class Reptile extends Animal
{
   public Reptile(String name) { super(name); }
   @Override public String path() { return super.path()+"/Reptile"; }
}
