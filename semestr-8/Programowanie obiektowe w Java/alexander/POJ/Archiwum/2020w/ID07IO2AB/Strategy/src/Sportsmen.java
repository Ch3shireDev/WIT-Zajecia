public class Sportsmen
{
   private final String Name;
   private final SportsmenStrategyRun ssRun;
   public Sportsmen(String Name,SportsmenStrategyRun ssRun)
   {
      this.Name=Name;
      this.ssRun=ssRun;
   }
   String run() { return ssRun.doit(); }
   String jump() { return "Jumping"; }
   String swim() { return "Swimming"; }
   @Override public String toString() { return Name; }
}
