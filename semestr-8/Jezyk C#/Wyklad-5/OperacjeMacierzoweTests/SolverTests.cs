using OperacjeMacierzoweLibrary;

namespace OperacjeMacierzoweTests;

public partial class MatrixServiceTests
{
    [TestClass]
    public class SolverTests
    {
        private readonly Solver service = new Solver();


        [TestMethod]
        public void SolverTest()
        {
            var matrixM = new[,]
            {
                { 9.3, 9.8, 2.2, 9.4 },
                { 5.5, 1.3, 7.4, 3.7 },
                { 7.3, 8.1, 8.6, 4.1 },
                { 8.4, 2.3, 2.3, 6.7 }
            };

            var matrixY = new[,]
            {
                { 1.000, 0.000, 0.000, 0.000, 3.600 },
                { 0.000, 1.000, 0.000, 0.000, 3.900 },
                { 0.000, 0.000, 1.000, 0.000, 8.200 },
                { 0.000, 0.000, 0.000, 1.000, 7.200 }
            };

            var join = service.Join(matrixM, matrixY);

            for (var i = 0; i < join.GetLength(0); i++)
            {
                join = service.Step(join, i);
            }

            var matrixX = service.SliceMatrix(join, 4);

            Assert.AreEqual(4, matrixX.GetLength(0));
            Assert.AreEqual(5, matrixX.GetLength(1));

            Assert.AreEqual(-0.288, matrixX[0, 0], 0.001);
            Assert.AreEqual(-0.382, matrixX[0, 1], 0.001);
            Assert.AreEqual(0.284, matrixX[0, 2], 0.001);
            Assert.AreEqual(0.440, matrixX[0, 3], 0.001);
            Assert.AreEqual(2.978, matrixX[0, 4], 0.001);

            Assert.AreEqual(0.050, matrixX[1, 0], 0.001);
            Assert.AreEqual(-0.110, matrixX[1, 1], 0.001);
            Assert.AreEqual(0.101, matrixX[1, 2], 0.001);
            Assert.AreEqual(-0.071, matrixX[1, 3], 0.001);
            Assert.AreEqual(0.069, matrixX[1, 4], 0.001);

            Assert.AreEqual(0.040, matrixX[2, 0], 0.001);
            Assert.AreEqual(0.217, matrixX[2, 1], 0.001);
            Assert.AreEqual(-0.040, matrixX[2, 2], 0.001);
            Assert.AreEqual(-0.152, matrixX[2, 3], 0.001);
            Assert.AreEqual(-0.431, matrixX[2, 4], 0.001);

            Assert.AreEqual(0.330, matrixX[3, 0], 0.001);
            Assert.AreEqual(0.442, matrixX[3, 1], 0.001);
            Assert.AreEqual(-0.377, matrixX[3, 2], 0.001);
            Assert.AreEqual(-0.327, matrixX[3, 3], 0.001);
            Assert.AreEqual(-2.534, matrixX[3, 4], 0.001);
        }

        [TestMethod]
        public void JoinerTest()
        {
            var matrixM = new[,]
            {
                { 8.8, 5.0, 8.5, 2.6 },
                { 1.3, 7.3, 9.9, 1.7 },
                { 5.0, 4.8, 1.8, 9.6 },
                { 2.8, 7.2, 5.5, 5.4 }
            };

            var matrixYin = new[,]
            {
                { 1.000, 0.000, 0.000, 0.000, 5.100 },
                { 0.000, 1.000, 0.000, 0.000, 0.900 },
                { 0.000, 0.000, 1.000, 0.000, 9.700 },
                { 0.000, 0.000, 0.000, 1.000, 9.700 }
            };

            var result = service.Join(matrixM, matrixYin);

            Assert.AreEqual(4, result.GetLength(0));
            Assert.AreEqual(9, result.GetLength(1));

            Assert.AreEqual(8.8, result[0, 0], 0.001);
            Assert.AreEqual(5.0, result[0, 1], 0.001);
            Assert.AreEqual(8.5, result[0, 2], 0.001);
            Assert.AreEqual(2.6, result[0, 3], 0.001);
            Assert.AreEqual(1.000, result[0, 4], 0.001);
            Assert.AreEqual(0.000, result[0, 5], 0.001);
            Assert.AreEqual(0.000, result[0, 6], 0.001);
            Assert.AreEqual(0.000, result[0, 7], 0.001);
            Assert.AreEqual(5.100, result[0, 8], 0.001);

            Assert.AreEqual(1.3, result[1, 0], 0.001);
            Assert.AreEqual(7.3, result[1, 1], 0.001);
            Assert.AreEqual(9.9, result[1, 2], 0.001);
            Assert.AreEqual(1.7, result[1, 3], 0.001);
            Assert.AreEqual(0.000, result[1, 4], 0.001);
            Assert.AreEqual(1.000, result[1, 5], 0.001);
            Assert.AreEqual(0.000, result[1, 6], 0.001);
            Assert.AreEqual(0.000, result[1, 7], 0.001);
            Assert.AreEqual(0.900, result[1, 8], 0.001);

            Assert.AreEqual(5.0, result[2, 0], 0.001);
            Assert.AreEqual(4.8, result[2, 1], 0.001);
            Assert.AreEqual(1.8, result[2, 2], 0.001);
            Assert.AreEqual(9.6, result[2, 3], 0.001);
            Assert.AreEqual(0.000, result[2, 4], 0.001);
            Assert.AreEqual(0.000, result[2, 5], 0.001);
            Assert.AreEqual(1.000, result[2, 6], 0.001);
            Assert.AreEqual(0.000, result[2, 7], 0.001);
            Assert.AreEqual(9.700, result[2, 8], 0.001);

            Assert.AreEqual(2.8, result[3, 0], 0.001);
            Assert.AreEqual(7.2, result[3, 1], 0.001);
            Assert.AreEqual(5.5, result[3, 2], 0.001);
            Assert.AreEqual(5.4, result[3, 3], 0.001);
            Assert.AreEqual(0.000, result[3, 4], 0.001);
            Assert.AreEqual(0.000, result[3, 5], 0.001);
            Assert.AreEqual(0.000, result[3, 6], 0.001);
            Assert.AreEqual(1.000, result[3, 7], 0.001);
            Assert.AreEqual(9.700, result[3, 8], 0.001);
        }

        [TestMethod]
        public void SlicerTest()
        {
            var input = new[,]
            {
                { 8.8, 5.0, 8.5, 2.6, 1.000, 0.000, 0.000, 0.000, 5.100 },
                { 1.3, 7.3, 9.9, 1.7, 0.000, 1.000, 0.000, 0.000, 0.900 },
                { 5.0, 4.8, 1.8, 9.6, 0.000, 0.000, 1.000, 0.000, 9.700 },
                { 2.8, 7.2, 5.5, 5.4, 0.000, 0.000, 0.000, 1.000, 9.700 }
            };

            var result = service.SliceMatrix(input, 4);

            Assert.AreEqual(4, result.GetLength(0));
            Assert.AreEqual(5, result.GetLength(1));

            Assert.AreEqual(1.000, result[0, 0], 0.001);
            Assert.AreEqual(0.000, result[0, 1], 0.001);
            Assert.AreEqual(0.000, result[0, 2], 0.001);
            Assert.AreEqual(0.000, result[0, 3], 0.001);
            Assert.AreEqual(5.100, result[0, 4], 0.001);

            Assert.AreEqual(0.000, result[1, 0], 0.001);
            Assert.AreEqual(1.000, result[1, 1], 0.001);
            Assert.AreEqual(0.000, result[1, 2], 0.001);
            Assert.AreEqual(0.000, result[1, 3], 0.001);
            Assert.AreEqual(0.900, result[1, 4], 0.001);

            Assert.AreEqual(0.000, result[2, 0], 0.001);
            Assert.AreEqual(0.000, result[2, 1], 0.001);
            Assert.AreEqual(1.000, result[2, 2], 0.001);
            Assert.AreEqual(0.000, result[2, 3], 0.001);
            Assert.AreEqual(9.700, result[2, 4], 0.001);

            Assert.AreEqual(0.000, result[3, 0], 0.001);
            Assert.AreEqual(0.000, result[3, 1], 0.001);
            Assert.AreEqual(0.000, result[3, 2], 0.001);
            Assert.AreEqual(1.000, result[3, 3], 0.001);
            Assert.AreEqual(9.700, result[3, 4], 0.001);
        }

        [TestMethod]
        public void StepFirstTest()
        {
            var input = new[,]
            {
                { 9.3, 9.8, 2.2, 9.4, 1.000, 0.000, 0.000, 0.000, 3.600 },
                { 5.5, 1.3, 7.4, 3.7, 0.000, 1.000, 0.000, 0.000, 3.900 },
                { 7.3, 8.1, 8.6, 4.1, 0.000, 0.000, 1.000, 0.000, 8.200 },
                { 8.4, 2.3, 2.3, 6.7, 0.000, 0.000, 0.000, 1.000, 7.200 }
            };

            var result = service.Step(input, 0);

            Assert.AreEqual(4, result.GetLength(0));
            Assert.AreEqual(9, result.GetLength(1));

            Assert.AreEqual(1.0, result[0, 0], 0.1);
            Assert.AreEqual(1.1, result[0, 1], 0.1);
            Assert.AreEqual(0.2, result[0, 2], 0.1);
            Assert.AreEqual(1.0, result[0, 3], 0.1);
            Assert.AreEqual(0.108, result[0, 4], 0.1);
            Assert.AreEqual(0.000, result[0, 5], 0.1);
            Assert.AreEqual(0.000, result[0, 6], 0.1);
            Assert.AreEqual(0.000, result[0, 7], 0.1);
            Assert.AreEqual(0.4, result[0, 8], 0.1);

            Assert.AreEqual(0.0, result[1, 0], 0.1);
            Assert.AreEqual(-4.5, result[1, 1], 0.1);
            Assert.AreEqual(6.1, result[1, 2], 0.1);
            Assert.AreEqual(-1.9, result[1, 3], 0.1);
            Assert.AreEqual(-0.591, result[1, 4], 0.1);
            Assert.AreEqual(1.000, result[1, 5], 0.1);
            Assert.AreEqual(0.000, result[1, 6], 0.1);
            Assert.AreEqual(0.000, result[1, 7], 0.1);
            Assert.AreEqual(1.8, result[1, 8], 0.1);

            Assert.AreEqual(0.0, result[2, 0], 0.1);
            Assert.AreEqual(0.4, result[2, 1], 0.1);
            Assert.AreEqual(6.9, result[2, 2], 0.1);
            Assert.AreEqual(-3.3, result[2, 3], 0.1);
            Assert.AreEqual(-0.785, result[2, 4], 0.1);
            Assert.AreEqual(0.000, result[2, 5], 0.1);
            Assert.AreEqual(1.000, result[2, 6], 0.1);
            Assert.AreEqual(0.000, result[2, 7], 0.1);
            Assert.AreEqual(5.4, result[2, 8], 0.1);

            Assert.AreEqual(0.0, result[3, 0], 0.1);
            Assert.AreEqual(-6.6, result[3, 1], 0.1);
            Assert.AreEqual(0.3, result[3, 2], 0.1);
            Assert.AreEqual(-1.8, result[3, 3], 0.1);
            Assert.AreEqual(-0.903, result[3, 4], 0.1);
            Assert.AreEqual(0.000, result[3, 5], 0.1);
            Assert.AreEqual(0.000, result[3, 6], 0.1);
            Assert.AreEqual(1.000, result[3, 7], 0.1);
            Assert.AreEqual(3.9, result[3, 8], 0.1);
        }

        [TestMethod]
        public void StepSecondTest()
        {
            var input = new[,]
            {
                { 1.0, 1.1, 0.2, 1.0, 0.108, 0.000, 0.000, 0.000, 0.4 },
                { 0.0, -4.5, 6.1, -1.9, -0.591, 1.000, 0.000, 0.000, 1.8 },
                { 0.0, 0.4, 6.9, -3.3, -0.785, 0.000, 1.000, 0.000, 5.4 },
                { 0.0, -6.6, 0.3, -1.8, -0.903, 0.000, 0.000, 1.000, 3.9 }
            };


            var result = service.Step(input, 1);

            Assert.AreEqual(4, result.GetLength(0));
            Assert.AreEqual(9, result.GetLength(1));

            Assert.AreEqual(1.0, result[0, 0], 0.1);
            Assert.AreEqual(0.0, result[0, 1], 0.1);
            Assert.AreEqual(1.7, result[0, 2], 0.1);
            Assert.AreEqual(0.6, result[0, 3], 0.1);
            Assert.AreEqual(-0.031, result[0, 4], 0.1);
            Assert.AreEqual(0.234, result[0, 5], 0.1);
            Assert.AreEqual(0.000, result[0, 6], 0.1);
            Assert.AreEqual(0.000, result[0, 7], 0.1);
            Assert.AreEqual(0.8, result[0, 8], 0.1);

            Assert.AreEqual(0.0, result[1, 0], 0.1);
            Assert.AreEqual(1.0, result[1, 1], 0.1);
            Assert.AreEqual(-1.4, result[1, 2], 0.1);
            Assert.AreEqual(0.4, result[1, 3], 0.1);
            Assert.AreEqual(0.132, result[1, 4], 0.1);
            Assert.AreEqual(-0.222, result[1, 5], 0.1);
            Assert.AreEqual(0.000, result[1, 6], 0.1);
            Assert.AreEqual(0.000, result[1, 7], 0.1);
            Assert.AreEqual(-0.4, result[1, 8], 0.1);

            Assert.AreEqual(0.0, result[2, 0], 0.1);
            Assert.AreEqual(0.0, result[2, 1], 0.1);
            Assert.AreEqual(7.4, result[2, 2], 0.1);
            Assert.AreEqual(-3.4, result[2, 3], 0.1);
            Assert.AreEqual(-0.839, result[2, 4], 0.1);
            Assert.AreEqual(0.091, result[2, 5], 0.1);
            Assert.AreEqual(1.000, result[2, 6], 0.1);
            Assert.AreEqual(0.000, result[2, 7], 0.1);
            Assert.AreEqual(5.5, result[2, 8], 0.1);

            Assert.AreEqual(0.0, result[3, 0], 0.1);
            Assert.AreEqual(0.0, result[3, 1], 0.1);
            Assert.AreEqual(-8.6, result[3, 2], 0.1);
            Assert.AreEqual(0.9, result[3, 3], 0.1);
            Assert.AreEqual(-0.041, result[3, 4], 0.1);
            Assert.AreEqual(-1.457, result[3, 5], 0.1);
            Assert.AreEqual(0.000, result[3, 6], 0.1);
            Assert.AreEqual(1.000, result[3, 7], 0.1);
            Assert.AreEqual(1.4, result[3, 8], 0.15);
        }
    }
}