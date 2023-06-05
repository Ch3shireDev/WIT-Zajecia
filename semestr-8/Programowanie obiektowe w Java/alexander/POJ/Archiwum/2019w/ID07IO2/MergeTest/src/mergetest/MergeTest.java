package mergetest;

public class MergeTest 
{
    private static double[] tb=new double[]{7,3,6,1,4,8,2,5,9};
    public static void main(String[] args) 
    {
        Merge.Sort(tb,4);
        for(double v:tb) System.out.printf(" %.0f",v);
        System.out.println();
    }    
}
