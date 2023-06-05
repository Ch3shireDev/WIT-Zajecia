public class SportsmenRun implements SportsmenCommand
{
   public String execute(Sportsmen sportsmen) { return sportsmen.run(); }
   @Override public String toString() { return "Run"; }
}
