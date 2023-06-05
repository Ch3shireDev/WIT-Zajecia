public abstract class BridgeFiguresBase 
{
    protected void init() {}
    protected void proceed(FigureCollection list) {}
    protected void finish() {}
    public void propagate(FigureCollection list)
    {
        init();
        proceed(list);
        finish();
    }
}
