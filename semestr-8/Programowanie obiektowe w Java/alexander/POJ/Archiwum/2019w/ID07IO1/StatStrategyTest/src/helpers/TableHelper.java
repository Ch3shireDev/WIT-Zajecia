package helpers;

public abstract class TableHelper 
{
    public static double[][] SplitDouble2D(String text)
    {
        double[][] tb=null;
        String[] rows=text.split("[\r\b]+");
        for(int r=0;r<rows.length;++r)
        {
            String[] cols=rows[r].split("[\\s]+");
            if(tb==null) tb=new double[rows.length][cols.length];
            else if(cols.length!=tb[0].length) return null;
            for(int c=0;c<cols.length;++c)
            {
                try { tb[r][c]=Double.parseDouble(cols[c]); }
                catch(NumberFormatException e) { return null; }
            }            
        }
        return tb;
    }
}
