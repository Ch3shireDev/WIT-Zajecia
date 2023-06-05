
import java.security.InvalidParameterException;

public class Matrix
{
   public static double[] parseColumn(String text)
   {
      String[] rows=text.split("[\r\n]+");
      double[] tb=new double[rows.length];
      for(int i=0;i<tb.length;++i) tb[i]=Double.parseDouble(rows[i].replace(',','.'));
      return tb;
   }

   public static double[] parseRow(String text)
   {
      String[] cols=text.split("[\t\\s]+");
      double[] tb=new double[cols.length];
      for(int i=0;i<tb.length;++i) tb[i]=Double.parseDouble(cols[i].replace(',','.'));
      return tb;
   }

   public static double[][] parseMatrix(String text)
   {
      String[] rows=text.split("[\r\n]+");
      double[][] matrix=new double[rows.length][];
      for(int i=0;i<rows.length;++i)
      {
         matrix[i]=parseRow(rows[i]);
         if((i>0)&&(matrix[0].length!=matrix[i].length))
         {
            throw new InvalidParameterException("Different rows size");
         }
      }
      return matrix;
   }

   public static String ColumnToString(double[] column)
   {
      StringBuilder sb=new StringBuilder();
      for(double value:column)
      {
         sb.append(value);
         sb.append(System.lineSeparator());
      }
      return sb.toString().replace('.',',');
   }

   public static String RowToString(double[] row)
   {
      StringBuilder sb=new StringBuilder();
      boolean first=true;
      for(double value:row)
      {
         if(first) first=false;
         else sb.append('\t');
         sb.append(value);
      }
      return sb.toString().replace('.',',');
   }

   public static String MatrixToString(double[][] matrix)
   {
      StringBuilder sb=new StringBuilder();
      for(double[] row:matrix)
      {
         boolean first=true;
         for(double value:row)
         {
            if(first) first=false;
            else sb.append('\t');
            sb.append(value);
         }
         sb.append(System.lineSeparator());
      }
      return sb.toString().replace('.',',');
   }
   public static double[][] gauss(double[][] M,double[][] Y)
   {
      int rows=M.length;
      if(rows!=M[0].length) throw new InvalidParameterException("Matrix must be square");
      if(rows!=Y.length) throw new InvalidParameterException("Incompatible table sizes");
      int exts=Y[0].length;
      int cols=rows+exts;
      double[][] MY=new double[rows][cols];
      for(int r=0;r<rows;++r) for(int c=0;c<rows;++c)  MY[r][c]=M[r][c];
      for(int r=0;r<rows;++r) for(int c=0;c<exts;++c)  MY[r][c+rows]=Y[r][c];
      for(int d=0;d<rows;++d) 
      {
         double div=MY[d][d];
         for(int r=0;r<rows;++r)
         {
            if(r==d) continue;
            double mul=MY[r][d]/div;
            for(int c=0;c<cols;++c) MY[r][c]-=MY[d][c]*mul;
         }
         for(int c=0;c<cols;++c)  MY[d][c]/=div;
      }      
      double[][] X=new double[rows][exts];
      for(int r=0;r<rows;++r) for(int c=0;c<exts;++c)  X[r][c]=MY[r][c+rows];
      return X;
   }
   public static double[][] multiply(double[][] M,double[][] X)
   {
      int rows=M.length;
      int cols=X[0].length;
      int height=X.length;
      if(height!=M[0].length) throw new InvalidParameterException("Incompatible table sizes");
      double[][] Y=new double[rows][cols];
      for(int r=0;r<rows;++r)
      {
         for(int c=0;c<cols;++c)
         {
            double sum=0;
            for(int h=0;h<height;++h) sum+=M[r][h]*X[h][c];
            Y[r][c]=sum;
         }
      }
      return Y;
   }
   public static double[] multiply(double[] vec,double mul)
   {
      for(int i=0;i<vec.length;++i) vec[i]*=mul;
      return vec;
   }
}
