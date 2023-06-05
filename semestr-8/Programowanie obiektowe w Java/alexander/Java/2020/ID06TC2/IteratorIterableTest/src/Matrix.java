
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

   public static double[][] multiply(double[][] A,double[][] B)
   {
      int rows=A.length;
      int cols=B[0].length;
      int height=A[0].length;
      if(height!=B.length) throw new InvalidParameterException("Incomaptible matrix sizes");
      double[][] C=new double[rows][cols];
      for(int r=0;r<rows;++r)
      {
         for(int c=0;c<cols;++c)
         {
            double sum=0;
            for(int h=0;h<height;++h) sum+=A[r][h]*B[h][c];
            C[r][c]=sum;
         }
      }
      return C;
   }
   
   public static double[][] gauss(double[][] M,double[][] Y)
   {
      int size=M.length;
      if(size!=M[0].length) throw new InvalidParameterException("Matrix must be square");
      if(size!=Y.length) throw new InvalidParameterException("Incomaptible matrix sizes");
      int exts=Y[0].length;
      int cols=size+exts;
      double[][] C=new double[size][cols];
      for(int r=0;r<size;++r) for(int c=0;c<size;++c) C[r][c]=M[r][c];
      for(int r=0;r<size;++r) for(int c=0;c<exts;++c) C[r][size+c]=Y[r][c];
      for(int d=0;d<size;++d) // diagonal - przekątna
      {
         double div=C[d][d];
         for(int r=0;r<size;++r)
         {
            if(r==d) continue;
            double mul=C[r][d]/div;
            for(int c=0;c<cols;++c) C[r][c]-=C[d][c]*mul;
         }
         for(int c=0;c<cols;++c) C[d][c]/=div;
      }
      double[][] R=new double[size][exts];
      for(int r=0;r<size;++r) for(int c=0;c<exts;++c) R[r][c]=C[r][size+c];
      return R;
   }
   
   public static double[] multiply(double[] vec,double mul)
   {
      for(int i=0;i<vec.length;++i) vec[i]*=mul;
      return vec;
   }
}
