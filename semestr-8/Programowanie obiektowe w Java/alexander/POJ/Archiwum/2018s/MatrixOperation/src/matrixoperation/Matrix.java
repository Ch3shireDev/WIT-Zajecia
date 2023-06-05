package matrixoperation;

public class Matrix 
{
   public static String toString(double[][] tb)
   {
      final StringBuilder sb=new StringBuilder();
      for(int r=0;r<tb.length;++r)
      {
         for(int c=0;c<tb.length;++c)
         {
            if(c>0) sb.append('\t');
            sb.append(tb[r][c]);            
         }
         sb.append(System.lineSeparator());
      }
      return sb.toString();
   }
   public static double[][] fromString(String str) throws IllegalArgumentException
   {
      double[][] tb;
      String[] rows=str.trim().split("\n");
      tb=new double[rows.length][];
      for(int r=0;r<rows.length;++r)
      {
         String[] cols=rows[r].split("\\s");
         if((r>0)&&(tb[0].length!=cols.length))
         {
            throw new IllegalArgumentException("Different columns lengths");
         }
         tb[r]=new double[cols.length];
         for(int c=0;c<cols.length;++c) tb[r][c]=Double.parseDouble(cols[c]);
      }
      return tb;
   }
   public static double[][] add(double[][] a,double[][] b) throws IllegalArgumentException
   {
      if((a.length!=b.length)||(a[0].length!=b[0].length)) 
       {
        throw new IllegalArgumentException("Bad matrix sizes");
       }
      double[][] tb=a.clone();
      for(int r=0;r<b.length;++r)
      {
         for(int c=0;c<b[0].length;++c) tb[r][c]+=b[r][c];
      }
      return tb;
   }
   public static double[][] sub(double[][] a,double[][] b) throws IllegalArgumentException
   {
      if((a.length!=b.length)||(a[0].length!=b[0].length)) 
       {
        throw new IllegalArgumentException("Bad matrix sizes");
       }
      double[][] tb=a.clone();
      for(int r=0;r<b.length;++r)
      {
         for(int c=0;c<b[0].length;++c) tb[r][c]-=b[r][c];
      }
      return tb;
   }
   public static double[][] mul(double[][] a,double[][] b) throws IllegalArgumentException
   {
      if(a[0].length!=b.length) 
       {
        throw new IllegalArgumentException("Bad matrix sizes");
       }
      double[][] tb=new double[a.length][b[0].length];
      for(int r=0;r<tb.length;++r)
      {
         for(int c=0;c<tb[0].length;++c)
         {
            double sum=0;
            for(int i=0;i<b.length;++i) sum+=a[r][i]*b[i][c];
            tb[r][c]=sum;
         }
      }
      return tb;
   }
   public static double[][] inv(double[][] m) throws IllegalArgumentException
   {
      if(m[0].length!=m.length) 
       {
        throw new IllegalArgumentException("Bad matrix size");
       }
      double[][] tb=m.clone();
      double[][] inv=new double[m.length][m[0].length];
      for(int z=0;z<m.length;++z)
      {
         inv[z][z]=1;
         double A=tb[z][z];
         for(int r=0;r<tb.length;++r)
         {
            if(r==z) continue;
            double B=tb[r][z];
            for(int c=0;c<tb[0].length;++c)
            {
               tb[r][c]-=B*tb[z][c]/A;
               inv[r][c]-=B*inv[z][c]/A;
            }
         }
      }
      for(int z=0;z<m.length;++z)
      {
         double A=tb[z][z];
         for(int c=0;c<tb[0].length;++c)
         {
            tb[z][c]/=A;
            inv[z][c]/=A;
         }
      }
      return inv;
   }
}
