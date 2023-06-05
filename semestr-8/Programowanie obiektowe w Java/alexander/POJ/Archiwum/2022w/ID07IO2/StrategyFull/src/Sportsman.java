public class Sportsman{
    private final String name;
    private final SportsmanStrategyRun strategyRun;
    private final SportsmanStrategySwim strategySwim;
    private final SportsmanStrategyJump strategyJump;
    public Sportsman(String name,SportsmanStrategyRun strategyRun,SportsmanStrategySwim strategySwim,SportsmanStrategyJump strategyJump) {
        this.name = name;
        this.strategyRun = strategyRun;        
        this.strategySwim = strategySwim;
        this.strategyJump = strategyJump;
    }
    public String run() {return "Running";}  
    public String swim() {return "Swimming";}
    public String jump() {return "Jumping";}
    public String execute(SportsmanCommand command){
        return name+": " + command.execute(this);
    }
}