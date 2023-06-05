
import java.util.List;

public class SportsmenCommandMultiply extends SportsmenCommandComplex
{
   private int count;
   private final SportsmenCommand cmd;
   public SportsmenCommandMultiply(String name,int count,SportsmenCommand cmd)
   {
      super(name);
      this.count=count;
      this.cmd=cmd;
   }
   @Override public String execute(Sportsmen s)
   {
      return Integer.toString(count)+" * "+cmd.execute(s);
   }
}
