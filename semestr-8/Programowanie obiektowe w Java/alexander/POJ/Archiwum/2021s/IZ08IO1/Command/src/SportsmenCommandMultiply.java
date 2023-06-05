
public class SportsmenCommandMultiply extends SportsmenCommandComplex
{
   private SportsmenCommand cmd;
   private int count;
   public SportsmenCommandMultiply(String name,SportsmenCommand cmd,int count)
   {
      super(name);
      this.cmd=cmd;
      this.count=count;
   }
   @Override public String execute(Sportsmen sportsmen)
   {
      return String.format("%d x %s",count,cmd.execute(sportsmen));
   }
}
