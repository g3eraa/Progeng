using System;
using System.Drawing;
using System.Windows.Forms;

namespace SdiVariant10
{
    /// <summary>
    /// Окно вывода результата: массив с подсветкой и текстовый ответ.
    /// </summary>
    public partial class ResultForm : Form
    {
        private static readonly Color ZeroRowColor = Color.PaleGreen;
        private static readonly Color EvenColumnColor = Color.LightSkyBlue;
        private static readonly Color CountedZeroColor = Color.Gold;

        public ResultForm(Matrix matrix, Variant10Result result)
        {
            InitializeComponent();

            MatrixGrid.Show(dgvMatrix, matrix, result.Options.FirstNumber);
            Highlight(matrix, result);
            SetupLegend(result.Options);
            txtResult.Text = Variant10Report.Build(matrix, result);
        }

        private void Highlight(Matrix matrix, Variant10Result result)
        {
            if (result.Options.CountZerosInEvenColumns)
            {
                foreach (int j in result.EvenColumns)
                {
                    DataGridViewColumn column = dgvMatrix.Columns[j];
                    SetColor(column.DefaultCellStyle, EvenColumnColor);
                    SetColor(column.HeaderCell.Style, EvenColumnColor);

                    for (int i = 0; i < matrix.Rows; i++)
                        if (matrix[i, j] == 0)
                            SetColor(dgvMatrix[j, i].Style, CountedZeroColor);
                }
            }

            if (result.Options.FindZeroRow)
            {
                foreach (int i in result.ZeroRows)
                {
                    DataGridViewRow row = dgvMatrix.Rows[i];
                    SetColor(row.DefaultCellStyle, ZeroRowColor);
                    SetColor(row.HeaderCell.Style, ZeroRowColor);
                }
            }
        }

        /// <summary>
        /// Задаёт цвет фона; выделение ячейки делаем таким же, чтобы оно не скрывало подсветку.
        /// </summary>
        private static void SetColor(DataGridViewCellStyle style, Color color)
        {
            style.BackColor = color;
            style.SelectionBackColor = color;
            style.SelectionForeColor = SystemColors.ControlText;
        }

        private void SetupLegend(TaskOptions options)
        {
            pnlZeroRow.BackColor = ZeroRowColor;
            pnlEvenColumn.BackColor = EvenColumnColor;
            pnlCountedZero.BackColor = CountedZeroColor;

            pnlZeroRow.Visible = lblZeroRow.Visible = options.FindZeroRow;
            pnlEvenColumn.Visible = lblEvenColumn.Visible = options.CountZerosInEvenColumns;
            pnlCountedZero.Visible = lblCountedZero.Visible = options.CountZerosInEvenColumns;
        }

        private void ResultForm_Shown(object sender, EventArgs e)
        {
            dgvMatrix.ClearSelection();
        }
    }
}
