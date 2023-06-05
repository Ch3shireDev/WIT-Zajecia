public class Sportsman
{
   private final String Name;
   private final SportsmanStrategyRun run;
   private final SportsmanStrategyJump jump;
   private final SportsmanStrategySwim swim;

   public Sportsman(String Name,SportsmanStrategyRun run,SportsmanStrategyJump jump,SportsmanStrategySwim swim)
   {
      this.Name=Name;
      this.run=run;
      this.jump=jump;
      this.swim=swim;
   }
   public String getName() { return Name; }
   public String Run() { return run.execute(); }
   public String Jump() { return jump.execute(); }
   public String Swim() { return swim.execute(); }
   public String execute(SportsmanCommand cmd)
   {
      return Name+": "+cmd.execute(this);
   }
}
