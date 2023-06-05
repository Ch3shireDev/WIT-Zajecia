
public class SportsmanCommandSwim implements SportsmanCommand {

    @Override
    public String execute(Sportsman sportsman) {
        return sportsman.swim();

    }

    @Override
    public String toString() {
        return "Swim";
    }

}
