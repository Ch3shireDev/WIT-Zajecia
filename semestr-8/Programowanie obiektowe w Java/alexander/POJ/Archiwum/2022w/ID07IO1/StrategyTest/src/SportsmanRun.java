public class SportsmanRun implements SportsmanCommand {

    @Override public String execute(Sportsman sportsman) {
        return sportsman.run();
    }
    
    @Override
    public String toString() {
        return "run";
    }
}
