public abstract class Mammal extends Animal
{
   public Mammal(String name) { super(name); }
   @Override public String path() { return super.path()+"/Mammal"; }
}
