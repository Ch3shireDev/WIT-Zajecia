public class Matrix
{
   private int rowCount,colCount;
   private double[] data;
   public Matrix(int rowCount,int colCount)
   {
      this.rowCount=rowCount;
      this.colCount=colCount;
      data=new double[rowCount*colCount];
   }
   double get(int y,int x)
   {
      return data[y*colCount+x];
   }
   void set(int y,int x,double value)
   {
      data[y*colCount+x]=value;
   }
   static Matrix parseMatrix(String text)
   {
      String[] rows=text.split("[\r\n]+");
      int rowCount=rows.length,colCount=0;
      Matrix m=null;
      for(int r=0;r<rowCount;++r)
      {
         String[] cols=rows[r].split("[\t\\s]+");
         if(r==0)
         {
            colCount=cols.length;
            m=new Matrix(rowCount,colCount);
         }
         else if(colCount!=cols.length) throw new IllegalArgumentException("Matrix must be regular");
         for(int c=0;c<colCount;++c) m.set(r,c,Double.parseDouble(cols[c]));
      }
      return m;
   }
   static Matrix add(final Matrix a,final Matrix b)
   {
      int rowCount=a.rowCount,colCount=a.colCount;
      if((rowCount!=b.rowCount)||(colCount!=b.colCount)) throw new IllegalArgumentException("Matrixes size must be equal");
      Matrix m=new Matrix(rowCount,colCount);
      for(int r=0;r<rowCount;++r)
      {
         for(int c=0;c<colCount;++c)
         {
            double av=a.get(r,c),bv=b.get(r,c);
            m.set(r,c,av+bv);
         }
      }
      return m;
   }

   @Override public String toString()
   {
      StringBuilder sb=new StringBuilder();
      for(int r=0;r<rowCount;++r)
      {
         for(int c=0;c<colCount;++c)
         {
            if(c>0) sb.append('\t');
            sb.append(String.format("%.3f",get(r,c)));
         }
         sb.append(System.lineSeparator());
      }
      return sb.toString();
   }

}
