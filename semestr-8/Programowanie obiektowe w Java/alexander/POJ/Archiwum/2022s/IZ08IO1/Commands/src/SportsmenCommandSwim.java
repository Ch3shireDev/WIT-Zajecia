public class SportsmenCommandSwim implements SportsmenCommand
{
   @Override public String Execute(Sportsmen s) { return s.Swim(); }
   @Override public String toString() { return "Swim"; }
}
