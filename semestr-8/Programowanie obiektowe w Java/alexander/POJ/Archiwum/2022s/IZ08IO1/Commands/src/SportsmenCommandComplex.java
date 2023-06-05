public abstract class SportsmenCommandComplex implements SportsmenCommand
{
   private String name;
   public SportsmenCommandComplex(String name) { this.name=name; }
   @Override public String toString() { return name; }
}
