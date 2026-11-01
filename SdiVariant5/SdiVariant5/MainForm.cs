using System;
using System.Windows.Forms;

namespace SdiVariant5
{
    /// <summary>
    /// Главное окно SDI-приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        private const int RandomMin = -3;
        private const int RandomMax = 3;

        private readonly Random random = new Random();
        private Matrix matrix = new Matrix(5, 6);
        private TaskOptions options = new TaskOptions();

        public MainForm()
        {
            InitializeComponent();
            matrix.FillRandom(RandomMin, RandomMax, random);
            RefreshView();
        }

        private void RefreshView()
        {
            MatrixGrid.Show(dgvMatrix, matrix);
            lblSize.Text = $"Массив: {matrix.Rows} × {matrix.Columns}";
            lblTasks.Text = "Задачи: " + DescribeOptions();
        }

        private string DescribeOptions()
        {
            string tasks;
            if (options.FindZeroRow && options.CountZerosInEvenColumns)
                tasks = "1 и 2";
            else if (options.FindZeroRow)
                tasks = "1";
            else
                tasks = "2";
            return $"{tasks}; нумерация с {options.FirstNumber}";
        }

        private void EditMatrix()
        {
            using (InputForm form = new InputForm(matrix))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    matrix = form.Matrix;
                    RefreshView();
                }
            }
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            EditMatrix();
        }

        private void dgvMatrix_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditMatrix();
        }

        private void miRandom_Click(object sender, EventArgs e)
        {
            matrix.FillRandom(RandomMin, RandomMax, random);
            RefreshView();
        }

        private void miChooseTask_Click(object sender, EventArgs e)
        {
            using (TaskSelectForm form = new TaskSelectForm(options))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    options = form.Options;
                    RefreshView();
                }
            }
        }

        private void miSolve_Click(object sender, EventArgs e)
        {
            Variant5Solver solver = new Variant5Solver(matrix);
            Variant5Result result = solver.Solve(options);
            using (ResultForm form = new ResultForm(matrix, result))
            {
                form.ShowDialog(this);
            }
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            using (AboutForm form = new AboutForm())
            {
                form.ShowDialog(this);
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
