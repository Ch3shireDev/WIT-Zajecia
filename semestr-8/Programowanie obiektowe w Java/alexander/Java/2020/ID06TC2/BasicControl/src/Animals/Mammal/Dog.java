package Animals.Mammal;

public class Dog extends Mammal
{
    private String name;
    public Dog(String name) { super(name); }
    @Override public String path() { return super.path() + "Dog : "; }
}
