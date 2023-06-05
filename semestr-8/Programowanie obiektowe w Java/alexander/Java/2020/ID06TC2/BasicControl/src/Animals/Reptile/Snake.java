package Animals.Reptile;

public class Snake extends Reptile
{
    private String name;
    public Snake(String name) { super(name); }
    @Override public String path() { return super.path() + "Snake : "; }
}
