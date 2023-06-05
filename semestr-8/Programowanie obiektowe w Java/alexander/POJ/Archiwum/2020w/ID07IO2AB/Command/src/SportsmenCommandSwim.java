public class SportsmenCommandSwim implements SportsmenCommand
{
   public String execute(Sportsman sportsman) { return sportsman.swim(); }
   @Override public String toString() { return "Swim"; }
}
