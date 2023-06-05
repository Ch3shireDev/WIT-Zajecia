public abstract class Insect extends Animal
{
   public Insect(String name) { super(name); }
   @Override public String path() { return super.path()+"/Insect"; }
}
