package statistics;

public interface IStatStrategy 
{
    void init();
    void proceed(double value);
    double finish();
}