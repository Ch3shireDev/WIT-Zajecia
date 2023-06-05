public class Sportsman{
    private final String name;
    private final SportsmenStrategySwim stSwim;

    public Sportsman(String name,SportsmenStrategySwim stSwim) {
        this.name=name;
        this.stSwim=stSwim;
    }
    public String run() { return "Running"; }
    public String jump() { return "Jumping"; }
    public String swim() { return stSwim.execute(); }
    public String execute(SportsmanCommand command) { return name+": " + command.execute(this); }
}