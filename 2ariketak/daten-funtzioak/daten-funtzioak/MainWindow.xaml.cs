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

namespace daten_funtzioak
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

        private void bt_exekutatu_Click(object sender, RoutedEventArgs e)
        {
            tb_orain.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            tb_gaur.Text = DateTime.Now.ToString("dd-MM-yyyy");
            tb_gaur_h.Text = DateTime.Now.ToString("HH:mm:ss");

            // Lehen lehioa
            Window1 leihoa = new Window1();
            if (leihoa.ShowDialog() == true)
            {
                tb_data_batu.Text = leihoa.EmaitzaTextua;
            }

            // Bigarren lehioa
            Window2 leihoa2 = new Window2();
            if (leihoa2.ShowDialog() == true)
            {
                tb_data_aldea.Text = leihoa2.EmaitzaTextua;
            }

        }

        private void bt_garbitu_Click(object sender, RoutedEventArgs e)
        {
            tb_orain.Text = "";
            tb_gaur.Text = "";
            tb_gaur_h.Text = "";
            tb_data_batu.Text = "";
            tb_data_aldea.Text = "";
        }

        private void bt_irten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}