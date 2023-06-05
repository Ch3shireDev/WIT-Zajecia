public class SportsmenCommandSwim implements SportsmenCommand
{
   @Override public String execute(Sportsmen s) { return s.swim(); }
   @Override public String toString() { return "Swim"; }
}
