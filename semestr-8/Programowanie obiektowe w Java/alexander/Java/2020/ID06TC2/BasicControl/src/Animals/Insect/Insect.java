package Animals.Insect;
import Animals.Animal;

public class Insect extends Animal
{
    private String name;
    public Insect(String name) { super(name); }
    @Override public String path() { return super.path() + "Insect : "; }
}
