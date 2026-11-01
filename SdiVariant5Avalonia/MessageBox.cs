using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;

namespace SdiVariant5
{
    /// <summary>
    /// Простое окно сообщения (в Avalonia нет готового MessageBox).
    /// </summary>
    internal static class MessageBox
    {
        public static Task ShowAsync(Window owner, string text, string title)
        {
            Button ok = new Button
            {
                Content = "OK",
                IsDefault = true,
                IsCancel = true,
                MinWidth = 80,
                HorizontalAlignment = HorizontalAlignment.Right,
                HorizontalContentAlignment = HorizontalAlignment.Center
            };

            Window window = new Window
            {
                Title = title,
                SizeToContent = SizeToContent.WidthAndHeight,
                CanResize = false,
                ShowInTaskbar = false,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Content = new StackPanel
                {
                    Margin = new Thickness(20),
                    Spacing = 16,
                    Children =
                    {
                        new TextBlock { Text = text, MaxWidth = 360, TextWrapping = TextWrapping.Wrap },
                        ok
                    }
                }
            };

            ok.Click += (sender, e) => window.Close();
            return window.ShowDialog(owner);
        }
    }
}
