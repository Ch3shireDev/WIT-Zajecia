using System.Globalization;

namespace OperacjeMacierzoweLibrary;

public class MatrixService
{
    public Matrix Deserialize(string str)
    {
        var rows = str.Split('\n')
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(x => x.Trim())
                .ToArray()
            ;

        var tab = new double[rows.Length, rows[0].Split(' ').Length];

        for (var i = 0; i < rows.Length; i++)
        {
            var columns = rows[i].Split(' ');

            if (columns.Length != tab.GetLength(1))
                throw new ArgumentException("Nieprawidłowy format macierzy");

            for (var j = 0; j < columns.Length; j++)
            {
                tab[i, j] = double.Parse(columns[j]);
            }
        }

        return new Matrix(tab);
    }

    public string Serialize(Matrix matrix)
    {
        return string.Join("\n", matrix
            .GetEnumerator().Select(row => string.Join(" ", row
                .Select(x => x.ToString("N3", CultureInfo.InvariantCulture))
            )));
    }

    public Matrix Add(Matrix matrix1, Matrix matrix2)
    {
        AssertEqualDimensions(matrix1, matrix2);

        var tab = new double[matrix1.Rows, matrix1.Columns];

        for (var i = 0; i < matrix1.Rows; i++)
        {
            for (var j = 0; j < matrix1.Columns; j++)
            {
                tab[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return new Matrix(tab);
    }

    public Matrix Subtract(Matrix matrix1, Matrix matrix2)
    {
        AssertEqualDimensions(matrix1, matrix2);

        var tab = new double[matrix1.Rows, matrix1.Columns];

        for (var i = 0; i < matrix1.Rows; i++)
        {
            for (var j = 0; j < matrix1.Columns; j++)
            {
                tab[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return new Matrix(tab);
    }

    private void AssertEqualDimensions(Matrix matrix1, Matrix matrix2)
    {
        if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
        {
            throw new ArgumentException("Macierze muszą mieć ten sam wymiar");
        }
    }

    public Matrix Multiply(Matrix matrix1, Matrix matrix2)
    {
        if (matrix1.Columns != matrix2.Rows)
        {
            throw new ArgumentException("Liczba kolumn pierwszej macierzy musi być równa liczbie wierszy drugiej macierzy");
        }

        var tab = new double[matrix1.Rows, matrix2.Columns];

        for (var i = 0; i < matrix1.Rows; i++)
        {
            for (var j = 0; j < matrix2.Columns; j++)
            {
                for (var k = 0; k < matrix1.Columns; k++)
                {
                    tab[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return new Matrix(tab);
    }

    public Matrix Inverse(Matrix matrix)
    {
        var det = Determinant(matrix);

        if(det == 0)
            throw new ArgumentException("Macierz nie jest odwracalna");

        var n = matrix.Rows;

        // Create the identity matrix
        var identity = new double[n, n];

        for (var i = 0; i < n; i++)
        {
            identity[i, i] = 1.0;
        }

        // Gaussian elimination with partial pivoting
        for (var k = 0; k < n; k++)
        {
            // Find pivot
            var maxRow = k;
            var maxVal = Math.Abs(matrix[k, k]);

            for (var i = k + 1; i < n; i++)
            {
                var val = Math.Abs(matrix[i, k]);

                if (val > maxVal)
                {
                    maxVal = val;
                    maxRow = i;
                }
            }

            // Swap rows to put pivot on diagonal
            if (maxRow != k)
            {
                for (var j = k; j < n; j++)
                {
                    (matrix[k, j], matrix[maxRow, j]) = (matrix[maxRow, j], matrix[k, j]);
                }

                for (var j = 0; j < n; j++)
                {
                    (identity[k, j], identity[maxRow, j]) = (identity[maxRow, j], identity[k, j]);
                }
            }

            // Scale row so that pivot is 1
            var pivot = matrix[k, k];

            for (var j = k; j < n; j++)
            {
                matrix[k, j] /= pivot;
            }

            for (var j = 0; j < n; j++)
            {
                identity[k, j] /= pivot;
            }

            // Eliminate other entries in column
            for (var i = 0; i < n; i++)
            {
                if (i != k)
                {
                    var factor = matrix[i, k];

                    for (var j = k; j < n; j++)
                    {
                        matrix[i, j] -= factor * matrix[k, j];
                    }

                    for (var j = 0; j < n; j++)
                    {
                        identity[i, j] -= factor * identity[k, j];
                    }
                }
            }
        }

        return new Matrix(identity);
    }

    public double Determinant(Matrix matrix)
    {
        if (matrix.Columns != matrix.Rows)
        {
            throw new ArgumentException("Macierz musi być kwadratowa");
        }

        var n = matrix.Rows;

        if (n == 1)
        {
            return matrix[0, 0];
        }

        if (n == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        var det = 0.0;

        for (var j = 0; j < n; j++)
        {
            var subValues = new double[n - 1, n - 1];

            for (var i = 1; i < n; i++)
            {
                for (var k = 0; k < n; k++)
                {
                    if (k < j)
                    {
                        subValues[i - 1, k] = matrix[i, k];
                    }
                    else if (k > j)
                    {
                        subValues[i - 1, k - 1] = matrix[i, k];
                    }
                }
            }

            var subMatrix = new Matrix(subValues);

            det += Math.Pow(-1, j) * matrix[0, j] * Determinant(subMatrix);
        }

        return det;
    }

    public Matrix Solve(Matrix matrix1, Matrix matrix2)
    {
        var inv = Inverse(matrix1);

        var result = Multiply(matrix2, inv);

        return result;
    }
}