public class SportsmenCommandRun implements SportsmenCommand
{
   @Override public String execute(Sportsmen s) { return s.run(); }
   @Override public String toString() { return "Run"; }
}
