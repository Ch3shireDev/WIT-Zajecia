
import java.security.InvalidParameterException;
import java.util.ArrayList;

public class Matrix
{
   private double[][] tb;
   public Matrix(double[][] tb) { this.tb=tb; }
   public Matrix(String text) { tb=Split(text); }
   public int getRows() { return tb.length; }
   public int getCols() { return tb[0].length; }
   public double get(int y,int x) { return tb[y][x]; }
   public void set(int y,int x,double value) { tb[y][x]=value; }

   public static Matrix multiply(Matrix a,Matrix b)
   {
      int zsize=a.getCols();
      if(zsize!=b.getRows()) throw new InvalidParameterException("Matrixes cant be multiplied");
      int ysize=a.getRows();
      int xsize=b.getCols();
      double[][] tb=new double[ysize][xsize];
      for(int y=0;y<ysize;++y)
      {
         for(int x=0;x<xsize;++x)
         {
            for(int z=0;z<zsize;++z)
            {
               tb[y][x]+=a.tb[y][z]*b.tb[z][x];
            }
         }
      }
      return new Matrix(tb);
   }

   @Override public String toString()
   {
      int ysize=getRows();
      int xsize=getCols();
      StringBuilder sb=new StringBuilder();
      for(int y=0;y<ysize;++y)
      {
         for(int x=0;x<xsize;++x)
         {
            if(x>0)  sb.append("\t");
            sb.append(String.format("%8.2f",tb[y][x]));
         }
         sb.append(System.lineSeparator());
      }
      return sb.toString();
   }

   private static ArrayList<String> Split(String text,String Delimeters)
   {
      final ArrayList<String> rows=new ArrayList<>();
      for(String str:text.trim().split(Delimeters))
      {
         final String tr=str.trim();
         if(tr.length()>0) rows.add(tr);
      }
      return rows;
   }

   private static ArrayList<String> SplitRows(String text) { return Split(text,"[\r\n]"); }
   private static ArrayList<String> SplitCols(String text) { return Split(text,"[\\s\t]"); }

   private static double[][] Split(String text)
   {
      double[][] tb=null;
      ArrayList<ArrayList<String>> content=new ArrayList<>();
      SplitRows(text).forEach((row) -> content.add(SplitCols(row)));
      int rows=content.size();
      if(rows<=0) throw new InvalidParameterException("0 size matrix");
      int cols=content.get(0).size();
      tb=new double[rows][cols];
      for(int r=0;r<rows;++r)
      {
         final ArrayList<String> row=content.get(r);
         if(row.size()!=cols) throw new InvalidParameterException("Difference columns size");
         for(int c=0;c<cols;++c)
         {
            final String col=row.get(c);
            try { tb[r][c]=Double.parseDouble(col); }
            catch(NumberFormatException ex)
            {
               throw new InvalidParameterException(String.format("(%d,%d) -> %s not number",r,c,col));
            }
         }
      }
      return tb;
   }
}
