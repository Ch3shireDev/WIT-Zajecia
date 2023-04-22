
public class CommandRun implements SportsmanCommand {

    @Override
    public String Execute(Sportsman sportsman) {
        return sportsman.Run();
    }
    @Override
    public String toString() {
        return "Run";
    }
}
