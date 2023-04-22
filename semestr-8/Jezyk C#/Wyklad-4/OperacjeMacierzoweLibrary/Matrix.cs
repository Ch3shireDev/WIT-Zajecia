namespace OperacjeMacierzoweLibrary;

public class Matrix
{
    private readonly double[,] values;

    public Matrix(double[,] values)
    {
        this.values = values;
    }

    public Matrix(int rows, int columns)
    {
        values = new double[rows, columns];
    }

    public int Rows => values.GetLength(0);

    public int Columns => values.GetLength(1);
    // table operator

    public double this[int row, int column]
    {
        get => values[row, column];
        set => values[row, column] = value;
    }

    public IEnumerable<double[]> GetEnumerator()
    {
        for (var i = 0; i < Rows; i++)
        {
            var row = new double[Columns];

            for (var j = 0; j < Columns; j++)
            {
                row[j] = values[i, j];
            }

            yield return row;
        }
    }
}