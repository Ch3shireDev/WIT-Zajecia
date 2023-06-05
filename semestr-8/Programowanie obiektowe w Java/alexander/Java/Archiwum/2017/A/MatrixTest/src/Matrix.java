public class Matrix
{
   private double[][] tb;
   public Matrix(Matrix mat) throws Exception
   {
      int rows=mat.tb.length;
      if(rows<=0) tb=null;
      else
      {
         int cols=mat.tb[0].length;
         tb=new double[rows][cols];
         for(int r=0;r<rows;++r)
         {
            for(int c=0;c<cols;++c)
            {
               tb[r][c]=mat.tb[r][c];
            }
         }
      }      
   }
   public Matrix(int rows,int cols)
   {
      tb=new double[rows][cols];
   }
   public Matrix(String content) throws Exception
   {
      String[] tbs=content.split("\n+");
      int rows=tbs.length,cols=-1;
      if(rows==0) tb=null;
      else
      {
         for(int r=0;r<rows;++r)
         {
            String[] row=tbs[r].split("[\\s\t]+");
            if(cols<0)
            {
               cols=row.length;
               tb=new double[rows][cols];
            }
            else if(cols!=row.length) throw new Exception("Different row sizes");
            for(int c=0;c<cols;++c)
            {
               try
               {
                  tb[r][c]=Double.parseDouble(row[c]);
               }
               catch(Exception e)
               {
                  throw new Exception("mat["+r+"]["+c+"] `"+row[c]+"`: nie jest poprawną liczbą");
               }
            }
         }         
      }
   }
   @Override public String toString()
   {
      String content=new String();
      for(int r=0;r<tb.length;++r)
      {
         for(int c=0;c<tb[r].length;++c)
         {
            if(c>0) content+="\t";
            content+=tb[r][c];
         }
         content+="\n";
      }      
      return content;
   }
   public Matrix inv() throws Exception
   {
      int size=tb.length;
      if((size>0)&&(size==tb[0].length))
      {
         Matrix ret=new Matrix(size,size);
         Matrix cpy=new Matrix(this);
         for(int d=0;d<size;++d) ret.tb[d][d]=1;
         for(int d=0;d<size;++d)
         {            
            for(int y=0;y<size;++y)
            {
               if(y==d) continue;
               double mul=cpy.tb[y][d]/cpy.tb[d][d];
               for(int c=0;c<size;++c)
               {
                  cpy.tb[y][c]-=mul*cpy.tb[d][c];
                  ret.tb[y][c]-=mul*ret.tb[d][c];
               }
            }
         }
         for(int y=0;y<size;++y)
         {
            double mul=1/cpy.tb[y][y];
            for(int c=0;c<size;++c) ret.tb[y][c]*=mul;
         }
         return ret;
      }
      else throw new Exception("Need square matrix");
   }
}
