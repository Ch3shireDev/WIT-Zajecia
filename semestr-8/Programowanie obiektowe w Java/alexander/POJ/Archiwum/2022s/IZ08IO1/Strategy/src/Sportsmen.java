public class Sportsmen
{
   private String surname;
   private final SportsmenStrategyJump sJump;
   public Sportsmen(String surname,String strJump)
   {
      this.surname=surname;
      sJump=SportsmenStrategyJumpFactory.get(strJump);
   }
   public String getSurname() { return surname; }
   public String Jump() { return sJump.execute(); }
   public String Run() { return "Running"; }
   public String Swim() { return "Swimming"; }
}
