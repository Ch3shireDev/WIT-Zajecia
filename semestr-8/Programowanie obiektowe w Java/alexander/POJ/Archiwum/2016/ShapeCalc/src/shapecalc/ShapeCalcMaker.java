package shapecalc;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Set;

public class ShapeCalcMaker
{
    private static HashMap<String,IntfShapeCalcMaker> map=mapmake();
    private static HashMap<String,IntfShapeCalcMaker> mapmake()
    {
        HashMap<String,IntfShapeCalcMaker> map=new HashMap<String,IntfShapeCalcMaker>();
        map.put("Triangle",new IntfShapeCalcMaker() { @Override public IntfShapeCalc make() { return new Triangle(); } } );
        map.put("Triangle2",new IntfShapeCalcMaker() { @Override public IntfShapeCalc make() { return new Triangle(); } } );
        return map;
    }
    public static int getSize() { return map.size(); }
    public static String[] names() { return map.keySet().toArray(new String[0]); }
    public IntfShapeCalc makeCalc(String name) { return map.get(name).make(); }
}
