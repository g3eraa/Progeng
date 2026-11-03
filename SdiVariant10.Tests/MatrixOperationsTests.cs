using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SdiVariant10.Tests
{
    [TestClass]
    public class MatrixOperationsTests
    {
        [DataTestMethod]
        [DataRow(1, 1)]
        [DataRow(1, 20)]
        [DataRow(20, 1)]
        [DataRow(20, 20)]
        public void DoubleTransposeRestoresMatrixAtBoundaryDimensions(int rows, int columns)
        {
            Matrix source = new Matrix(rows, columns);
            source.FillRandom(-100, 100, new Random(42));
            Matrix result = MatrixOperations.Transpose(MatrixOperations.Transpose(source));
            Assert.AreEqual(source.Rows, result.Rows);
            Assert.AreEqual(source.Columns, result.Columns);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    Assert.AreEqual(source[i, j], result[i, j]);
        }

        [TestMethod]
        public void TransposeSwapsAxesWithoutChangingSource()
        {
            Matrix matrix = new Matrix(2, 3);
            matrix[0, 2] = 7;
            matrix[1, 0] = -3;
            Matrix result = MatrixOperations.Transpose(matrix);
            Assert.AreEqual(3, result.Rows);
            Assert.AreEqual(2, result.Columns);
            Assert.AreEqual(7, result[2, 0]);
            Assert.AreEqual(-3, result[0, 1]);
            result[2, 0] = 99;
            Assert.AreEqual(7, matrix[0, 2]);
        }

        [TestMethod]
        public void SumsSupportRectangularMatrixAndNegativeValues()
        {
            Matrix matrix = new Matrix(2, 3);
            matrix[0, 0] = 1;
            matrix[0, 1] = -2;
            matrix[0, 2] = 3;
            matrix[1, 0] = -4;
            matrix[1, 1] = 5;
            matrix[1, 2] = -6;
            CollectionAssert.AreEqual(new long[] { 2, -5 }, MatrixOperations.GetRowSums(matrix));
            CollectionAssert.AreEqual(new long[] { -3, 3, -3 }, MatrixOperations.GetColumnSums(matrix));
        }

        [TestMethod]
        public void SumsDoNotOverflowIntegerRange()
        {
            Matrix matrix = new Matrix(2, 2);
            matrix.FillRandom(int.MaxValue, int.MaxValue, new Random(1));
            long expected = 2L * int.MaxValue;
            CollectionAssert.AreEqual(new[] { expected, expected }, MatrixOperations.GetRowSums(matrix));
            CollectionAssert.AreEqual(new[] { expected, expected }, MatrixOperations.GetColumnSums(matrix));
        }

        [TestMethod]
        public void OperationsRejectNullMatrix()
        {
            Assert.ThrowsException<ArgumentNullException>(() => MatrixOperations.Transpose(null));
            Assert.ThrowsException<ArgumentNullException>(() => MatrixOperations.GetRowSums(null));
            Assert.ThrowsException<ArgumentNullException>(() => MatrixOperations.GetColumnSums(null));
        }
    }
}
