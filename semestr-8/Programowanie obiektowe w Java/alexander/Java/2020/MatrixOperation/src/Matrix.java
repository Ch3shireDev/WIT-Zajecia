public class Matrix
{
   public double[][] parseMatrix(String source)
   {
      String[] rows=source.split("[\r\n]+");
      int rowsCount=rows.length;
      String[][] cells = new String[rowsCount][];
      for(int r=0;r<rowsCount;++r) cells[r]=rows[r].split("[\\s\t]+");
      return null;
   }
}
