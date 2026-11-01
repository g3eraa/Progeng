using System;
using System.Windows.Forms;

namespace SdiVariant5
{
    /// <summary>
    /// Окно ввода исходных данных: размер массива и значения элементов.
    /// Работает с копией массива; изменения применяются только по кнопке OK.
    /// </summary>
    public partial class InputForm : Form
    {
        private readonly Random random = new Random();
        private readonly Matrix matrix;
        private bool loading;

        public InputForm(Matrix source)
        {
            InitializeComponent();
            matrix = source.Clone();

            loading = true;
            nudRows.Minimum = Matrix.MinSize;
            nudRows.Maximum = Matrix.MaxSize;
            nudColumns.Minimum = Matrix.MinSize;
            nudColumns.Maximum = Matrix.MaxSize;
            nudRows.Value = matrix.Rows;
            nudColumns.Value = matrix.Columns;
            loading = false;

            ShowMatrix();
        }

        /// <summary>Отредактированный массив.</summary>
        public Matrix Matrix => matrix;

        private void ShowMatrix()
        {
            loading = true;
            MatrixGrid.Show(dgvMatrix, matrix);
            loading = false;
        }

        /// <summary>
        /// Завершает редактирование текущей ячейки. Если введено не число — отменяет ввод.
        /// </summary>
        private void FinishEdit()
        {
            if (!dgvMatrix.EndEdit())
                dgvMatrix.CancelEdit();
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;

            FinishEdit();
            matrix.Resize((int)nudRows.Value, (int)nudColumns.Value);
            ShowMatrix();
        }

        private void dgvMatrix_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!dgvMatrix.IsCurrentCellInEditMode)
                return;

            string text = Convert.ToString(e.FormattedValue);
            if (!int.TryParse(text, out _))
            {
                dgvMatrix.Rows[e.RowIndex].ErrorText = "Введите целое число";
                e.Cancel = true;
            }
        }

        private void dgvMatrix_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvMatrix.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void dgvMatrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (loading || e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            object value = dgvMatrix[e.ColumnIndex, e.RowIndex].Value;
            matrix[e.RowIndex, e.ColumnIndex] = Convert.ToInt32(value);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int min = (int)nudMin.Value;
            int max = (int)nudMax.Value;
            if (min > max)
            {
                MessageBox.Show(this, "Нижняя граница больше верхней.", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FinishEdit();
            matrix.FillRandom(min, max, random);
            ShowMatrix();
        }

        private void btnClearRow_Click(object sender, EventArgs e)
        {
            FinishEdit();
            DataGridViewCell cell = dgvMatrix.CurrentCell;
            if (cell == null)
            {
                MessageBox.Show(this, "Выделите ячейку в строке, которую нужно обнулить.", Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int row = cell.RowIndex;
            matrix.ClearRow(row);
            ShowMatrix();
            dgvMatrix.CurrentCell = dgvMatrix[cell.ColumnIndex, row];
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            FinishEdit();
            matrix.Clear();
            ShowMatrix();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!dgvMatrix.EndEdit())
                return;

            // Чтение Value применяет число, набранное в поле, но ещё не подтверждённое.
            if (nudRows.Value != matrix.Rows || nudColumns.Value != matrix.Columns)
                nudSize_ValueChanged(this, EventArgs.Empty);

            DialogResult = DialogResult.OK;
        }

        private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // При отмене закрываем окно, даже если в ячейке осталось неверное значение.
            if (DialogResult != DialogResult.OK)
                e.Cancel = false;
        }
    }
}
