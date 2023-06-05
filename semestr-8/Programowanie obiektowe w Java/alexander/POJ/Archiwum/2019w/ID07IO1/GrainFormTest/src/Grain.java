
import java.awt.Color;
import java.util.Random;

public class Grain 
{
    private final int index;
    public Grain()
    {
        index=GrainFactory.rndIndex();
    }
    public int getWeight()
    {
        return GrainFactory.getGrain(index).getWeight();
    }
    public Color getColor()
    {
        return GrainFactory.getGrain(index).getColor();
    }
}

class GrainFly
{
    private static final int[][] CLRS=new int[][]{{239,245,10},{102,51,0}};
    public static final int MIN_WEIGHT=500;
    public static final int MAX_WEIGHT=2000;
    private int weight;
    private Color color;    
    public GrainFly(int weight)
    {
        this.weight=weight;
        this.color=new Color(scale(0),scale(1),scale(2));
    }
    private int scale(int layer)
    {
        return 
            CLRS[0][layer]+
            (weight-MIN_WEIGHT)*(CLRS[1][layer]-CLRS[0][layer])/
            (MAX_WEIGHT-MIN_WEIGHT)
        ;
    }
    public int getWeight() { return weight; }
    public Color getColor() { return color; }    
}

class GrainFactory
{
    private static final int MAX_COUNT=300;
    private static final GrainFly[] grains=new GrainFly[MAX_COUNT];
    private static final Random rnd=new Random();
    static
    {
        for(int i=0;i<MAX_COUNT;++i) grains[i]=new GrainFly(rndWeight());
    }
    private static int rndWeight()
    {
        return 
            GrainFly.MAX_WEIGHT+
            rnd.nextInt(GrainFly.MAX_WEIGHT-GrainFly.MIN_WEIGHT)
        ;
    }
    public static int rndIndex() { return rnd.nextInt(MAX_COUNT); }
    public static GrainFly getGrain(int index) { return grains[index]; }
}
