
import jumpStrategy.IJump;
import runStrategy.IRun;
import swimStrategy.ISwim;

public class Sportsman 
{
   private final ISwim swim;
   private final IJump jump;
   private final IRun run;

   public Sportsman(ISwim swim, IJump jump, IRun run) {
      this.swim = swim;
      this.jump = jump;
      this.run = run;
   }
   
   
   public String run() { return run.run(); }
   public String swim() { return swim.swim(); }
   public String jump() { return jump.jump(); }
}
