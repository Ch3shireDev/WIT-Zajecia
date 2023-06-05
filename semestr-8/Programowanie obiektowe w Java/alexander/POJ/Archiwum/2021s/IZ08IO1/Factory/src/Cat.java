public class Cat extends Mammal
{
   public Cat(String name) { super(name); }
   @Override public String path() { return super.path()+"/Cat"; }
}
