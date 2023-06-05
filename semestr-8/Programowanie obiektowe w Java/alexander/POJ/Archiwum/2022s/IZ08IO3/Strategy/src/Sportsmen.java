public class Sportsmen
{
   private String surname;
   private SportsmenStrategyRun sRun;
   public Sportsmen(String surname,SportsmenStrategyRun sRun)
   {
      this.surname=surname;
      this.sRun=sRun;
   }
   public String getSurname() { return surname; }

   public String jump() { return "Jumping"; }
   public String run() { return sRun.run(); }
   public String swim() { return "Swimming"; }
   String execute(SportsmenCommand cmd) { return surname+": "+cmd.execute(this); }
}
