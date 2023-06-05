import java.security.InvalidParameterException;

public class Matrix {
    private double[][] tb;
    private Matrix(double[][] tb) {
        this.tb = tb;
    }
    public Matrix(int rows, int cols) {
        tb = new double[rows][cols];
    }
    public int rows() {
        return tb.length;
    }
    public int cols() {
        return tb.length > 0 ? tb[0].length : 0;
    }
    public static Matrix parseMatrix(String source) {
        String[] Rows = source.split("[\r\n]+");
        int rows = Rows.length;
        int cols = 0;
        String[][] cells = new String[rows][];
        for (int r = 0; r < rows; ++r) {
            cells[r] = Rows[r].split("[\t\\s]+");
            if (r == 0) {
                cols = cells[r].length;
            } else if (cols != cells[r].length) {
                throw new InvalidParameterException("Nieregularna tablica.");
            }
        }
        double[][] m = new double[rows][cols];
        for (int r = 0; r < rows; ++r) {
            for (int c = 0; c < cols; ++c) {
                m[r][c] = Double.parseDouble(cells[r][c].replace(',','.'));
            }
        }
        return new Matrix(m);
    }
    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        int rows = this.rows();
        int cols = this.cols();
        for (int r = 0; r < rows; ++r) {
            for (int c = 0; c < cols; ++c) {
                if (c > 0) {
                    sb.append('\t');
                }
                sb.append(String.format("%.2f", tb[r][c]));
            }
            sb.append(System.lineSeparator());
        }
        return sb.toString();
    }
    public static Matrix multiply(Matrix a, Matrix b) {
        int height = b.rows();
        if (height != a.cols()) throw new InvalidParameterException("Niepasujace rozmiary.");
        
        int rows = a.rows();
        int cols = b.cols();
        
        double[][] m= new double[rows][cols];
        
        for (int r=0;r<rows;++r)
        {
            for (int c=0;c<cols;++c)
            {
                double sum=0;
                for(int h = 0; h < height; ++h)
                {
                    sum+= a.tb[r][h]* b.tb[h][c];
                }
                m[r][c]=sum;
            }
        }
        return new Matrix(m);
    }
    public static Matrix gauss(Matrix a, Matrix b) {
        int rows = a.rows();
        if (rows != b.rows()) throw new InvalidParameterException("Niepasujace rozmiary.");
        int cols = a.cols();
        int add = b.cols();
        int size = cols+add;
        
        double[][] m = new double [rows][size];
        for (int r = 0; r < rows; ++r) {
            for (int c = 0; c < cols; ++c) {
                m[r][c] = a.tb[r][c];
            }
            for (int c = 0; c < add; ++c) {
                m[r][c+cols] = b.tb[r][c];
            }
        }        
        for (int d = 0; d < rows; ++d) {
            double div = m[d][d];
            for (int r = 0; r < rows; ++r) {
                if(r != d) {
                    double mul = m[r][d];
                    for (int c = 0; c < size; ++c) {
                        m[r][c] -= m[d][c]*mul / div;
                    }
                }
            }
        }
        for (int r = 0; r < rows; ++r) {
            double div = m[r][r];
            for (int c = 0; c < add; ++c) {
                m[r][c] /= div;
            }
        }
        double[][] ret = new double[rows][add];
         for (int r = 0; r < rows; ++r) {
            for (int c = 0; c < add; ++c) {
                ret[r][c] = m[r][c+cols];
            }
        }
        return new Matrix(ret);
    }
}
