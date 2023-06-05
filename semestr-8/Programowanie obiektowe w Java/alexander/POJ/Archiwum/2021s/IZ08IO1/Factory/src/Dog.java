public class Dog extends Mammal
{
   public Dog(String name) { super(name); }
   @Override public String path() { return super.path()+"/Dog"; }
}
