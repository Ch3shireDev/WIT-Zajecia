public class Sportsmen
{
   private String surname;
   private SportsmenStrategyRun stRun;
   public Sportsmen(String surname,SportsmenStrategyRun stRun)
   {
      this.surname=surname;
      this.stRun=stRun;
   }
   public String getSurname() { return surname; }
   public String Run() { return stRun.Run(); }
   public String Jump() { return "Jumping"; }
   public String Swim() { return "Swimming"; }
}
