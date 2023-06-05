import java.util.ArrayList;

public class SignalSourceBase implements SignalSource
{  
    private final ArrayList<SignalListener> lst=new ArrayList<>();
    @Override public void SendSignals() { lst.forEach((sig) -> sig.signal(this)); }
    @Override public void AddListener(SignalListener sig) { lst.add(sig); }
    @Override public void RemoveListener(SignalListener sig) { lst.remove(sig); }
    @Override public void Clear() { lst.clear(); }
}
