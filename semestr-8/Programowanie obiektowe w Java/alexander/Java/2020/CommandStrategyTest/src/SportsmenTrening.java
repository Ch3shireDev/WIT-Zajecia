public class SportsmenTrening implements SportsmenCommand
{
   private final String name; // nazwa treningu
   private final SportsmenCommand[] cmds; // skøad treningu (cwiczenia)
   public SportsmenTrening(String name, SportsmenCommand[] cmds) // konstruktor
   {
      this.name = name;
      this.cmds = cmds;
   }   
   public String execute(Sportsmen sportsmen)
   {
      StringBuilder sb=new StringBuilder();
      boolean first=true; // flaga pierwswzego elemntu
      for(SportsmenCommand cmd:cmds)
      {
         if(first) first=false; // usuniécie flagi pierwszego wiersza
         else sb.append(", "); // dopisanie separatora przed niepierwszym wierszem
         sb.append(cmd.execute(sportsmen)); // dopisania raportu wykonania komendy
      }
      return sb.toString(); // zwracamy raport zloæony
   }
   @Override public String toString() { return name; }
}
