namespace OperacjeMacierzoweLibrary;

public class Solver
{
    public double[,] Join(double[,] x, double[,] y)
    {
        var rows = x.GetLength(0);
        var cols1 = x.GetLength(1);
        var cols2 = y.GetLength(1);
        var colsTotal = cols1 + cols2;

        var output = new double[rows, colsTotal];

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < colsTotal; j++)
            {
                output[i, j] = j < cols1 ? x[i, j] : y[i, j - cols1];
            }
        }


        return output;
    }

    public double[,] SliceMatrix(double[,] input, int i)
    {
        var rows = input.GetLength(0);
        var cols = input.GetLength(1)-i;

        var output = new double[rows, cols];

        for (var j = 0; j < rows; j++)
        {
            for (var k = 0; k < cols; k++)
            {
                output[j, k] = input[j, k + i];
            }
        }

        return output;
    }

    public double[,] Step(double[,] input, int n)
    {
        var rows = input.GetLength(0);
        var cols = input.GetLength(1);

        var output = new double[rows, cols];

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                if (i == n)
                {
                    output[i, j] = input[i, j] / input[n, n];
                }
                else
                {
                    output[i, j] = input[i, j] - input[i, n] * input[n, j] / input[n, n];
                }
            }
        }


        return output;
    }
}