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

namespace egitura_aldagai_orokorrak
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

        private void bt_irten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_onartu_Click(object sender, RoutedEventArgs e)
        {
            if (tb_izena.Text != "" && tb_abizena1.Text != "" && tb_abizena2.Text != "" && tb_nan.Text != "")
            {
                Globalak.PertsonaGlobala.Izena = tb_izena.Text;
                Globalak.PertsonaGlobala.Abizena1 = tb_abizena1.Text;
                Globalak.PertsonaGlobala.Abizena2 = tb_abizena2.Text;
                Globalak.PertsonaGlobala.NAN = tb_nan.Text;

                MessageBox.Show("Datuak ondo gorde dira.");
            }
            else
            {
                MessageBox.Show("Mesedez, bete datu guztiak.");
            }
        }

        private void bt_kargatu_Click(object sender, RoutedEventArgs e)
        {
            BistaratuLeihoa bigarrenLeihoa = new BistaratuLeihoa();
            bigarrenLeihoa.ShowDialog();
        }
    }
}