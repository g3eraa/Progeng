using System.Collections.Generic;
using System.Text;

namespace SdiVariant5
{
    /// <summary>
    /// Текст ответа для окна результата.
    /// </summary>
    public static class Variant5Report
    {
        public static string Build(Matrix matrix, Variant5Result result)
        {
            int first = result.Options.FirstNumber;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Массив {matrix.Rows} × {matrix.Columns}, нумерация строк и столбцов с {first}.");

            if (result.Options.FindZeroRow)
            {
                sb.AppendLine();
                sb.AppendLine("Задача 1. Имеется ли в массиве строка, состоящая только из нулевых элементов?");
                if (result.HasZeroRow)
                    sb.AppendLine($"Ответ: да. Номера таких строк: {JoinNumbers(result.ZeroRows, first)}.");
                else
                    sb.AppendLine("Ответ: нет, в каждой строке есть ненулевой элемент.");
            }

            if (result.Options.CountZerosInEvenColumns)
            {
                sb.AppendLine();
                sb.AppendLine("Задача 2. Суммарное количество нулевых элементов в чётных столбцах.");
                if (result.EvenColumns.Count == 0)
                {
                    sb.AppendLine("Чётных столбцов в массиве нет.");
                }
                else
                {
                    for (int k = 0; k < result.EvenColumns.Count; k++)
                        sb.AppendLine($"   столбец {result.EvenColumns[k] + first}: нулей — {result.ZerosByEvenColumn[k]}");
                }
                sb.AppendLine($"Ответ: {result.ZerosInEvenColumns}.");
            }

            return sb.ToString();
        }

        private static string JoinNumbers(List<int> indices, int first)
        {
            List<string> numbers = new List<string>();
            foreach (int index in indices)
                numbers.Add((index + first).ToString());
            return string.Join(", ", numbers);
        }
    }
}
