public class Sportsmen
{
    private String name;
    private SportsmenStrategySwim strSwim;
    public Sportsmen(String name,SportsmenStrategySwim strSwim)
    {
        this.name = name; 
        this.strSwim = strSwim;
    }
    public String Run() { return "Running"; }
    public String Jump() { return "Jumping"; }
    public String Swim() { return strSwim.Execute(); }
}
