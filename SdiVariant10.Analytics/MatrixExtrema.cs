using System;

namespace SdiVariant10
{
    /// <summary>Поиск минимального и максимального элементов матрицы.</summary>
    public static class MatrixExtrema
    {
        public static int GetMinimum(Matrix matrix)
        {
            ArgumentNullException.ThrowIfNull(matrix);
            int minimum = matrix[0, 0];
            for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++)
                    if (matrix[i, j] < minimum)
                        minimum = matrix[i, j];
            return minimum;
        }

        public static int GetMaximum(Matrix matrix)
        {
            ArgumentNullException.ThrowIfNull(matrix);
            int maximum = matrix[0, 0];
            for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++)
                    if (matrix[i, j] > maximum)
                        maximum = matrix[i, j];
            return maximum;
        }
    }
}
