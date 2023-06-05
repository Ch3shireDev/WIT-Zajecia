import java.security.InvalidParameterException;

public class Matrix
{
   private double[][] tb;
   public Matrix(double[][] tb) { this.tb=tb; }
   public Matrix(int rows,int cols) { tb=new double[rows][cols]; }
   public Matrix(String text) { tb=Split(text); }
   public int getRows() { return tb.length; }
   public int getCols() { return tb[0].length; }
   public double get(int y,int x) { return tb[y][x]; }
   public void set(int y,int x,double value) { tb[y][x]=value; }

   public static Matrix multiply(Matrix a,Matrix b)
   {
      int ysize=a.getRows();
      int xsize=b.getCols();
      int zsize=b.getRows();
      if(a.getCols()!=zsize) throw new InvalidParameterException("Matrixes cant be multiply");
      double[][] tb=new double[ysize][xsize];
      for(int y=0;y<ysize;++y) for(int x=0;x<xsize;++x) for(int z=0;z<zsize;++z) tb[y][x]+=a.tb[y][z]*b.tb[z][x];
      return new Matrix(tb);
   }

   @Override public String toString()
   {
      StringBuilder sb=new StringBuilder();
      for(int r=0;r<tb.length;++r)
      {
         int colcount=tb[r].length;
         for(int c=0;c<colcount;++c)
         {
            if(c>0) sb.append('\t');
            sb.append(String.format("%7.2f",tb[r][c]));
         }
         sb.append(System.lineSeparator());
      }
      return sb.toString();
   }

   private static String[] Split(String text,String Delimeters)
   {
      return text.trim().split("["+Delimeters+"]+");
   }

   private static String[] SplitRows(String text) { return Split(text,"\r\n"); }
   private static String[] SplitCols(String text) { return Split(text,"\\s\t"); }

   private static double[][] Split(String text)
   {
      text=text.trim();
      if(text.length()<=0) throw new InvalidParameterException("Empty matrix");
      final String[] rows=SplitRows(text);
      int rowcount=rows.length;
      double[][] tb=new double[rowcount][];
      int colcount=0;
      for(int r=0;r<rowcount;++r)
      {
         final String[] cols=SplitCols(rows[r]);
         if(r==0) colcount=cols.length;
         else if(colcount!=cols.length) throw new InvalidParameterException("Different columns size");
         tb[r]=new double[colcount];
         for(int c=0;c<colcount;++c)
         {
            try { tb[r][c]=Double.parseDouble(cols[c]); }
            catch(NumberFormatException ex) { throw new InvalidParameterException("Not number"); }
         }
      }
      return tb;
   }
}
