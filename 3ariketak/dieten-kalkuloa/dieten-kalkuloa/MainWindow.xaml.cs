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

namespace dieten_kalkuloa
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

        private void kalkulatu(object sender, RoutedEventArgs e)
        {
            if (!IsInitialized) return;

            double dietak = 0;
            double bidaiak = 0;
            double lana = 0;

            if (cb_gosaria.IsChecked == true) dietak += 3;
            if (cb_bazkaria.IsChecked == true) dietak += 9;
            if (cb_afaria.IsChecked == true) dietak += 15.5;

            tb_1.Text = dietak.ToString("0.00") + " €";

            double.TryParse(tb_b_km.Text, out double km);
            double.TryParse(tb_b_o.Text, out double orduak);

            bidaiak = (km * 0.25) + (orduak * 18);

            tb_2.Text = bidaiak.ToString("0.00") + " €";

            double.TryParse(tb_l_o.Text, out double orduak_lana);

            lana = orduak_lana * 42;

            tb_3.Text = lana.ToString("0.00") + " €";

            double guztira = dietak + bidaiak + lana;
            tb_guztira.Text = guztira.ToString("0.00") + " €";
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Keyboard.FocusedElement is UIElement elementWithFocus)
                {
                    elementWithFocus.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                    e.Handled = true;
                }
            }
        }

        private void bt_irten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_garbitu_Click(object sender, RoutedEventArgs e)
        {
            cb_gosaria.IsChecked = false;
            cb_bazkaria.IsChecked = false;
            cb_afaria.IsChecked = false;

            tb_b_km.Text = "";
            tb_b_o.Text = "";
            tb_l_o.Text = "";

            tb_b_km.Focus();
        }
    }
}