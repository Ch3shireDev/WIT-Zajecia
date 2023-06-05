package Animals.Insect;

public class Ladybug extends Insect
{
    private String name;
    public Ladybug(String name) { super(name); }
    @Override public String path() { return super.path() + "Ladybug : "; }
}
