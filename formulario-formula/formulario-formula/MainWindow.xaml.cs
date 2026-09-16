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

namespace formulario_formula
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _step = 1;
        private double _a, _b, _c, _d;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (btn?.Content?.ToString() == "garbitu")
            {
                tb_zenb.Text = string.Empty;
                return;
            }

            double value = 0;
            double.TryParse(tb_zenb.Text, out value);

            switch (_step)
            {
                case 1:
                    _a = value;
                    lb_zenb.Content = "2. Zenbakia";
                    tb_zenb.Clear();
                    _step = 2;
                    break;
                case 2:
                    _b = value;
                    lb_zenb.Content = "3. Zenbakia";
                    tb_zenb.Clear();
                    _step = 3;
                    break;
                case 3:
                    _c = value;
                    lb_zenb.Content = "4. Zenbakia";
                    tb_zenb.Clear();
                    _step = 4;
                    break;
                case 4:
                    _d = value;
                    double result = (_a + (_a * _b) + (_b * _c) + (_c * _d)) / 4.0;
                    lb_zenb.Content = "emaitza";
                    tb_zenb.Text = result.ToString();
                    bt_hurrengoa.Content = "garbitu";
                    _step = 5;
                    break;
                default:
                    break;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Intentionally left blank - no behavior required on text change for now.
        }
    }
}