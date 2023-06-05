public class Sportsmen
{
    private final String name;
    public Sportsmen(String name) { this.name = name; }
    public String run() { return "Running"; }
    public String jump() { return "Jumping"; }
    public String swim() { return "Swimming"; }
    public String execute(SportsmenCommand cmd)
    {
        return name + ": " + cmd.execute(this);
    }
}
