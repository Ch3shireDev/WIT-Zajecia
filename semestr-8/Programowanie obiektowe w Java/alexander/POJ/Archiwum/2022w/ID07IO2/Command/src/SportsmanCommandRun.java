public class SportsmanCommandRun implements SportsmanCommand
{
   @Override public String execute(Sportsmen sportsmen) { return sportsmen.run(); }
   @Override public String toString() { return "Run"; }
}
