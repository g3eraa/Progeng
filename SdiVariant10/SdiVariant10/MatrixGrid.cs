using System.Windows.Forms;

namespace SdiVariant10
{
    /// <summary>
    /// Вывод массива в DataGridView (используется в нескольких окнах).
    /// </summary>
    internal static class MatrixGrid
    {
        /// <summary>
        /// Показывает массив в таблице. firstNumber — номер первой строки/столбца в заголовках.
        /// </summary>
        public static void Show(DataGridView grid, Matrix matrix, int firstNumber = 1)
        {
            grid.ColumnCount = matrix.Columns;
            grid.RowCount = matrix.Rows;

            for (int j = 0; j < matrix.Columns; j++)
            {
                DataGridViewColumn column = grid.Columns[j];
                column.HeaderText = (j + firstNumber).ToString();
                column.ValueType = typeof(int);
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.Width = 52;
            }

            for (int i = 0; i < matrix.Rows; i++)
            {
                DataGridViewRow row = grid.Rows[i];
                row.HeaderCell.Value = (i + firstNumber).ToString();
                row.ErrorText = string.Empty;
                for (int j = 0; j < matrix.Columns; j++)
                    row.Cells[j].Value = matrix[i, j];
            }
        }
    }
}
