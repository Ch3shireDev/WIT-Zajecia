public class SportsmenCommandSwim implements SportsmenCommand
{
   @Override public String execute(Sportsmen sportsmen)
   {
      return sportsmen.Swim();
   }

   @Override public String toString() { return "Swim"; }
}
