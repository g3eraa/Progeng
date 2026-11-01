using System;

namespace SdiVariant5
{
    /// <summary>Операции над матрицей, не изменяющие исходные данные.</summary>
    public static class MatrixOperations
    {
        public static Matrix Transpose(Matrix matrix)
        {
            ArgumentNullException.ThrowIfNull(matrix);
            Matrix result = new Matrix(matrix.Columns, matrix.Rows);
            for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++)
                    result[j, i] = matrix[i, j];
            return result;
        }

        /// <summary>Суммы элементов каждой строки. long предотвращает переполнение int.</summary>
        public static long[] GetRowSums(Matrix matrix)
        {
            ArgumentNullException.ThrowIfNull(matrix);
            long[] sums = new long[matrix.Rows];
            for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++)
                    sums[i] += matrix[i, j];
            return sums;
        }

        public static long[] GetColumnSums(Matrix matrix)
        {
            ArgumentNullException.ThrowIfNull(matrix);
            long[] sums = new long[matrix.Columns];
            for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++)
                    sums[j] += matrix[i, j];
            return sums;
        }
    }
}
