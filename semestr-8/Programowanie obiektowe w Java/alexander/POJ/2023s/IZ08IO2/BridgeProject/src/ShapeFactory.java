import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public abstract class ShapeFactory
{
    private interface ShapeMaker { public ShapeBase make(String text); }
    private static HashMap<String,ShapeMaker> map=new HashMap<String,ShapeMaker>()
    {
        {
            put("Circle",    (text) -> new ShapeCircle(text));
            put("Triangle",  (text) -> new ShapeTriangle(text));
            put("Rectangle", (text) -> new ShapeRectangle(text));
        }
    };
    public static List<String> keys=map.keySet().stream().sorted().collect(Collectors.toList());
    public static ShapeBase make(String key,String text) { return map.get(key).make(text); }
}
