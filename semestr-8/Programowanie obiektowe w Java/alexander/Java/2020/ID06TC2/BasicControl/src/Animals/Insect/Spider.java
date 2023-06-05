package Animals.Insect;

public class Spider extends Insect
{
    private String name;
    public Spider(String name) { super(name); }
    @Override public String path() { return super.path() + "Spider : "; }
}
