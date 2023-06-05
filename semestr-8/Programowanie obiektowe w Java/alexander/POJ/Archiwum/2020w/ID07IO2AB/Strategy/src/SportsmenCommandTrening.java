
import java.util.ArrayList;

public class SportsmenCommandTrening implements SportsmenCommand
{
   private final String name;
   private final ArrayList<SportsmenCommand> list;
   public SportsmenCommandTrening(String name,ArrayList<SportsmenCommand> list)
   {
      this.name=name;
      this.list=list;
   }
   public String execute(Sportsmen sportsmen)
   {
      StringBuilder sb=new StringBuilder();
      boolean first=true;
      for(SportsmenCommand cmd:list)
      {
         if(first) first=false;
         else sb.append(", ");
         sb.append(cmd.execute(sportsmen));
      }
      return sb.toString();
   }
}
