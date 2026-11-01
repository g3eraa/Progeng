using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace SdiVariant5
{
    /// <summary>
    /// Главное окно SDI-приложения.
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int RandomMin = -3;
        private const int RandomMax = 3;

        // На Mac сочетания клавиш с Cmd, на Windows и Linux — с Ctrl.
        private static readonly KeyModifiers CommandModifier =
            OperatingSystem.IsMacOS() ? KeyModifiers.Meta : KeyModifiers.Control;

        private readonly Random random = new Random();
        private Matrix matrix = new Matrix(5, 6);
        private TaskOptions options = new TaskOptions();

        public MainWindow()
        {
            InitializeComponent();

            EditItem.InputGesture = new KeyGesture(Key.E, CommandModifier);
            RandomItem.InputGesture = new KeyGesture(Key.R, CommandModifier);
            ChooseTaskItem.InputGesture = new KeyGesture(Key.T, CommandModifier);

            matrix.FillRandom(RandomMin, RandomMax, random);
            RefreshView();
        }

        private void RefreshView()
        {
            MatrixScroll.Content = MatrixView.BuildReadOnly(matrix, 1);
            SizeText.Text = $"Массив: {matrix.Rows} × {matrix.Columns}";
            TasksText.Text = "Задачи: " + DescribeOptions();
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

        private async void EditMatrix()
        {
            InputWindow window = new InputWindow(matrix);
            if (await window.ShowDialog<bool>(this))
            {
                matrix = window.Matrix;
                RefreshView();
            }
        }

        private void FillRandom()
        {
            matrix.FillRandom(RandomMin, RandomMax, random);
            RefreshView();
        }

        private async void ChooseTask()
        {
            TaskSelectWindow window = new TaskSelectWindow(options);
            if (await window.ShowDialog<bool>(this))
            {
                options = window.Options;
                RefreshView();
            }
        }

        private async void Solve()
        {
            Variant5Solver solver = new Variant5Solver(matrix);
            Variant5Result result = solver.Solve(options);
            await new ResultWindow(matrix, result).ShowDialog(this);
        }

        private async void ShowAbout()
        {
            await new AboutWindow().ShowDialog(this);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Handled)
                return;

            if (e.KeyModifiers == KeyModifiers.None && e.Key == Key.F5)
                Solve();
            else if (e.KeyModifiers == KeyModifiers.None && e.Key == Key.F1)
                ShowAbout();
            else if (e.KeyModifiers == CommandModifier && e.Key == Key.E)
                EditMatrix();
            else if (e.KeyModifiers == CommandModifier && e.Key == Key.R)
                FillRandom();
            else if (e.KeyModifiers == CommandModifier && e.Key == Key.T)
                ChooseTask();
            else
                return;

            e.Handled = true;
        }

        private void Edit_Click(object sender, RoutedEventArgs e) => EditMatrix();

        private void Matrix_DoubleTapped(object sender, TappedEventArgs e) => EditMatrix();

        private void Random_Click(object sender, RoutedEventArgs e) => FillRandom();

        private void ChooseTask_Click(object sender, RoutedEventArgs e) => ChooseTask();

        private void Solve_Click(object sender, RoutedEventArgs e) => Solve();

        private void About_Click(object sender, RoutedEventArgs e) => ShowAbout();

        private void Exit_Click(object sender, RoutedEventArgs e) => Close();
    }
}
