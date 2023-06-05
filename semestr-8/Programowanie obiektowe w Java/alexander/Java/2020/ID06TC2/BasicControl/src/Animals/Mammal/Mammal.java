package Animals.Mammal;
import Animals.Animal;

public class Mammal extends Animal
{
    private String name;
    public Mammal(String name) { super(name); }
    @Override public String path() { return super.path() + "Mammal : "; }
}
