using System;

namespace SdiVariant10
{
    /// <summary>Подсчёт положительных и отрицательных элементов; нули не учитываются.</summary>
    public static class MatrixSignCounter
    {
        public static int CountPositive(Matrix matrix)
        {
            ArgumentNullException.ThrowIfNull(matrix);
            int count = 0;
            for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++)
                    if (matrix[i, j] > 0)
                        count++;
            return count;
        }

        public static int CountNegative(Matrix matrix)
        {
            ArgumentNullException.ThrowIfNull(matrix);
            int count = 0;
            for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++)
                    if (matrix[i, j] < 0)
                        count++;
            return count;
        }
    }
}
