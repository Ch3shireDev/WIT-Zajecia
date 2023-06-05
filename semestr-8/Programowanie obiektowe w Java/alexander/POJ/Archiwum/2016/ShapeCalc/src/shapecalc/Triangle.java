package shapecalc;

public class Triangle implements IntfShapeCalc
{
    private final double[] values=new double[3];
    private static final String[] names=new String[] { "Podstawa","Wysokość","Powierzchnia" };
    private final IntfCalcValue[] calcs=new IntfCalcValue[]
    {
        new IntfCalcValue() {@Override public double calc() { return 2*getArea()/getHeight(); } },
        new IntfCalcValue() {@Override public double calc() { return 2*getArea()/getBase(); } },
        new IntfCalcValue() {@Override public double calc() { return getBase()*getHeight()/2; } }
    };
    @Override public void setValue(int index,double value) { values[index]=value; }
    @Override public double calcValue(int index) { return calcs[index].calc(); }
    @Override public String getName(int index) { return names[index]; }
    private double getBase() { return values[0]; }
    private double getHeight() { return values[1]; }
    private double getArea() { return values[2]; }
}
