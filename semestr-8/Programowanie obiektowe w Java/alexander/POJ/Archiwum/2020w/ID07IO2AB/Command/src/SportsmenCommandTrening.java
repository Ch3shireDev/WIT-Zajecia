
import java.util.ArrayList;

public class SportsmenCommandTrening implements SportsmenCommand
{
   private final String name;
   private final ArrayList<SportsmenCommand> list;
   public SportsmenCommandTrening(String name, ArrayList<SportsmenCommand> list)
   {
      this.name = name;
      this.list = list;
   }
   public String execute(Sportsman sportsman)
   {
      final StringBuilder sb=new StringBuilder();
      //*///
      boolean first=true;
      for(SportsmenCommand cmd:list)
      {
         if(first) first=false;
         else sb.append(", ");
         sb.append(cmd.execute(sportsman));
      }
      /*/
      for(int i=0;i<list.size();++i)
      {
         if(i>0) sb.append(", ");
         sb.append(list.get(i).execute(sportsman));
      }
      //*///
      return sb.toString();
   }
   @Override public String toString() { return name; }
}
