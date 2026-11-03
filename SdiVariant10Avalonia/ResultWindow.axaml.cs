using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace SdiVariant10
{
    /// <summary>
    /// Окно вывода результата: массив с подсветкой и текстовый ответ.
    /// </summary>
    public partial class ResultWindow : Window
    {
        private static readonly IBrush ZeroRowBrush = Brushes.PaleGreen;
        private static readonly IBrush EvenColumnBrush = Brushes.LightSkyBlue;
        private static readonly IBrush CountedZeroBrush = Brushes.Gold;

        public ResultWindow() : this(new Matrix(1, 1), new Variant10Solver(new Matrix(1, 1)).Solve(new TaskOptions()))
        {
        }

        public ResultWindow(Matrix matrix, Variant10Result result)
        {
            InitializeComponent();

            // Если задача не выбрана, соответствующий список в result пустой — подсветки не будет.
            HashSet<int> zeroRows = new HashSet<int>(result.ZeroRows);
            HashSet<int> evenColumns = new HashSet<int>(result.EvenColumns);

            MatrixScroll.Content = MatrixView.BuildReadOnly(matrix, result.Options.FirstNumber,
                (i, j) =>
                {
                    if (evenColumns.Contains(j) && matrix[i, j] == 0)
                        return CountedZeroBrush;
                    if (zeroRows.Contains(i))
                        return ZeroRowBrush;
                    if (evenColumns.Contains(j))
                        return EvenColumnBrush;
                    return null;
                },
                i => zeroRows.Contains(i) ? ZeroRowBrush : null,
                j => evenColumns.Contains(j) ? EvenColumnBrush : null);

            ZeroRowSwatch.Background = ZeroRowBrush;
            EvenColumnSwatch.Background = EvenColumnBrush;
            CountedZeroSwatch.Background = CountedZeroBrush;
            ZeroRowLegend.IsVisible = result.Options.FindZeroRow;
            EvenColumnLegend.IsVisible = result.Options.CountZerosInEvenColumns;
            CountedZeroLegend.IsVisible = result.Options.CountZerosInEvenColumns;

            ReportBox.Text = Variant10Report.Build(matrix, result);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
