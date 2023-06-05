
import java.util.List;

public abstract class BridgeShapeList
{
    public abstract void initialiseProcess();
    public abstract void proceed(ShapeBase shape);
    public abstract void finaliseProcess();
    public final void proceed(List<ShapeBase> shapes)
    {
        initialiseProcess();
        for(ShapeBase shape:shapes) proceed(shape);
        finaliseProcess();
    }
}
