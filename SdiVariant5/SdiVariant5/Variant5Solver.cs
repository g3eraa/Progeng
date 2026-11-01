using System;
using System.Collections.Generic;

namespace SdiVariant5
{
    /// <summary>
    /// Результат решения задач варианта 5. Все индексы строк и столбцов — с нуля.
    /// </summary>
    public class Variant5Result
    {
        public TaskOptions Options { get; set; }

        // Задача 1
        /// <summary>Индексы строк, состоящих только из нулевых элементов.</summary>
        public List<int> ZeroRows { get; set; } = new List<int>();

        public bool HasZeroRow => ZeroRows.Count > 0;

        // Задача 2
        /// <summary>Индексы чётных столбцов.</summary>
        public List<int> EvenColumns { get; set; } = new List<int>();

        /// <summary>Количество нулей в каждом из столбцов EvenColumns (в том же порядке).</summary>
        public List<int> ZerosByEvenColumn { get; set; } = new List<int>();

        /// <summary>Суммарное количество нулей в чётных столбцах.</summary>
        public int ZerosInEvenColumns { get; set; }
    }

    /// <summary>
    /// Вариант 5.
    /// 1) Имеется ли в исходном массиве строка, состоящая только из нулевых элементов?
    /// 2) Определить суммарное количество нулевых элементов в чётных столбцах.
    /// </summary>
    public class Variant5Solver
    {
        private readonly Matrix matrix;

        public Variant5Solver(Matrix matrix)
        {
            this.matrix = matrix ?? throw new ArgumentNullException(nameof(matrix));
        }

        /// <summary>Решает выбранные задачи.</summary>
        public Variant5Result Solve(TaskOptions options)
        {
            Variant5Result result = new Variant5Result { Options = options.Clone() };

            if (options.FindZeroRow)
                result.ZeroRows = FindZeroRows();

            if (options.CountZerosInEvenColumns)
            {
                result.EvenColumns = GetEvenColumns(options.Numbering);
                foreach (int column in result.EvenColumns)
                {
                    int zeros = CountZerosInColumn(column);
                    result.ZerosByEvenColumn.Add(zeros);
                    result.ZerosInEvenColumns += zeros;
                }
            }

            return result;
        }

        // ---------- Задача 1 ----------

        /// <summary>Состоит ли строка row только из нулевых элементов.</summary>
        public bool IsZeroRow(int row)
        {
            for (int j = 0; j < matrix.Columns; j++)
                if (matrix[row, j] != 0)
                    return false;
            return true;
        }

        /// <summary>Имеется ли в массиве хотя бы одна строка из одних нулей.</summary>
        public bool HasZeroRow()
        {
            for (int i = 0; i < matrix.Rows; i++)
                if (IsZeroRow(i))
                    return true;
            return false;
        }

        /// <summary>Индексы всех строк, состоящих только из нулей.</summary>
        public List<int> FindZeroRows()
        {
            List<int> rows = new List<int>();
            for (int i = 0; i < matrix.Rows; i++)
                if (IsZeroRow(i))
                    rows.Add(i);
            return rows;
        }

        // ---------- Задача 2 ----------

        /// <summary>Является ли столбец с индексом column чётным при данной нумерации.</summary>
        public static bool IsEvenColumn(int column, Numbering numbering)
        {
            int number = numbering == Numbering.FromOne ? column + 1 : column;
            return number % 2 == 0;
        }

        /// <summary>Индексы чётных столбцов.</summary>
        public List<int> GetEvenColumns(Numbering numbering)
        {
            List<int> columns = new List<int>();
            for (int j = 0; j < matrix.Columns; j++)
                if (IsEvenColumn(j, numbering))
                    columns.Add(j);
            return columns;
        }

        /// <summary>Количество нулевых элементов в столбце column.</summary>
        public int CountZerosInColumn(int column)
        {
            int count = 0;
            for (int i = 0; i < matrix.Rows; i++)
                if (matrix[i, column] == 0)
                    count++;
            return count;
        }

        /// <summary>Суммарное количество нулевых элементов в чётных столбцах.</summary>
        public int CountZerosInEvenColumns(Numbering numbering)
        {
            int count = 0;
            for (int j = 0; j < matrix.Columns; j++)
                if (IsEvenColumn(j, numbering))
                    count += CountZerosInColumn(j);
            return count;
        }
    }
}
