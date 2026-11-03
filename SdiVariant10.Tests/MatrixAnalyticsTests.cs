using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SdiVariant10.Tests
{
    [TestClass]
    public class MatrixAnalyticsTests
    {
        [TestMethod]
        public void ExtremaFindValuesInRectangularMatrix()
        {
            Matrix matrix = new Matrix(2, 3);
            matrix[0, 0] = 3;
            matrix[0, 1] = -7;
            matrix[0, 2] = 2;
            matrix[1, 0] = 8;
            matrix[1, 1] = 4;
            matrix[1, 2] = -1;
            Assert.AreEqual(-7, MatrixExtrema.GetMinimum(matrix));
            Assert.AreEqual(8, MatrixExtrema.GetMaximum(matrix));
            Assert.AreEqual(3, matrix[0, 0]);
            Assert.AreEqual(-1, matrix[1, 2]);
        }

        [DataTestMethod]
        [DataRow(int.MinValue)]
        [DataRow(-7)]
        [DataRow(0)]
        [DataRow(9)]
        [DataRow(int.MaxValue)]
        public void ExtremaSupportUniformValues(int value)
        {
            Matrix matrix = new Matrix(2, 3);
            matrix.FillRandom(value, value, new Random(42));
            Assert.AreEqual(value, MatrixExtrema.GetMinimum(matrix));
            Assert.AreEqual(value, MatrixExtrema.GetMaximum(matrix));
        }

        [TestMethod]
        public void SignCountsExcludeZerosAndHandleIntegerBounds()
        {
            Matrix matrix = new Matrix(2, 3);
            matrix[0, 0] = int.MinValue;
            matrix[0, 1] = int.MaxValue;
            matrix[1, 0] = -1;
            Assert.AreEqual(1, MatrixSignCounter.CountPositive(matrix));
            Assert.AreEqual(2, MatrixSignCounter.CountNegative(matrix));
            Assert.AreEqual(int.MinValue, MatrixExtrema.GetMinimum(matrix));
            Assert.AreEqual(int.MaxValue, MatrixExtrema.GetMaximum(matrix));
        }

        [DataTestMethod]
        [DataRow(-3, 0, 6)]
        [DataRow(0, 0, 0)]
        [DataRow(4, 6, 0)]
        public void SignCountsSupportUniformMatrices(int value, int positives, int negatives)
        {
            Matrix matrix = new Matrix(2, 3);
            matrix.FillRandom(value, value, new Random(42));
            Assert.AreEqual(positives, MatrixSignCounter.CountPositive(matrix));
            Assert.AreEqual(negatives, MatrixSignCounter.CountNegative(matrix));
        }

        [DataTestMethod]
        [DataRow(1, 1, 7, 0)]
        [DataRow(1, 20, -3, 1)]
        [DataRow(20, 1, -3, 1)]
        [DataRow(20, 20, -3, 1)]
        public void AnalyticsUseAllCellsAtBoundaryDimensions(
            int rows, int columns, int minimum, int negatives)
        {
            Matrix matrix = new Matrix(rows, columns);
            matrix[0, 0] = -3;
            matrix[rows - 1, columns - 1] = 7;
            Assert.AreEqual(minimum, MatrixExtrema.GetMinimum(matrix));
            Assert.AreEqual(7, MatrixExtrema.GetMaximum(matrix));
            Assert.AreEqual(1, MatrixSignCounter.CountPositive(matrix));
            Assert.AreEqual(negatives, MatrixSignCounter.CountNegative(matrix));
        }

        [TestMethod]
        public void AnalyticsRejectNullMatrix()
        {
            Assert.ThrowsException<ArgumentNullException>(() => MatrixExtrema.GetMinimum(null));
            Assert.ThrowsException<ArgumentNullException>(() => MatrixExtrema.GetMaximum(null));
            Assert.ThrowsException<ArgumentNullException>(() => MatrixSignCounter.CountPositive(null));
            Assert.ThrowsException<ArgumentNullException>(() => MatrixSignCounter.CountNegative(null));
        }
    }
}
