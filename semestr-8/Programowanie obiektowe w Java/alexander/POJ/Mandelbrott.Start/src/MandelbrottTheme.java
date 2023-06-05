
public interface MandelbrottTheme
{
   public default int getSize() { return getColorsTable().length; }
   public default int[] getColor(int pos) { return getColorsTable()[pos]; }
   public int[][] getColorsTable();
}
