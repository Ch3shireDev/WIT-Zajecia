public class Sportsmen
{
    private String name;
    private String running;
    public Sportsmen(String name,String running) 
    {
        this.name=name; 
        this.running=running;
    }
    public String Run() { return "Running"; }
    public String Jump() { return "Jumping"; }
    public String Swim() { return "Swimming"; }
}
