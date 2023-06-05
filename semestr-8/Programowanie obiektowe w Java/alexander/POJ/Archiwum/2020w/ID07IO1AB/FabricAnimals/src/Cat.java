public class Cat extends Mammal
{
   public Cat(String name) { super(name); }
   @Override protected String path() { return super.path()+"/Cat"; }
}