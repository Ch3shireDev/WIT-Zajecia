public class SportsmenCommandRun implements SportsmenCommand
{
   public String execute(Sportsman sportsman) { return sportsman.run(); }
   @Override public String toString() { return "Run"; }
}
