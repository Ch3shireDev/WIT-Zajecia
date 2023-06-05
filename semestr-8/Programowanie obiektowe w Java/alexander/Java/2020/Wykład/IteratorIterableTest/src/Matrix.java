
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

   public static double[] multiply(double[] vec,double mul)
   {
      for(int i=0;i<vec.length;++i) vec[i]*=mul;
      return vec;
   }
}
