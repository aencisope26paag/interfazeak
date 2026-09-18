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

namespace intro_tekla
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private String testu1 = "";
        private String testu2 = "";
        private String testu3 = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                testu1 = tb_1.Text;
                testu2 = tb_2.Text;
                testu3 = tb_3.Text;

                tb_1.Text = testu3;
                tb_2.Text = testu1;
                tb_3.Text = testu2;
            }
        }

        private void bt_garbitu_Click(object sender, RoutedEventArgs e)
        {
            tb_1.Text = "";
            tb_2.Text = "";
            tb_3.Text = "";
        }

        private void bt_irten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}