using System;

namespace SdiVariant5
{
    /// <summary>
    /// Двумерный целочисленный массив с изменяемым числом строк и столбцов.
    /// </summary>
    public class Matrix
    {
        public const int MinSize = 1;
        public const int MaxSize = 20;

        private int[,] data;

        public Matrix(int rows, int columns)
        {
            CheckSize(rows, columns);
            data = new int[rows, columns];
        }

        /// <summary>Количество строк.</summary>
        public int Rows => data.GetLength(0);

        /// <summary>Количество столбцов.</summary>
        public int Columns => data.GetLength(1);

        public int this[int row, int column]
        {
            get => data[row, column];
            set => data[row, column] = value;
        }

        /// <summary>
        /// Изменяет размер массива. Значения в общей части сохраняются,
        /// новые элементы равны нулю.
        /// </summary>
        public void Resize(int rows, int columns)
        {
            CheckSize(rows, columns);
            if (rows == Rows && columns == Columns)
                return;

            int[,] newData = new int[rows, columns];
            int commonRows = Math.Min(rows, Rows);
            int commonColumns = Math.Min(columns, Columns);
            for (int i = 0; i < commonRows; i++)
                for (int j = 0; j < commonColumns; j++)
                    newData[i, j] = data[i, j];

            data = newData;
        }

        /// <summary>
        /// Заполняет массив случайными числами из отрезка [min; max].
        /// </summary>
        public void FillRandom(int min, int max, Random random)
        {
            if (min > max)
                throw new ArgumentException("Нижняя граница больше верхней.");

            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    data[i, j] = random.Next(min, max + 1);
        }

        /// <summary>Обнуляет все элементы массива.</summary>
        public void Clear()
        {
            Array.Clear(data, 0, data.Length);
        }

        /// <summary>Обнуляет все элементы строки с индексом row.</summary>
        public void ClearRow(int row)
        {
            for (int j = 0; j < Columns; j++)
                data[row, j] = 0;
        }

        public Matrix Clone()
        {
            Matrix copy = new Matrix(Rows, Columns);
            copy.data = (int[,])data.Clone();
            return copy;
        }

        private static void CheckSize(int rows, int columns)
        {
            if (rows < MinSize || rows > MaxSize || columns < MinSize || columns > MaxSize)
                throw new ArgumentOutOfRangeException(
                    $"Размер массива должен быть от {MinSize} до {MaxSize}.");
        }
    }
}
