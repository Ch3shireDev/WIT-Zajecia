public class Matrix
{
   private double[][] m;
   private int rowcount,colcount;
   public Matrix(int rowcount,int colcount)
   {
      this.rowcount=rowcount;
      this.colcount=colcount;
      m=new double[rowcount][colcount];
   }
   public static Matrix parseMatrix(String data) throws Exception
   {
      String[] rows=data.split("[\r\n]+");
      int rowcount=rows.length,colcount=0;
      Matrix mat=null;
      for(int r=0;r<rowcount;++r)
      {
         String[] cols=rows[r].split("[\\s\t]+");
         if(r==0)
         {
            colcount=cols.length;
            mat=new Matrix(rowcount,colcount);
         }
         else if(colcount!=cols.length) throw new Exception("Not regular matrix");
         for(int c=0;c<colcount;++c) mat.m[r][c]=Double.parseDouble(cols[c]);
      }
      return mat;
   }

   public static Matrix add(Matrix a,Matrix b) throws Exception
   {
      int rowcount=a.rowcount,colcount=a.colcount;
      if(rowcount!=b.rowcount) throw new Exception("Different row count");
      if(colcount!=b.colcount) throw new Exception("Different column count");
      Matrix mat=new Matrix(rowcount,colcount);
      for(int r=0;r<rowcount;++r)
      {
         for(int c=0;c<colcount;++c) mat.m[r][c]=a.m[r][c]+b.m[r][c];
      }
      return mat;
   }

   public static Matrix sub(Matrix a,Matrix b) throws Exception
   {
      int rowcount=a.rowcount,colcount=a.colcount;
      if(rowcount!=b.rowcount) throw new IllegalArgumentException("Different row count");
      if(colcount!=b.colcount) throw new IllegalArgumentException("Different column count");
      Matrix mat=new Matrix(rowcount,colcount);
      for(int r=0;r<rowcount;++r)
      {
         for(int c=0;c<colcount;++c) mat.m[r][c]=a.m[r][c]-b.m[r][c];
      }
      return mat;
   }

   public static Matrix mul(Matrix a,Matrix b) throws Exception
   {
      int rowcount=a.rowcount,colcount=b.colcount,height=a.colcount;
      if(height!=b.rowcount) throw new IllegalArgumentException("Unompatible matrixes");
      Matrix mat=new Matrix(rowcount,colcount);
      for(int r=0;r<rowcount;++r)
      {
         for(int c=0;c<colcount;++c)
         {
            for(int h=0;h<height;++h) mat.m[r][c]+=a.m[r][h]*b.m[h][c];
         }
      }
      return mat;
   }

   @Override public String toString()
   {
      StringBuilder sb=new StringBuilder();
      for(int r=0;r<rowcount;++r)
      {
         for(int c=0;c<colcount;++c)
         {
            if(c>0) sb.append('\t');
            sb.append(String.format("%.3f",m[r][c]));
         }
         sb.append(System.lineSeparator());
      }
      return sb.toString();
   }
}
