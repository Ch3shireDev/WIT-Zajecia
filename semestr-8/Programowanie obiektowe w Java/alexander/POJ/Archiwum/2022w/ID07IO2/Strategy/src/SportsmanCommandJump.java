
public class SportsmanCommandJump implements SportsmanCommand {

    @Override
    public String execute(Sportsman sportsman) {
        return sportsman.jump();
        
    }

    @Override
    public String toString() {
        return "Jump";
    }
    

    
    
}
