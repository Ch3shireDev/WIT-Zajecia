package Animals.Mammal;

public class Cow extends Mammal
{
    private String name;
    public Cow(String name) { super(name); }
    @Override public String path() { return super.path() + "Cow : "; }
}
