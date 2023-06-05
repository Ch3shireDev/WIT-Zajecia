
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class ShapeFactory
{
    public static interface ShapeBaseMaker { public ShapeBase make(String parameters); }
    private static HashMap<String,ShapeBaseMaker> map=new HashMap<String,ShapeBaseMaker>()
    {
        {
            put("Circle",    (p)->new ShapeCircle(p));
            put("Rectangle", (p)->new ShapeRectangle(p));
            put("Triangle",  (p)->new ShapeTriangle(p));
        }
    };
    public static List<String> keys=map.keySet().stream().sorted().collect(Collectors.toList());
    public static ShapeBase make(String key,String parameters)
    {
        return map.get(key).make(parameters);
    }
}
