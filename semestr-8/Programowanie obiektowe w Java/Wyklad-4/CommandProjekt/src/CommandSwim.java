
public class CommandSwim implements SportsmanCommand {

    @Override
    public String Execute(Sportsman sportsman) {
        return sportsman.Swim();
    }
    @Override
    public String toString() {
        return "Swim";
    }
}
