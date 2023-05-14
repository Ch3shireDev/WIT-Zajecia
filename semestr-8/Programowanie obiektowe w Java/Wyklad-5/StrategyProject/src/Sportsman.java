public class Sportsman {
    private String name;
    private StrategyRun running;
    private StrategySwim swimming;
    private StrategyJump jumping;

    public Sportsman(String running, String swimming, String jumping, String name) {
        this.name = name;
        this.running = StrategyRunFactory.get(running);
        this.swimming = StrategySwimFactory.get(swimming);
        this.jumping = StrategyJumpFactory.get(jumping);
    }

    public String Run() {
        return running.execute();
    }

    public String Jump() {
        return jumping.execute();
    }

    public String Swim() {
        return swimming.execute();
    }

    public String execute(SportsmanCommand command) {
        return name + ": " + command.Execute(this);
    }

}
