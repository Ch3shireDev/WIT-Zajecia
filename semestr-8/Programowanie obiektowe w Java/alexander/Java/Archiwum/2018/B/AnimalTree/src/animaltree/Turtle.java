package animaltree;

public class Turtle extends Reptile
{
   public Turtle(String name) { super(name); }   
   public @Override String hierarchy() { return super.hierarchy()+"-Turtle"; }
}
