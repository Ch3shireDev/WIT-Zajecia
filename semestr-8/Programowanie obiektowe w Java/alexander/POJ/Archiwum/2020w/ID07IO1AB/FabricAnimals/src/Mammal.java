public class Mammal extends Animal
{
   public Mammal(String name) { super(name); }
   @Override protected String path() { return super.path()+"/Mammal"; }
}