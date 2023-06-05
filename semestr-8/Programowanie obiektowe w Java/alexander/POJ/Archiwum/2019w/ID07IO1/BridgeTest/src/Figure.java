
import java.awt.Graphics;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Set;

public abstract class Figure 
{
    public static double[] toDoubleArray(String str)
    {
        String[] tb=str.split("[\\s\t\r\n]+");
        ArrayList<Double> db = new ArrayList<>();
        for(int i=0;i<tb.length;++i)
        {
            try { db.add(Double.parseDouble(tb[i])); }
            catch(NumberFormatException e) {}
        }
        double[] ret = new double[db.size()];
        for(int i=0;i<ret.length;++i) ret[i]=db.get(i);
        return ret;
    }
    private static final HashMap<String,FigureMaker> map=makemap();
    private static HashMap<String,FigureMaker> makemap()
    {
        HashMap<String,FigureMaker> locmap=new HashMap<>();
        locmap.put("Triangle",(str) -> FigureTriangle.make(str));
        locmap.put("Rectangle",(str) -> FigureRectangle.make(str));
        locmap.put("Circle",(str) -> FigureCircle.make(str));
        return locmap;
    };
    public static Figure make(String type,String params)
    {
        return map.get(type).make(params);
    }
    public static String[] Keys()
    {
        Set<String> keys = map.keySet();
        String[] akeys = new String[keys.size()];
        keys.toArray(akeys);
        Arrays.sort(akeys);
        return akeys;
    }
    public static int to_i(double val) { return (int)Math.round(val); }
    public abstract void draw(Graphics g);
}
