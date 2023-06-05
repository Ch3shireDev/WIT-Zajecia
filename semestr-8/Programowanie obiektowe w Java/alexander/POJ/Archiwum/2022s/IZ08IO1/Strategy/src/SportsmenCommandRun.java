public class SportsmenCommandRun implements SportsmenCommand
{
   @Override public String Execute(Sportsmen s) { return s.Run(); }
   @Override public String toString() { return "Run"; }
}
