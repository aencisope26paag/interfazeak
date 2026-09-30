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

namespace letra_motak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private void checkText()
        {
            if (tb_testua.Text.Length == 0)
            {
                lb_mezua.Content = "Ez dago testurik.";
            }
            else
            {
                lb_mezua.Content = "";
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_comic_Click(object sender, RoutedEventArgs e)
        {
            checkText();
            tb_testua.FontFamily = new FontFamily("Comic Sans MS");
        }

        private void bt_lodia_Click(object sender, RoutedEventArgs e)
        {
            checkText();
            tb_testua.FontWeight = FontWeights.Bold;
        }

        private void bt_marratua_Click(object sender, RoutedEventArgs e)
        {
            checkText();
            tb_testua.TextDecorations = TextDecorations.Baseline;
        }

        private void bt_tamaina1_Click(object sender, RoutedEventArgs e)
        {
            tb_testua.FontSize += 1;
        }

        private void bt_courier_Click(object sender, RoutedEventArgs e)
        {
            checkText();
            tb_testua.FontFamily = new FontFamily("Courier New");
        }

        private void bt_etzaina_Click(object sender, RoutedEventArgs e)
        {
            checkText();
            tb_testua.FontStyle = FontStyles.Italic;
        }

        private void bt_azpimarrat_Click(object sender, RoutedEventArgs e)
        {
            checkText();
            tb_testua.TextDecorations = TextDecorations.Underline;
        }

        private void bt_tamaina2_Click(object sender, RoutedEventArgs e)
        {
            checkText();
            tb_testua.FontSize -= 1;
        }

        private void bt_irten_Click(object sender, RoutedEventArgs e)
        {
            checkText();
            this.Close();
        }

        private void bt_hautatu_Click(object sender, RoutedEventArgs e)
        {
            String hautatutakoa = tb_testua.SelectedText;
            int karaktereak = tb_testua.Text.Length;

            if (karaktereak > 0)
            {
                lb_mezua.Content = "Hautatutako testua: "+hautatutakoa+". Testuak "+karaktereak+ " karaktere ditu.";
            }
            else
            {
                lb_mezua.Content = "Ez dago testurik hautatuta. Testuak " + karaktereak + " karaktere ditu.";
            }
        }
    }
}