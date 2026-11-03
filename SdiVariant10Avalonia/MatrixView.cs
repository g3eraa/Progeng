using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;

namespace SdiVariant10
{
    /// <summary>
    /// Построение таблицы для вывода массива (используется в нескольких окнах).
    /// </summary>
    internal static class MatrixView
    {
        private const double HeaderWidth = 44;
        private const double CellWidth = 56;
        private const double CellHeight = 30;

        private static readonly IBrush HeaderBrush = new SolidColorBrush(Color.Parse("#ECEEF1"));
        private static readonly IBrush LineBrush = new SolidColorBrush(Color.Parse("#C5CAD1"));

        /// <summary>
        /// Таблица rows × columns с заголовками. Ячейки создаёт createCell(i, j),
        /// firstNumber — номер первой строки/столбца в заголовках.
        /// </summary>
        public static Grid Build(int rows, int columns, int firstNumber, Func<int, int, Control> createCell,
            Func<int, IBrush> rowHeaderBrush = null, Func<int, IBrush> columnHeaderBrush = null)
        {
            Grid grid = new Grid
            {
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(8)
            };

            grid.ColumnDefinitions.Add(new ColumnDefinition(HeaderWidth, GridUnitType.Pixel));
            for (int j = 0; j < columns; j++)
                grid.ColumnDefinitions.Add(new ColumnDefinition(CellWidth, GridUnitType.Pixel));
            for (int i = 0; i <= rows; i++)
                grid.RowDefinitions.Add(new RowDefinition(CellHeight, GridUnitType.Pixel));

            Add(grid, Header(string.Empty, HeaderBrush), 0, 0);
            for (int j = 0; j < columns; j++)
                Add(grid, Header((j + firstNumber).ToString(), columnHeaderBrush?.Invoke(j) ?? HeaderBrush), 0, j + 1);

            for (int i = 0; i < rows; i++)
            {
                Add(grid, Header((i + firstNumber).ToString(), rowHeaderBrush?.Invoke(i) ?? HeaderBrush), i + 1, 0);
                for (int j = 0; j < columns; j++)
                    Add(grid, createCell(i, j), i + 1, j + 1);
            }

            return grid;
        }

        /// <summary>
        /// Таблица только для просмотра. cellBrush(i, j) задаёт цвет ячейки (null — белый).
        /// </summary>
        public static Grid BuildReadOnly(Matrix matrix, int firstNumber, Func<int, int, IBrush> cellBrush = null,
            Func<int, IBrush> rowHeaderBrush = null, Func<int, IBrush> columnHeaderBrush = null)
        {
            return Build(matrix.Rows, matrix.Columns, firstNumber,
                (i, j) => Cell(new TextBlock
                {
                    Text = matrix[i, j].ToString(),
                    HorizontalAlignment = HorizontalAlignment.Right,
                    VerticalAlignment = VerticalAlignment.Center,
                    Margin = new Thickness(0, 0, 8, 0)
                }, cellBrush?.Invoke(i, j) ?? Brushes.White),
                rowHeaderBrush, columnHeaderBrush);
        }

        /// <summary>Ячейка таблицы: рамка с содержимым.</summary>
        public static Border Cell(Control content, IBrush background)
        {
            return new Border
            {
                Background = background,
                BorderBrush = LineBrush,
                BorderThickness = new Thickness(0, 0, 1, 1),
                Child = content
            };
        }

        /// <summary>Выделяет ячейку красной рамкой (ошибка ввода) или снимает выделение.</summary>
        public static void SetError(Border cell, bool error)
        {
            cell.BorderBrush = error ? Brushes.Red : LineBrush;
            cell.BorderThickness = error ? new Thickness(2) : new Thickness(0, 0, 1, 1);
        }

        private static Border Header(string text, IBrush background)
        {
            return Cell(new TextBlock
            {
                Text = text,
                FontWeight = FontWeight.SemiBold,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            }, background);
        }

        private static void Add(Grid grid, Control control, int row, int column)
        {
            Grid.SetRow(control, row);
            Grid.SetColumn(control, column);
            grid.Children.Add(control);
        }
    }
}
