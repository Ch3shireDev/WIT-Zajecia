package Animals.Mammal;

public class Cat extends Mammal
{
    private String name;
    public Cat(String name) { super(name); }
    @Override public String path() { return super.path() + "Cat : "; }
}
