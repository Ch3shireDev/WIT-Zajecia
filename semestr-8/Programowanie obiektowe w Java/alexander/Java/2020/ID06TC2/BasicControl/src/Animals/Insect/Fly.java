package Animals.Insect;

public class Fly extends Insect
{
    private String name;
    public Fly(String name) { super(name); }
    @Override public String path() { return super.path() + "Fly : "; }
}
