namespace SdiVariant5
{
    /// <summary>
    /// С какого числа нумеруются строки и столбцы.
    /// От этого зависит, какие столбцы считаются чётными.
    /// </summary>
    public enum Numbering
    {
        /// <summary>1, 2, 3, … — чётные столбцы: 2, 4, 6, …</summary>
        FromOne,

        /// <summary>0, 1, 2, … (индексы C#) — чётные столбцы: 0, 2, 4, …</summary>
        FromZero
    }

    /// <summary>
    /// Задачи, выбранные пользователем в диалоге «Выбор задачи».
    /// </summary>
    public class TaskOptions
    {
        /// <summary>Задача 1: есть ли строка, состоящая только из нулей.</summary>
        public bool FindZeroRow { get; set; } = true;

        /// <summary>Задача 2: суммарное количество нулей в чётных столбцах.</summary>
        public bool CountZerosInEvenColumns { get; set; } = true;

        public Numbering Numbering { get; set; } = Numbering.FromOne;

        /// <summary>Номер, который получает элемент с индексом 0.</summary>
        public int FirstNumber => Numbering == Numbering.FromOne ? 1 : 0;

        public bool AnySelected => FindZeroRow || CountZerosInEvenColumns;

        public TaskOptions Clone()
        {
            return (TaskOptions)MemberwiseClone();
        }
    }
}
