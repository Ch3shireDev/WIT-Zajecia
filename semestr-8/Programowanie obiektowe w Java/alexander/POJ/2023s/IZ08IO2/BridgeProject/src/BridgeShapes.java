
import java.util.List;

public abstract class BridgeShapes
{
    protected abstract void initializeProceed();
    protected abstract void proceed(ShapeBase shape);
    protected abstract void finalizeProceed();
    public void proceed(List<ShapeBase> shapes)
    {
        initializeProceed();
        for(ShapeBase shape:shapes) proceed(shape);
        finalizeProceed();
    }
}
