import java.security.InvalidParameterException;

public class Matrix
{
    private double[][] matrix;

    public Matrix(String text){
        this.matrix = parseMatrix(text);
    }
    public Matrix(int rowCount, int colCount){
        this.matrix = new double[rowCount][colCount];
    }
    public int rowCount(){
        return matrix.length;
    }
    public int colCount(){
        return rowCount() > 0 ? matrix[0].length : 0;
    }
    public double get(int row, int col)
    {
        return matrix[row][col];
    }
    public void set (int row, int col, double value)
    {
        matrix[row][col]=value;
    }
    public static Matrix gauss(Matrix A, Matrix B){
        int rowLength = A.rowCount();
        if (rowLength != B.rowCount()){
            throw new InvalidParameterException("Incompatible matrix sizes");
        }
        if (rowLength != A.colCount()){
            throw new InvalidParameterException("First matrix must be square");
        }
        int addLength = B.colCount();
        int colLength = rowLength + addLength;
        Matrix C = new Matrix(rowLength,colLength);

        for (int r = 0; r < rowLength; ++r){
            for (int c = 0; c < rowLength; ++c){
                C.set(r, c, A.get(r, c));
            }
            for (int c = 0; c < addLength; ++c){
                C.set(r, c + rowLength, B.get(r, c));
            }
        }

         for (int d = 0; d < rowLength; ++d){
            double div = C.get(d, d);
            for (int r = 0; r < rowLength; ++r){
               if(r==d) continue;
               double mul = C.get(r, d);
               for (int c = 0; c < colLength; ++c){
                  double val=C.get(r, c);
                  val -= C.get(d, c) *mul/div;
                  C.set(r, c, val);
               }
            }
         }
        for (int d = 0; d < rowLength; ++d){
            double div = C.get(d, d);
            for (int c = 0; c < addLength; ++c){
                double val=C.get(d, c + rowLength) / div;
                C.set(d, c /*brakowało tego  + rowLength*/ + rowLength, val);
            }
        }
        

        Matrix X = new Matrix(rowLength, addLength);
        for (int r = 0; r < rowLength; ++r){
            for (int c = 0; c < addLength; ++c){
                X.set(r, c, C.get(r, c + rowLength));
            }
        }
        return X;
    }

    public static Matrix multiply(Matrix A, Matrix B){
        int heightLength = B.rowCount();
        if (heightLength != A.colCount()){
            throw new InvalidParameterException("Incompatible matrix sizes");
        }
        int rowLength = A.rowCount();
        int colLength = B.colCount();

        Matrix C = new Matrix(rowLength, colLength);
        for (int r = 0; r < rowLength; ++r)
        {
            for (int c = 0; c < colLength; ++c)
            {
                double sum = 0;
                for (int h = 0; h < heightLength; ++h)
                {
                    sum += A.get(r, h)*B.get(h, c);
                }
                C.set(r, c, sum);
            }

        }
        return C;
    }

    private static String matrixToString(double[][] matrix){
        StringBuilder sb = new StringBuilder();
        int rowLength = matrix.length;
        int colLength = rowLength > 0 ? matrix[0].length : 0;
        for (int r = 0; r < rowLength; ++r)
        {
            for (int c = 0; c < colLength; ++c)
            {
                if (c > 0){
                    sb.append('\t');
                }
                sb.append(String.format("%.3f", matrix[r][c]));
            }
            sb.append(System.lineSeparator());
        }
        return sb.toString();
    }

   private static double[][] parseMatrix (String text)
   {
        String[] Rows = text.split("[\r\n]+");
        int rowLength = Rows.length;
        int colLength = 0;
        String[][] Cells = new String[rowLength][];
        for (int r = 0; r < rowLength; ++r)
        {
            Cells[r] = Rows[r].split("[\t\\s]+");
            if (r==0)
            {
                colLength = Cells[r].length;
            }
            else if (colLength != Cells[r].length)
            {
                throw new InvalidParameterException("Matrix must be regular");
            }
        }
        double[][] m = new double[rowLength][colLength];
        for (int r = 0; r < rowLength; ++r)
        {
            for (int c = 0; c < colLength; ++c)
            {
                m[r][c] = Double.parseDouble(Cells[r][c].replace(',', '.'));
            }
        }
        return m;
   }

    @Override
    public String toString() {
        return matrixToString(matrix);
    }
}