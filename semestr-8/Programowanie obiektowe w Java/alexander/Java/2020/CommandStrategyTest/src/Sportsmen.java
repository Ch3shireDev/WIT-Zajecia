public class Sportsmen 
{
   private final String name;
   private final SportsmenStrategyRun Run; // pole z przypisaną strategią biegu
   private final SportsmenStrategyJump Jump; // pole z przypisaną strategią skoku
   private final SportsmenStrategySwim Swim; // pole z przypisaną strategią plywania

   // w konstruktorze przypisujemy imie oraz strategii
   public Sportsmen(String name, SportsmenStrategyRun Run, SportsmenStrategyJump Jump, SportsmenStrategySwim Swim)
   {
      this.name=name;
      this.Run=Run;
      this.Jump=Jump;
      this.Swim=Swim;
   }
   public String run() { return Run.execute(); } // wykonanie przypisanej strategii biegu
   public String jump() { return Jump.execute(); } // wykonanie przypisanej strategii skoku
   public String swim() { return Swim.execute(); } // wykonanie przypisanej strategii plywania
   public String execute(SportsmenCommand cmd)
   {
      return name+": "+cmd.execute(this);
   }
}
