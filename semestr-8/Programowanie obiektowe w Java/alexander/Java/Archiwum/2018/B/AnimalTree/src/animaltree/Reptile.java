package animaltree;

public abstract class Reptile extends Animal
{
   public Reptile(String name) { super(name); }   
   public @Override String hierarchy() { return super.hierarchy()+"Reptile"; }
}
