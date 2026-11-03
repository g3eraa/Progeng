using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SdiVariant10.Tests
{
    [TestClass]
    public class Variant10SolverTests
    {
        [DataTestMethod]
        [DataRow(1, 1, 0, 1)]
        [DataRow(1, 20, 10, 10)]
        [DataRow(20, 1, 0, 20)]
        [DataRow(20, 20, 200, 200)]
        public void AllZeroMatrixHandlesBoundaryDimensions(
            int rows, int columns, int fromOneCount, int fromZeroCount)
        {
            Variant10Solver solver = new Variant10Solver(new Matrix(rows, columns));
            Assert.AreEqual(rows, solver.FindZeroRows().Count);
            Assert.AreEqual(columns, solver.FindZeroColumns().Count);
            Assert.AreEqual(rows * columns, solver.CountZeros());
            Assert.AreEqual(fromOneCount, solver.CountZerosInEvenColumns(Numbering.FromOne));
            Assert.AreEqual(fromZeroCount, solver.CountZerosInEvenColumns(Numbering.FromZero));
        }

        private static Matrix Sample()
        {
            Matrix matrix = new Matrix(3, 4);
            matrix[1, 0] = 1;
            matrix[1, 2] = 2;
            matrix[2, 0] = 3;
            matrix[2, 1] = 4;
            matrix[2, 2] = 5;
            return matrix;
        }

        [TestMethod]
        public void FindsOnlyCompletelyZeroRowsAndColumns()
        {
            Variant10Solver solver = new Variant10Solver(Sample());
            Assert.IsTrue(solver.HasZeroRow());
            Assert.IsTrue(solver.IsZeroRow(0));
            Assert.IsFalse(solver.IsZeroRow(1));
            CollectionAssert.AreEqual(new[] { 0 }, solver.FindZeroRows());
            CollectionAssert.AreEqual(new[] { 3 }, solver.FindZeroColumns());
            Assert.AreEqual(7, solver.CountZeros());
            Assert.AreEqual(2, solver.CountZerosInColumn(1));
        }

        [TestMethod]
        public void NonzeroMatrixHasNoZeroRowsOrColumns()
        {
            Matrix matrix = new Matrix(2, 2);
            matrix.FillRandom(1, 1, new Random(1));
            Variant10Solver solver = new Variant10Solver(matrix);
            Assert.IsFalse(solver.HasZeroRow());
            Assert.AreEqual(0, solver.FindZeroRows().Count);
            Assert.AreEqual(0, solver.FindZeroColumns().Count);
            Assert.AreEqual(0, solver.CountZeros());
        }

        [DataTestMethod]
        [DataRow(Numbering.FromOne, 5)]
        [DataRow(Numbering.FromZero, 2)]
        public void CountsZerosUsingSelectedColumnNumbering(Numbering numbering, int expected)
        {
            Variant10Solver solver = new Variant10Solver(Sample());
            Variant10Result result = solver.Solve(new TaskOptions { Numbering = numbering });
            Assert.AreEqual(expected, result.ZerosInEvenColumns);
            Assert.AreEqual(expected, solver.CountZerosInEvenColumns(numbering));
            CollectionAssert.AreEqual(numbering == Numbering.FromOne ? new[] { 1, 3 } : new[] { 0, 2 }, result.EvenColumns);
            CollectionAssert.AreEqual(numbering == Numbering.FromOne ? new[] { 2, 3 } : new[] { 1, 1 }, result.ZerosByEvenColumn);
        }

        [TestMethod]
        public void OneColumnHasNoEvenColumnWhenNumberedFromOne()
        {
            Variant10Solver solver = new Variant10Solver(new Matrix(1, 1));
            Assert.AreEqual(0, solver.CountZerosInEvenColumns(Numbering.FromOne));
            Assert.AreEqual(1, solver.CountZerosInEvenColumns(Numbering.FromZero));
        }

        [DataTestMethod]
        [DataRow(true, false)]
        [DataRow(false, true)]
        [DataRow(false, false)]
        public void SolveRunsOnlySelectedTasks(bool findRows, bool countZeros)
        {
            Variant10Solver solver = new Variant10Solver(Sample());
            Variant10Result result = solver.Solve(new TaskOptions
            {
                FindZeroRow = findRows,
                CountZerosInEvenColumns = countZeros
            });
            Assert.AreEqual(findRows ? 1 : 0, result.ZeroRows.Count);
            Assert.AreEqual(countZeros ? 5 : 0, result.ZerosInEvenColumns);
            Assert.AreEqual(countZeros ? 2 : 0, result.EvenColumns.Count);
        }

        [TestMethod]
        public void SolveCopiesOptions()
        {
            TaskOptions options = new TaskOptions();
            Variant10Result result = new Variant10Solver(Sample()).Solve(options);
            options.FindZeroRow = false;
            options.Numbering = Numbering.FromZero;
            Assert.IsTrue(result.Options.FindZeroRow);
            Assert.AreEqual(Numbering.FromOne, result.Options.Numbering);
        }

        [TestMethod]
        public void RejectsNullInput()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Variant10Solver(null));
            Assert.ThrowsException<ArgumentNullException>(() => new Variant10Solver(Sample()).Solve(null));
        }
    }
}
