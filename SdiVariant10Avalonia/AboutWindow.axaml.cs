using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SdiVariant10
{
    /// <summary>
    /// Окно «О программе».
    /// </summary>
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
