public interface SignalSource 
{
    void SendSignals();
    void AddListener(SignalListener sig);
    void RemoveListener(SignalListener sig);
    void Clear();
}
