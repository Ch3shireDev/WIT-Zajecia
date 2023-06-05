public class Matrix
{
   private double[][] m;
   private int rows,cols;
   public Matrix(int rows,int cols)
   {
      this.rows=rows;
      this.cols=cols;
      m=new double[rows][cols];
   }

   public double get(int r,int c) { return m[r][c]; }
   public void set(int r,int c,double value) { m[r][c]=value; }

   // Integer mx=9; mx.toString(); ((Integer)mx).toString(); Integer(mx).toString();
   @Override public String toString()
   {
      final StringBuilder sb=new StringBuilder();
      for(int r=0;r<rows;++r)
      {
         for(int c=0;c<cols;++c)
         {
            if(c>0) sb.append(' ');
            sb.append(String.format("%8.3f",m[r][c]));
         }
         sb.append(System.lineSeparator());
      }
      return sb.toString();
   }

   // int x=Integer.ParseInteger(TbValue.getText());
   // Matrix m=Matrix.parseMatrix(TbMatrixA.getText());
   public static Matrix parseMatrix(String text)
   {
      String[] Rows=text.trim().replace(',','.').split("[\r\n\f]+");
      int rows=Rows.length,cols=0;
      Matrix m=null;
      for(int r=0;r<rows;++r)
      {
         String[] Cols=Rows[r].trim().split("[\\s;]+");
         if(r==0)
         {
            cols=Cols.length;
            m=new Matrix(rows,cols);
         }
         else if(cols!=Cols.length) throw new IllegalArgumentException("Matrix must be Regular");
         for(int c=0;c<cols;++c)
         {
            m.set(r,c,Double.parseDouble(Cols[c]));
         }
      }
      return m;
   }
}
