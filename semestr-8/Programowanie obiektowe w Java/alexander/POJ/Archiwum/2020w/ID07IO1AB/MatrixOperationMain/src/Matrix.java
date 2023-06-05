
import java.security.InvalidParameterException;

public class Matrix
{
   private final double[][] data;
   //*///
   private int colCount;
   public int getColCount() { return colCount; }
   private void setColCount(int colCount) { this.colCount=colCount; }
   /*/
   public int getColCount() { return (((data!=null)&&(data.length>0))?data[0].length:0); }
   private void setColCount(int colCount) {}
   //*///
   public int getRowCount() { return data.length; }
   public double getValue(int r,int c) { return data[r][c]; }
   public void setValue(int r,int c,double v) { data[r][c]=v; }

   //public static Matrix parseMatrixOrNull(String src) {}
   //public static Matrix parseMatrix(String src) {}

   public Matrix(int rowCount,int colCount)
   {
      setColCount(colCount);
      data=new double[rowCount][colCount];
   }
   public Matrix(double[][] data)
   {
      if(data==null) data=new double[0][0];
      this.data=data;
      setColCount(data.length>0?data[0].length:0);
   }

   public static Matrix addOrNull(Matrix a,Matrix b)
   {
      int colCount=a.getColCount();
      int rowCount=a.getRowCount();
      if((colCount!=b.getColCount())||(rowCount!=b.getRowCount())) return null;
      Matrix ret=new Matrix(rowCount,colCount);
      // y,x r,c row,col
      for(int r=0;r<rowCount;++r)
      {
         for(int c=0;c<colCount;++c)
         {
            ret.setValue(r,c,a.getValue(r,c)+b.getValue(r,c));
         }
      }
      return ret;
   }
   public static Matrix add(Matrix a,Matrix b) throws InvalidParameterException
   {
      Matrix r=addOrNull(a,b);
      if(r==null)
      {
         throw new InvalidParameterException("Uncompatible matrix sizes");
      }
      return r;
   }

   @Override public String toString()
   {
      StringBuilder sb=new StringBuilder();
      int colCount=getColCount();
      int rowCount=getRowCount();
      for(int r=0;r<rowCount;++r)
      {
         for(int c=0;c<colCount;++c)
         {
            if(c>0) sb.append('\t');
            sb.append(getValue(r,c));
         }
         sb.append(System.lineSeparator());
      }
      return sb.toString();
   }

}
