package animaltree;

public abstract class Mammal extends Animal
{
   public Mammal(String name) { super(name); }   
   public @Override String hierarchy() { return super.hierarchy()+"Insect"; }
}
