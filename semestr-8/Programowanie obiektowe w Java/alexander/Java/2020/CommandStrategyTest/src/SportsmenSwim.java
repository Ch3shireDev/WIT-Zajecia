public class SportsmenSwim implements SportsmenCommand
{
   public String execute(Sportsmen sportsmen) { return sportsmen.swim(); }
   @Override public String toString() { return "Swim"; }
}
