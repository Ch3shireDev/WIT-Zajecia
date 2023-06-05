
public class SportsmanCommandRun implements SportsmanCommand {

    @Override
    public String execute(Sportsman sportsman) {
        return sportsman.run();
        
    }

    @Override
    public String toString() {
        return "Run";
    }
    

    
    
}
