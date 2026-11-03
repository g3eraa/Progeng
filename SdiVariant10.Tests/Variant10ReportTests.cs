using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SdiVariant10.Tests
{
    [TestClass]
    public class Variant10ReportTests
    {
        [DataTestMethod]
        [DataRow(Numbering.FromOne, "2")]
        [DataRow(Numbering.FromZero, "1")]
        public void SummaryShowsStatisticsAndSelectedNumbering(Numbering numbering, string zeroColumn)
        {
            Matrix matrix = new Matrix(2, 2);
            matrix[0, 0] = 1;
            matrix[1, 0] = -2;
            string report = Variant10Report.BuildSummary(matrix, numbering);
            StringAssert.Contains(report, "Всего нулевых элементов: 2.");
            StringAssert.Contains(report, $"Нулевые столбцы: {zeroColumn}.");
            StringAssert.Contains(report, "Суммы по строкам: 1, -2.");
            StringAssert.Contains(report, "Суммы по столбцам: -1, 0.");
            StringAssert.Contains(report, "Минимальный элемент: -2.");
            StringAssert.Contains(report, "Максимальный элемент: 1.");
            StringAssert.Contains(report, "Положительных элементов: 1.");
            StringAssert.Contains(report, "Отрицательных элементов: 1.");
        }

        [TestMethod]
        public void BuildIncludesSelectedTaskAndSummary()
        {
            Matrix matrix = new Matrix(1, 1);
            Variant10Result result = new Variant10Solver(matrix).Solve(new TaskOptions
            {
                CountZerosInEvenColumns = false
            });
            string report = Variant10Report.Build(matrix, result);
            StringAssert.Contains(report, "Задача 1.");
            StringAssert.Contains(report, "Ответ: да. Номера таких строк: 1.");
            Assert.IsFalse(report.Contains("Задача 2."));
            StringAssert.Contains(report, "Дополнительные сведения о матрице");
            StringAssert.Contains(report, "Минимальный элемент: 0.");
            StringAssert.Contains(report, "Максимальный элемент: 0.");
            StringAssert.Contains(report, "Положительных элементов: 0.");
            StringAssert.Contains(report, "Отрицательных элементов: 0.");
        }

        [TestMethod]
        public void SummaryStatesWhenNoZeroColumnsExist()
        {
            Matrix matrix = new Matrix(1, 1);
            matrix[0, 0] = 1;
            StringAssert.Contains(Variant10Report.BuildSummary(matrix, Numbering.FromOne), "Нулевые столбцы: нет.");
        }

        [TestMethod]
        public void ReportRejectsNullArguments()
        {
            Matrix matrix = new Matrix(1, 1);
            Assert.ThrowsException<ArgumentNullException>(() => Variant10Report.BuildSummary(null, Numbering.FromOne));
            Assert.ThrowsException<ArgumentNullException>(() => Variant10Report.Build(matrix, null));
            Assert.ThrowsException<ArgumentNullException>(() => Variant10Report.Build(null, new Variant10Result()));
            Assert.ThrowsException<ArgumentNullException>(() => Variant10Report.Build(matrix, new Variant10Result()));
        }
    }
}
