using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media;

namespace SdiVariant5
{
    /// <summary>
    /// Окно ввода исходных данных: размер массива и значения элементов.
    /// Работает с копией массива; изменения применяются только по кнопке OK.
    /// </summary>
    public partial class InputWindow : Window
    {
        private readonly Random random = new Random();
        private readonly Matrix matrix;
        private readonly HashSet<(int Row, int Column)> invalidCells = new HashSet<(int Row, int Column)>();
        private TextBox[,] cells;
        private int currentRow = -1;
        private bool loading = true;

        public InputWindow() : this(new Matrix(3, 3))
        {
        }

        public InputWindow(Matrix source)
        {
            InitializeComponent();
            matrix = source.Clone();

            RowsBox.Minimum = Matrix.MinSize;
            RowsBox.Maximum = Matrix.MaxSize;
            ColumnsBox.Minimum = Matrix.MinSize;
            ColumnsBox.Maximum = Matrix.MaxSize;
            RowsBox.Value = matrix.Rows;
            ColumnsBox.Value = matrix.Columns;
            loading = false;

            ShowMatrix();
        }

        /// <summary>Отредактированный массив.</summary>
        public Matrix Matrix => matrix;

        private void ShowMatrix()
        {
            invalidCells.Clear();
            currentRow = -1;
            cells = new TextBox[matrix.Rows, matrix.Columns];
            MatrixScroll.Content = MatrixView.Build(matrix.Rows, matrix.Columns, 1, CreateCell);
            UpdateHint();
        }

        private Control CreateCell(int row, int column)
        {
            TextBox box = new TextBox
            {
                Text = matrix[row, column].ToString(),
                TextAlignment = TextAlignment.Right,
                VerticalContentAlignment = VerticalAlignment.Center,
                MinWidth = 0,
                MinHeight = 0,
                Padding = new Thickness(4, 0, 8, 0),
                BorderThickness = new Thickness(0),
                CornerRadius = new CornerRadius(0),
                Background = Brushes.White
            };
            box.TextChanged += (sender, e) => CellTextChanged(row, column);
            box.GotFocus += (sender, e) => currentRow = row;
            cells[row, column] = box;
            return MatrixView.Cell(box, Brushes.White);
        }

        private void CellTextChanged(int row, int column)
        {
            TextBox box = cells[row, column];
            bool valid = int.TryParse(box.Text?.Trim(), out int value);
            if (valid)
            {
                matrix[row, column] = value;
                invalidCells.Remove((row, column));
            }
            else
            {
                invalidCells.Add((row, column));
            }

            MatrixView.SetError((Border)box.Parent, !valid);
            UpdateHint();
        }

        private void UpdateHint()
        {
            if (invalidCells.Count == 0)
            {
                HintText.Text = "Щёлкните по ячейке и введите целое число";
                HintText.Foreground = Brushes.Gray;
            }
            else
            {
                HintText.Text = $"Не целых чисел: {invalidCells.Count} (выделены красным)";
                HintText.Foreground = Brushes.Red;
            }
        }

        private void Size_ValueChanged(object sender, NumericUpDownValueChangedEventArgs e)
        {
            if (loading || RowsBox.Value == null || ColumnsBox.Value == null)
                return;

            matrix.Resize((int)RowsBox.Value.Value, (int)ColumnsBox.Value.Value);
            ShowMatrix();
        }

        private async void Random_Click(object sender, RoutedEventArgs e)
        {
            int min = (int)(MinBox.Value ?? 0);
            int max = (int)(MaxBox.Value ?? 0);
            if (min > max)
            {
                await MessageBox.ShowAsync(this, "Нижняя граница больше верхней.", Title);
                return;
            }

            matrix.FillRandom(min, max, random);
            ShowMatrix();
        }

        private async void ClearRow_Click(object sender, RoutedEventArgs e)
        {
            int row = currentRow;
            if (row < 0)
            {
                await MessageBox.ShowAsync(this, "Щёлкните по ячейке в строке, которую нужно обнулить.", Title);
                return;
            }

            matrix.ClearRow(row);
            ShowMatrix();
            cells[row, 0].Focus();
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            matrix.Clear();
            ShowMatrix();
        }

        private async void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (invalidCells.Count > 0)
            {
                await MessageBox.ShowAsync(this, "Исправьте ячейки, выделенные красным: в них должны быть целые числа.", Title);
                return;
            }

            Close(true);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close(false);
        }
    }
}
