public class Insect extends Animal
{
   public Insect(String name) { super(name); }
   @Override protected String path() { return super.path()+"/Insect"; }
}