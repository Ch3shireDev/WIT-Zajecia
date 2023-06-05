package animaltree;

public class Cat extends Mammal
{
   public Cat(String name) { super(name); }   
   public @Override String hierarchy() { return super.hierarchy()+"-Cat"; }
}
