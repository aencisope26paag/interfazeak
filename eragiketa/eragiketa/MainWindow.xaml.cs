using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace eragiketa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_kalkulatu_Click(object sender, RoutedEventArgs e)
        {
            bool ok1 = double.TryParse(textbox_lehen.Text, out double a);
            bool ok2 = double.TryParse(textbox_bigarren.Text, out double b);
            bool ok3 = double.TryParse(textbox_hirugarren.Text, out double c);
            bool ok4 = double.TryParse(textbox_laugarren.Text, out double d);

            if (ok1 && ok2 && ok3 && ok4)
            {
                double result = (a + 2 * b + 3 * c + 4 * d) / 4.0;
                textbox_emaitza.Text = result.ToString();
            }
            else
            {
                textbox_emaitza.Text = "Berriro saiatu";
            }
        }

        private void button_garbitu_Click(object sender, RoutedEventArgs e)
        {
            textbox_lehen.Text = string.Empty;
            textbox_bigarren.Text = string.Empty;
            textbox_hirugarren.Text = string.Empty;
            textbox_laugarren.Text = string.Empty;
            textbox_emaitza.Text = string.Empty;
        }

        private void button_irten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}