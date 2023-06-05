public class SportsmanCommandSwim implements SportsmanCommand
{
   @Override public String execute(Sportsmen sportsmen) { return sportsmen.swim(); }
   @Override public String toString() { return "Swim"; }
}
