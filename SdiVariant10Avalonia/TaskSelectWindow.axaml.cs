using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SdiVariant10
{
    /// <summary>
    /// Диалог выбора решаемой задачи.
    /// </summary>
    public partial class TaskSelectWindow : Window
    {
        public TaskSelectWindow() : this(new TaskOptions())
        {
        }

        public TaskSelectWindow(TaskOptions current)
        {
            InitializeComponent();
            Options = current.Clone();

            ZeroRowBox.IsChecked = current.FindZeroRow;
            EvenColumnsBox.IsChecked = current.CountZerosInEvenColumns;
            FromOneButton.IsChecked = current.Numbering == Numbering.FromOne;
            FromZeroButton.IsChecked = current.Numbering == Numbering.FromZero;
        }

        /// <summary>Выбранные задачи (действительны после закрытия по OK).</summary>
        public TaskOptions Options { get; private set; }

        private async void Ok_Click(object sender, RoutedEventArgs e)
        {
            bool zeroRow = ZeroRowBox.IsChecked == true;
            bool evenColumns = EvenColumnsBox.IsChecked == true;
            if (!zeroRow && !evenColumns)
            {
                await MessageBox.ShowAsync(this, "Выберите хотя бы одну задачу.", Title);
                return;
            }

            Options = new TaskOptions
            {
                FindZeroRow = zeroRow,
                CountZerosInEvenColumns = evenColumns,
                Numbering = FromOneButton.IsChecked == true ? Numbering.FromOne : Numbering.FromZero
            };
            Close(true);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close(false);
        }
    }
}
