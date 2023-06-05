package Animals.Reptile;

public class Lizard extends Reptile
{
    private String name;
    public Lizard(String name) { super(name); }
    @Override public String path() { return super.path() + "Lizard : "; }
}
