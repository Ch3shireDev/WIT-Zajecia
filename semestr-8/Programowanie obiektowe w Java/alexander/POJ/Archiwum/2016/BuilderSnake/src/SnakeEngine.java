
import java.util.Timer;
import java.util.TimerTask;


public class SnakeEngine 
{
    private final IntScreen is;
    private final IntKeyboard ik;
    private int Score,Delta=1;
    public SnakeEngine(IntScreen is,IntKeyboard ik)
    {
       this.is=is;
       this.ik=ik;
       Score=0;
       TimerTask task = new TimerTask()
       {
           @Override public void run()
           {
               turn();
           }               
       };
       Timer tm = new Timer();
       tm.schedule(task, 0, 300);
    }

    public IntScreen getIs() { return is; }
    
    public void turn()
    {
        if(ik.keyUp()) Delta=1;
        else if(ik.keyDn()) Delta=-1;
        Score+=Delta;
        is.setScore(Score);
    }
}
