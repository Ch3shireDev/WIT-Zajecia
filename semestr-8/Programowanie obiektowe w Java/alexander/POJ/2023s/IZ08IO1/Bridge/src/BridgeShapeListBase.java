
import java.util.List;

public interface BridgeShapeListBase
{
    public void initialiseProceed();
    public void Proceed(ShapeBase shape);
    public void finalizeProceed();
    public default void Proceed(List<ShapeBase> shapes)
    {
        initialiseProceed();
        for(ShapeBase shape:shapes) Proceed(shape);
        finalizeProceed();
    }
}
