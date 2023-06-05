import java.util.Timer;
import java.util.TimerTask;

public class SignalSourceTimer extends SignalSourceBase
{
    public SignalSourceTimer(int start,int period)
    {
        TimerTask task=new TimerTask()
        {
            @Override public void run() { SendSignals(); }
        };
        new Timer().schedule(task, start, period);
    }
}
