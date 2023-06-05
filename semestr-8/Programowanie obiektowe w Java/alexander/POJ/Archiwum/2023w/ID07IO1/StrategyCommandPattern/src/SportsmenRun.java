public class SportsmenRun implements SportsmenCommand
{
   @Override public String command(Sportsmen s) { return s.Run(); }
   @Override public String toString() { return "Run"; }
}
