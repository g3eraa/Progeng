using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SdiVariant10.Tests
{
    [TestClass]
    public class MatrixTests
    {
        [DataTestMethod]
        [DataRow(0, 1)]
        [DataRow(1, 0)]
        [DataRow(21, 1)]
        [DataRow(1, 21)]
        public void ConstructorRejectsInvalidDimensions(int rows, int columns)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Matrix(rows, columns));
        }

        [TestMethod]
        public void ResizePreservesOverlapAndInitializesNewCells()
        {
            Matrix matrix = new Matrix(2, 2);
            matrix[0, 0] = 7;
            matrix[1, 1] = -4;
            matrix.Resize(3, 4);
            Assert.AreEqual(3, matrix.Rows);
            Assert.AreEqual(4, matrix.Columns);
            Assert.AreEqual(7, matrix[0, 0]);
            Assert.AreEqual(-4, matrix[1, 1]);
            Assert.AreEqual(0, matrix[2, 3]);
            matrix.Resize(1, 1);
            Assert.AreEqual(7, matrix[0, 0]);
        }

        [TestMethod]
        public void InvalidResizeLeavesMatrixUnchanged()
        {
            Matrix matrix = new Matrix(2, 3);
            matrix[1, 2] = 8;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => matrix.Resize(0, 3));
            Assert.AreEqual(2, matrix.Rows);
            Assert.AreEqual(3, matrix.Columns);
            Assert.AreEqual(8, matrix[1, 2]);
        }

        [TestMethod]
        public void CloneHasIndependentStorage()
        {
            Matrix source = new Matrix(2, 2);
            source[1, 1] = 9;
            Matrix copy = source.Clone();
            Assert.AreEqual(9, copy[1, 1]);
            copy[1, 1] = -9;
            Assert.AreEqual(9, source[1, 1]);
        }

        [TestMethod]
        public void ClearRowDoesNotChangeOtherRows()
        {
            Matrix matrix = new Matrix(2, 2);
            matrix.FillRandom(5, 5, new Random(1));
            matrix.ClearRow(0);
            Assert.AreEqual(0, matrix[0, 0]);
            Assert.AreEqual(0, matrix[0, 1]);
            Assert.AreEqual(5, matrix[1, 0]);
            Assert.AreEqual(5, matrix[1, 1]);
        }

        [TestMethod]
        public void ClearResetsEveryCell()
        {
            Matrix matrix = new Matrix(2, 3);
            matrix.FillRandom(5, 5, new Random(1));
            matrix.Clear();
            for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++)
                    Assert.AreEqual(0, matrix[i, j]);
        }

        [DataTestMethod]
        [DataRow(int.MinValue)]
        [DataRow(0)]
        [DataRow(int.MaxValue)]
        public void FillRandomSupportsSingleValueIncludingIntegerBounds(int value)
        {
            Matrix matrix = new Matrix(2, 2);
            matrix.FillRandom(value, value, new Random(1));
            for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++)
                    Assert.AreEqual(value, matrix[i, j]);
        }

        [TestMethod]
        public void FillRandomStaysWithinInclusiveRange()
        {
            Matrix matrix = new Matrix(20, 20);
            matrix.FillRandom(-3, 3, new Random(42));
            for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++)
                    Assert.IsTrue(matrix[i, j] >= -3 && matrix[i, j] <= 3);
        }

        [TestMethod]
        public void FillRandomRejectsInvalidArguments()
        {
            Matrix matrix = new Matrix(1, 1);
            Assert.ThrowsException<ArgumentException>(() => matrix.FillRandom(2, 1, new Random(1)));
            Assert.ThrowsException<ArgumentNullException>(() => matrix.FillRandom(0, 1, null));
        }
    }
}
