package Animals.Reptile;

public class Turtle extends Reptile
{
    private String name;
    public Turtle(String name) { super(name); }
    @Override public String path() { return super.path() + "Turtle : "; }
}
