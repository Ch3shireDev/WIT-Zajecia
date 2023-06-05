
public abstract class SportsmanCommandComplex implements SportsmanCommand
{
   private final String name;
   public SportsmanCommandComplex(String name) { this.name=name; }
   @Override public String toString() { return name; }
}
