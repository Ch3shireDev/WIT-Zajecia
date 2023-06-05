package Animals.Reptile;
import Animals.Animal;

public class Reptile extends Animal
{
    private String name;
    public Reptile(String name) { super(name); }
    @Override public String path() { return super.path() + "Reptile : "; }
}
