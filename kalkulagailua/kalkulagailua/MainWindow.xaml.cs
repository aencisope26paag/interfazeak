using System.Data;
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

namespace kalkulagailua
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

        private void bt_0_Click(object sender, RoutedEventArgs e)
        {
            String botoia = "0";
            tb_testua.Text += botoia;
        }

        private void bt_1_Click(object sender, RoutedEventArgs e)
        {
            String botoia = "1";
            tb_testua.Text += botoia;
        }

        private void bt_2_Click(object sender, RoutedEventArgs e)
        {
            String botoia = "2";
            tb_testua.Text += botoia;
        }

        private void bt_3_Click(object sender, RoutedEventArgs e)
        {
            String botoia = "3";
            tb_testua.Text += botoia;
        }

        private void bt_4_Click(object sender, RoutedEventArgs e)
        {
            String botoia = "4";
            tb_testua.Text += botoia;
        }

        private void bt_5_Click(object sender, RoutedEventArgs e)
        {
            String botoia = "5";
            tb_testua.Text += botoia;
        }

        private void bt_6_Click(object sender, RoutedEventArgs e)
        {
            String botoia = "6";
            tb_testua.Text += botoia;
        }

        private void bt_7_Click(object sender, RoutedEventArgs e)
        {
            String botoia = "7";
            tb_testua.Text += botoia;
        }

        private void bt_8_Click(object sender, RoutedEventArgs e)
        {
            String botoia = "8";
            tb_testua.Text += botoia;
        }

        private void bt_9_Click(object sender, RoutedEventArgs e)
        {
            String botoia = "9";
            tb_testua.Text += botoia;
        }

        private void bt_koma_Click(object sender, RoutedEventArgs e)
        {
            String botoia = ".";
            tb_testua.Text += botoia;
        }

        private void bt_zati_Click(object sender, RoutedEventArgs e)
        {
            String botoia = "/";
            tb_testua.Text += botoia;
        }

        private void bt_ken_Click(object sender, RoutedEventArgs e)
        {
            String botoia = "-";
            tb_testua.Text += botoia;
        }

        private void bt_bider_Click(object sender, RoutedEventArgs e)
        {
            String botoia = "*";
            tb_testua.Text += botoia;
        }

        private void bt_gehi_Click(object sender, RoutedEventArgs e)
        {
            String botoia = "+";
            tb_testua.Text += botoia;
        }

        private void bt_berdin_Click(object sender, RoutedEventArgs e)
        {
            string kalkulua = tb_testua.Text;

            try
            {
                var emaitza = new DataTable().Compute(kalkulua,null);
                tb_testua.Text = emaitza.ToString();
            }
            catch (Exception)
            {
                tb_testua.Text = "Syntax Error";
            }
        }

        private void bt_c_Click(object sender, RoutedEventArgs e)
        {
            tb_testua.Text = "";
        }

        private void bt_ce_Click(object sender, RoutedEventArgs e)
        {
            tb_testua.Text = "";
        }

        private void bt_ehuneko_Click(object sender, RoutedEventArgs e)
        {
            tb_testua.Text += "/100";
        }
    }
}