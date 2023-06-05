public abstract class SportsmenCommandComplex implements SportsmenCommand
{
   private String name;
   public SportsmenCommandComplex(String name) { this.name=name; }
   public String getName() { return name; }
   @Override public String toString() { return name; }
}
