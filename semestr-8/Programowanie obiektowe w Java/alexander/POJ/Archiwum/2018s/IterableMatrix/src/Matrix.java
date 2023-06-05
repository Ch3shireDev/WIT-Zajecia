
import java.util.Iterator;
import java.util.NoSuchElementException;

public class Matrix implements Iterable<Matrix.Cell>
{
   private int rowcount,colcount;
   private double[] tb;
   public Matrix(int rowcount,int colcount)
   {
      this.rowcount=rowcount;
      this.colcount=colcount;
      tb=new double[rowcount*colcount];
   }
   public int getRowCount() { return rowcount; }
   public int getColCount() { return colcount; }
   public Cell cell(int r,int c) { return new Cell(r*colcount+c); }
   public Slice slice(int start,int count,int step) { return new Slice(start,count,step); }
   public Slice rowslice(int r) { return slice(r*colcount,1,colcount); }
   public Slice colslice(int c) { return slice(c,colcount,rowcount); }
   public @Override Iterator<Cell> iterator() { return slice(0,tb.length,1).iterator(); }
   public Iterator<Cell> row(int r) { return rowslice(r).iterator(); }
   public Iterator<Cell> col(int c) { return colslice(c).iterator(); }
   public Slice rows() { return colslice(0); }
   public Slice cols() { return rowslice(0); }
   public class Cell
   {
      private int idx;
      public Cell(int idx) { this.idx=idx; }
      public void set(double value) { tb[idx]=value; }
      public double get() { return tb[idx]; }
      public Slice rows() { return colslice(idx%colcount); }
      public Slice cols() { return rowslice(idx/colcount); }
   }
   public class Slice implements Iterable<Cell>
   {
      private int start,count,step;
      Slice(int start,int count,int step)
      {
         this.start=start;
         this.count=count;
         this.step=step;
      }
      public @Override Iterator<Cell> iterator() { return new SliceIterator(); }
      public class SliceIterator implements Iterator<Cell>
      {
         private int current;
         public SliceIterator() { current=0; }
         public @Override boolean hasNext() { return current<count; }
         public @Override Cell next() 
         {
            if(!hasNext()) throw new NoSuchElementException();
            return new Cell(start+step*(current++));
         }
      }
   }
}
