package animaltree;

public abstract class Insect extends Animal
{
   public Insect(String name) { super(name); }   
   public @Override String hierarchy() { return super.hierarchy()+"Insect"; }
}
