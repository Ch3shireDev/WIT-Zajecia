public class SportsmenCommandRun implements SportsmenCommand
{
   @Override public String execute(Sportsmen sportsmen) { return sportsmen.run(); }
   @Override public String toString() { return "Run"; }
}
