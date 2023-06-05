public class Sportsman {
    private final String name;
    private final SportsmenStrategySwim stSwim;

    public Sportsman(String name,SportsmenStrategySwim stSwim) {
        this.name = name;
        this.stSwim = stSwim;
    }

    public String swim(){
        return stSwim.execute();
    }

    public String run(){
        return "running";
    }

    public String jump(){
        return "jumping";
    }

    public String execute(SportsmanCommand cmd){
        return this.name + ": " + cmd.execute(this);
    }
}
