using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SdiVariant5.Tests
{
    [TestClass]
    public class MatrixOperationsTests
    {
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
