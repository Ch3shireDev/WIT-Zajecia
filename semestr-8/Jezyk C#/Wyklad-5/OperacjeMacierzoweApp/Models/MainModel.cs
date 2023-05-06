using System;
using System.Globalization;
using OperacjeMacierzoweLibrary;

namespace OperacjeMacierzoweApp.Models;

public class MainModel
{
    private readonly MatrixService service = new MatrixService();

    public string Matrix1 { get; set; } = "1 2\n3 4";
    public string Matrix2 { get; set; } = "1 2\n2 1";
    public string Result { get; set; }

    public string Test()
    {
        var matrix = service.Deserialize(Matrix1);
        return service.Serialize(matrix);
    }

    public string Add()
    {
        var matrix1 = service.Deserialize(Matrix1);
        var matrix2 = service.Deserialize(Matrix2);

        var result = service.Add(matrix1, matrix2);

        return service.Serialize(result);
    }

    public string Sub()
    {
        var matrix1 = service.Deserialize(Matrix1);
        var matrix2 = service.Deserialize(Matrix2);

        var result = service.Subtract(matrix1, matrix2);

        return service.Serialize(result);
    }

    public string Mul()
    {
        var matrix1 = service.Deserialize(Matrix1);
        var matrix2 = service.Deserialize(Matrix2);

        var result = service.Multiply(matrix1, matrix2);

        return service.Serialize(result);
    }

    public string Det()
    {
        var matrix1 = service.Deserialize(Matrix1);

        var result = service.Determinant(matrix1);
        
        return result.ToString(CultureInfo.InvariantCulture);
    }

    public string Inv()
    {
        var matrix1 = service.Deserialize(Matrix1);

        var result = service.Inverse(matrix1);

        return service.Serialize(result);
    }

    public string Solve()
    {
        var matrix1 = service.Deserialize(Matrix1);
        var matrix2 = service.Deserialize(Matrix2);

        var result = service.Solve(matrix1, matrix2);

        return service.Serialize(result);
    }

    public string Det1()
    {
        var matrix1 = service.Deserialize(Matrix1);

        var result = service.Determinant(matrix1);

        return result.ToString(CultureInfo.InvariantCulture);
    }

    public string Det2()
    {
        var matrix2 = service.Deserialize(Matrix2);

        var result = service.Determinant(matrix2);

        return result.ToString(CultureInfo.InvariantCulture);
    }
}