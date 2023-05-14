
public class CommandJump implements SportsmanCommand {

    @Override
    public String Execute(Sportsman sportsman) {
        return sportsman.Jump();
    }

    @Override
    public String toString() {
        return "Jump";
    }
    
}
