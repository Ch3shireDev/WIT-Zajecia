package animaltree;

public class Butterfly extends Insect
{
   public Butterfly(String name) { super(name); }   
   public @Override String hierarchy() { return super.hierarchy()+"-Butterfly"; }
}
