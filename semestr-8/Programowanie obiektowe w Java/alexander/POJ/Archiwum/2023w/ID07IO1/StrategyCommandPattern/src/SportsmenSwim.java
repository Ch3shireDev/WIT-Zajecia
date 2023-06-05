public class SportsmenSwim implements SportsmenCommand
{
   @Override public String command(Sportsmen s) { return s.Swim(); }
   @Override public String toString() { return "Swim"; }
}
