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

namespace erabiltzaile_pasahitza
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private String Erabiltzailea = "informatika";
        private String Pasahitza = "zubiri";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_onartu_Click(object sender, RoutedEventArgs e)
        {
            String sartutako_erabiltzailea = tb_erabiltzailea.Text;
            String sartutako_pasahitza = pb_pasahitza.Password;

            if (sartutako_erabiltzailea == Erabiltzailea && sartutako_pasahitza == Pasahitza)
            {
                lb_mezua.Content = $"Ongi etorri sistemara, {Erabiltzailea}";
            }
            else
            {
                lb_mezua.Content = "Identifikatu gabeko erabiltzailea";

            }
        }

        private void bt_garbitu_Click(object sender, RoutedEventArgs e)
        {
            tb_erabiltzailea.Text = "";
            pb_pasahitza.Clear();
            lb_mezua.Content = "";
        }

        private void bt_irten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}