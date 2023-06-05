public class Dog extends Mammal
{
   public Dog(String name) { super(name); }
   @Override protected String path() { return super.path()+"/Dog"; }
}