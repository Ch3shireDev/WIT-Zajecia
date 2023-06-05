public class Sportsman
{
   private final String name;
   private final SportsmenStrategySwim swim;
   public Sportsman(String name,SportsmenStrategySwim swim)
   {
      this.name=name;
      this.swim=swim;
   }
   public String run() { return "Running"; }
   public String swim() { return swim.doit(); }
   public String jump() { return "Jumping"; }
}
