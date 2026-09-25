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

namespace lagun_zerrenda
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

        private void bt_gehitu_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_berria.Text))
            {
                MessageBox.Show("Errorea gehitzean, testu hutsa.");
            }
            else if (listbox_lagunak.Items.Contains(tb_berria.Text))
            {
                MessageBox.Show("Errorea gehitzean, lagun hori zerrendan badago.");
            }
            else
            {
                listbox_lagunak.Items.Add(tb_berria.Text);
                tb_berria.Clear();
            }
        }

        private void bt_ezabatu_Click(object sender, RoutedEventArgs e)
        {
            if (listbox_lagunak.SelectedItem == null)
            {
                MessageBox.Show("Hautatu ezabatu behar diren datuak.");
            }
            else
            {
                listbox_lagunak.Items.Remove(listbox_lagunak.SelectedItem);
            }
        }

        private void bt_garbitu_Click(object sender, RoutedEventArgs e)
        {
            if (listbox_lagunak.Items.Count == 0)
            {
                MessageBox.Show("Zerrenda hutsik dago.");
            }
            else
            {
                listbox_lagunak.Items.Clear();
            }
        }
    }
}