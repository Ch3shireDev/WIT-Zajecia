using OperacjeMacierzoweLibrary;

namespace OperacjeMacierzoweTests;

[TestClass]
public class MatrixServiceTests
{
    private readonly MatrixService service = new MatrixService();

    [TestMethod]
    public void DeserializeTest()
    {
        var str = "1 2 3 4 5 6 7 8 9\n" +
                  "9 8 7 6 5 4 3 2 1";

        var matrix = service.Deserialize(str);

        Assert.AreEqual(2, matrix.Rows);
        Assert.AreEqual(9, matrix.Columns);

        Assert.AreEqual(1, matrix[0, 0]);
        Assert.AreEqual(2, matrix[0, 1]);
        Assert.AreEqual(3, matrix[0, 2]);
        Assert.AreEqual(4, matrix[0, 3]);
        Assert.AreEqual(5, matrix[0, 4]);
        Assert.AreEqual(6, matrix[0, 5]);
        Assert.AreEqual(7, matrix[0, 6]);
        Assert.AreEqual(8, matrix[0, 7]);
        Assert.AreEqual(9, matrix[0, 8]);

        Assert.AreEqual(9, matrix[1, 0]);
        Assert.AreEqual(8, matrix[1, 1]);
        Assert.AreEqual(7, matrix[1, 2]);
        Assert.AreEqual(6, matrix[1, 3]);
        Assert.AreEqual(5, matrix[1, 4]);
        Assert.AreEqual(4, matrix[1, 5]);
        Assert.AreEqual(3, matrix[1, 6]);
        Assert.AreEqual(2, matrix[1, 7]);
        Assert.AreEqual(1, matrix[1, 8]);
    }

    [TestMethod]
    public void SerializeTest()
    {
        var tab = new double[,]
        {
            { 5, 7, 9 },
            { 1, 2, 3 }
        };

        var matrix = new Matrix(tab);

        var str = service.Serialize(matrix);

        var expectedResult = "5.000 7.000 9.000\n" +
                             "1.000 2.000 3.000";

        Assert.AreEqual(expectedResult, str);
    }

    [TestMethod]
    public void AddTest()
    {
        var tab1 = new double[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        var tab2 = new double[,]
        {
            { 7, 8, 9 },
            { 10, 11, 12 }
        };

        var matrix1 = new Matrix(tab1);
        var matrix2 = new Matrix(tab2);

        var result = service.Add(matrix1, matrix2);

        Assert.AreEqual(2, result.Rows);
        Assert.AreEqual(3, result.Columns);

        Assert.AreEqual(8, result[0, 0]);
        Assert.AreEqual(10, result[0, 1]);
        Assert.AreEqual(12, result[0, 2]);

        Assert.AreEqual(14, result[1, 0]);
        Assert.AreEqual(16, result[1, 1]);
        Assert.AreEqual(18, result[1, 2]);
    }

    [TestMethod]
    public void SubtractTest()
    {
        var tab1 = new double[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        var tab2 = new double[,]
        {
            { 7, 8, 9 },
            { 10, 11, 12 }
        };

        var matrix1 = new Matrix(tab1);
        var matrix2 = new Matrix(tab2);

        var result = service.Subtract(matrix1, matrix2);

        Assert.AreEqual(2, result.Rows);
        Assert.AreEqual(3, result.Columns);

        Assert.AreEqual(-6, result[0, 0]);
        Assert.AreEqual(-6, result[0, 1]);
        Assert.AreEqual(-6, result[0, 2]);

        Assert.AreEqual(-6, result[1, 0]);
        Assert.AreEqual(-6, result[1, 1]);
        Assert.AreEqual(-6, result[1, 2]);
    }

    [TestMethod]
    public void MultiplyTest()
    {
        var tab1 = new double[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        var tab2 = new double[,]
        {
            { 7, 8 },
            { 9, 10 },
            { 11, 12 }
        };

        var matrix1 = new Matrix(tab1);
        var matrix2 = new Matrix(tab2);

        var result = service.Multiply(matrix1, matrix2);

        Assert.AreEqual(2, result.Rows);
        Assert.AreEqual(2, result.Columns);

        Assert.AreEqual(58, result[0, 0]);
        Assert.AreEqual(64, result[0, 1]);

        Assert.AreEqual(139, result[1, 0]);
        Assert.AreEqual(154, result[1, 1]);
    }

    [TestMethod]
    public void InverseTest()
    {
        var tab = new double[,]
        {
            { 1, 2 },
            { 3, 4 }
        };

        var matrix = new Matrix(tab);

        var result = service.Inverse(matrix);

        Assert.AreEqual(2, result.Rows);
        Assert.AreEqual(2, result.Columns);

        Assert.AreEqual(-2, result[0, 0], 0.001);
        Assert.AreEqual(1, result[0, 1], 0.001);

        Assert.AreEqual(1.5, result[1, 0], 0.001);
        Assert.AreEqual(-0.5, result[1, 1], 0.001);
    }

    [TestMethod]
    public void DeterminantTest()
    {
        var tab = new double[,]
        {
            { 1, 2 },
            { 3, 4 }
        };

        var matrix = new Matrix(tab);

        var result = service.Determinant(matrix);

        Assert.AreEqual(-2, result);
    }

    [TestMethod]
    public void DeterminantTest2()
    {
        var tab = new double[,]
        {
            { 1, 2, 3 },
            { 2, 3, 1 },
            { 3, 2, 1 }
        };
        var matrix = new Matrix(tab);

        var result = service.Determinant(matrix);

        Assert.AreEqual(-12, result);
    }

    [TestMethod]
    public void SolveTest()
    {
        var m2 = new double[,]
        {
            { 1, 2 },
            { 3, 4 }
        };

        var m1 = new double[,]
        {
            { 2, 1 },
            { 1, 2 }
        };
        
        var matrix1 = new Matrix(m1);
        var matrix2 = new Matrix(m2);

        var result = service.Solve(matrix1, matrix2);

        Assert.AreEqual(2, result.Columns);
        Assert.AreEqual(2, result.Rows);

        Assert.AreEqual(0, result[0, 0], 0.001);
        Assert.AreEqual(1, result[0, 1], 0.001);
        Assert.AreEqual(0.666, result[1, 0], 0.001);
        Assert.AreEqual(1.666, result[1, 1], 0.001);
    }
}