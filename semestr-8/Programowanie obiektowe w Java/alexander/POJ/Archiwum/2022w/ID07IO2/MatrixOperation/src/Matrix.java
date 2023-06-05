
import java.util.Locale;

public class Matrix
{
   private int colCount;
   private double[][] data;

   private Matrix(int rowCount,int colCount)
   {
      this.colCount=colCount;
      data=new double[rowCount][colCount];
   }

   public static Matrix parseMatrix(String text)
   {
      String[] rows=text.split("[\r\n\f]+");
      int rowCount=rows.length,colCount=0;
      Matrix m=null;
      for(int r=0;r<rowCount;++r)
      {
         String[] cols=rows[r].split("\\s+");
         if(r==0)
         {
            colCount=cols.length;
            m=new Matrix(rowCount,colCount);
         }
         else if(colCount!=cols.length) throw new IllegalArgumentException("Matrix is irregular");
         for(int c=0;c<colCount;++c) m.data[r][c]=Double.parseDouble(cols[c].replace(",","."));
      }
      return m;
   }

   public static Matrix add(final Matrix a,final Matrix b)
   {
      int rowCount=a.getRowCount(),colCount=a.getColCount();
      if((rowCount!=b.getRowCount())||(colCount!=b.getColCount()))
      {
         throw new IllegalArgumentException("Matrixes is not compatible");
      }
      Matrix m=new Matrix(rowCount,colCount);
      for(int r=0;r<rowCount;++r)
      {
         for(int c=0;c<colCount;++c)
         {
            m.data[r][c]=a.data[r][c]+b.data[r][c];
         }
      }
      return m;
   }

   public int getColCount() { return colCount; } // data.length>0?data[0].length:0
   public int getRowCount() { return data.length; }

   @Override public String toString()
   {
      StringBuilder sb=new StringBuilder();
      int rowCount=getRowCount();
      for(int r=0;r<rowCount;++r)
      {
         for(int c=0;c<colCount;++c)
         {
            if(c>0) sb.append('\t');
            sb.append(String.format("%.3f",data[r][c]));
         }
         sb.append(System.lineSeparator());
      }
      return sb.toString();
   }
}
