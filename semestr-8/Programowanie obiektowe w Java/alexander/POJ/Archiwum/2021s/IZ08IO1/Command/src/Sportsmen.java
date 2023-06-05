public class Sportsmen
{
   private String name;
   private SportsmenStrategyRun strategyrun;
   public Sportsmen(String name,SportsmenStrategyRun strategyrun)
   {
      this.name=name;
      this.strategyrun=strategyrun;
   }
   public String run() { return strategyrun.execute(); }
   public String jump() { return "Jumping"; }
   public String swim() { return "Swimming"; }
   public String execute(SportsmenCommand cmd) { return name+": "+cmd.execute(this); }
}
