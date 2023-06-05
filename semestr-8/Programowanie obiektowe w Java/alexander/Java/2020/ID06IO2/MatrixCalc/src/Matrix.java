
import java.security.InvalidParameterException;

public class Matrix {

   private double[][] matrix;

   public Matrix(String text) {
      this.matrix = parseMatrix(text);
   }

   public Matrix(int r, int c) {
      this.matrix = new double[r][c];
   }

   @Override
   public String toString() {
      return matrixToString(matrix);
   }

   public static double[][] parseMatrix(String text) {
      String[] rows = text.split("[\r\n]+");
      int rowCount = rows.length;
      String[][] cels = new String[rowCount][];
      int colCount = 0;

      for (int i = 0; i < rowCount; ++i) {
         cels[i] = rows[i].split("[\t\\s]+");
         if (i == 0) {
            colCount = cels[i].length;
         } else if (colCount != cels[i].length) {
            throw new InvalidParameterException("Not regular matrix.");
         }
      }
      double[][] matrix = new double[rowCount][colCount];

      for (int r = 0; r < rowCount; ++r) {
         for (int c = 0; c < colCount; ++c) {
            matrix[r][c] = Double.parseDouble(cels[r][c].replace(',', '.'));
         }
      }
      return matrix;
   }

   public int rowCount() {
      return matrix.length;
   }

   public int colCount() {
      return rowCount() > 0 ? matrix[0].length : 0;
   }

   public double get(int r, int c) {
      return matrix[r][c];
   }

   public void set(int r, int c, double val) {
      matrix[r][c] = val;
   }

   public static Matrix Multiply(Matrix A, Matrix B) {
      int heightCount = B.rowCount();
      if (heightCount != A.colCount()) {
         throw new InvalidParameterException("Incompatible matrix");
      }
      int rowCount = A.rowCount();
      int colCount = B.colCount();

      Matrix C = new Matrix(rowCount, colCount);

      for (int r = 0; r < rowCount; ++r) {

         for (int c = 0; c < colCount; ++c) {
            double sum = 0;

            for (int h = 0; h < heightCount; h++) {
               sum += A.get(r, h) * B.get(h, c);
            }
            C.set(r, c, sum);
         }
      }
      return C;
   }

   public static Matrix Gauss(Matrix A, Matrix B) {
      int rowCount = A.rowCount();
      if (rowCount != A.colCount()) {
         throw new InvalidParameterException("First matrix must be square");
      }
      if (rowCount != B.rowCount()) {
         throw new InvalidParameterException("Second matrix must have same rows count");
      }
      int addCount = B.colCount();
      int colCount = rowCount + addCount;
      Matrix C = new Matrix(rowCount, colCount);
      for (int r = 0; r < rowCount; ++r) {
         for (int c = 0; c < rowCount; ++c) {
            C.set(r, c, A.get(r, c));
         }
         for (int c = 0; c < addCount; ++c) {
            C.set(r, c + rowCount, B.get(r, c));
         }
      }
      
      for (int d = 0; d < rowCount; ++d) {
         double div = C.get(d, d);
         for (int r = 0; r < rowCount; ++r) {
            if (d == r) {
               continue;
            }
            double mul = C.get(r, d);
            for (int c = 0; c < colCount; ++c) {
               C.set(r, c, C.get(r, c) - C.get(d, c) * mul / div);
            }
         }
      }
      for (int r = 0; r < rowCount; ++r) {
         double div = C.get(r, r);
         for (int c = 0; c < addCount; ++c) {
            C.set(r, c + rowCount, C.get(r, c /* brakowało tego + rowCount*/+ rowCount) / div);
         }
      }
      
      Matrix X = new Matrix(rowCount, addCount);
      for (int r = 0; r < rowCount; ++r) {
         for (int c = 0; c < addCount; ++c) {
            X.set(r, c, C.get(r, c + rowCount));
         }
      }
      return X;
   }

   public static String matrixToString(double[][] matrix) {
      StringBuilder sb = new StringBuilder();

      int rowCount = matrix.length;
      int colCount = rowCount > 0 ? matrix[0].length : 0;

      for (int r = 0; r < rowCount; ++r) {
         for (int c = 0; c < colCount; ++c) {
            if (c > 0) {
               sb.append('\t');
            }
            sb.append(String.format("%.3f", matrix[r][c]));
         }
         sb.append(System.lineSeparator());
      }
      return sb.toString();
   }
}
