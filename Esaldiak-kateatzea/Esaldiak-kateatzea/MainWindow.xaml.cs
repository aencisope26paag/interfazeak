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

namespace Esaldiak_kateatzea
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _acc = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtEsaldia1_Click(object sender, RoutedEventArgs e)
        {
            var text = textbox_esaldia.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;

            if (!string.IsNullOrEmpty(_acc)) _acc += " ";
            _acc += text;

            textbox_esaldia.Clear();
            bt_esaldia1.IsEnabled = false;
            bt_esaldia2.IsEnabled = true;
        }

        private void BtEsaldia2_Click(object sender, RoutedEventArgs e)
        {
            var text = textbox_esaldia.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;

            if (!string.IsNullOrEmpty(_acc)) _acc += " ";
            _acc += text;

            textbox_esaldia.Clear();
            bt_esaldia2.IsEnabled = false;
            bt_esaldia3.IsEnabled = true;
        }

        private void BtEsaldia3_Click(object sender, RoutedEventArgs e)
        {
            var text = textbox_esaldia.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;

            if (!string.IsNullOrEmpty(_acc)) _acc += " ";
            _acc += text;

            textbox_esaldia.Clear();
            bt_esaldia3.IsEnabled = false;
            bt_esaldia4.IsEnabled = true;
        }

        private void BtEsaldia4_Click(object sender, RoutedEventArgs e)
        {
            var text = textbox_esaldia.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;

            if (!string.IsNullOrEmpty(_acc)) _acc += " ";
            _acc += text;

            textbox_esaldia.Clear();
            bt_esaldia4.IsEnabled = false;
            bt_esaldia5.IsEnabled = true;
        }

        private void BtEsaldia5_Click(object sender, RoutedEventArgs e)
        {
            var text = textbox_esaldia.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;

            if (!string.IsNullOrEmpty(_acc)) _acc += " ";
            _acc += text;

            textbox_esaldia.Clear();
            bt_esaldia5.IsEnabled = false;
            bt_batu.IsEnabled = true;
        }

        private void BtBatu_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_acc))
            {
                MessageBox.Show("Testurik gabe konkatenatzeko.", "Batu", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            MessageBox.Show(_acc, "Konkatenatua", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtGarbitu_Click(object sender, RoutedEventArgs e)
        {
            textbox_esaldia.Clear();
            _acc = string.Empty;

            bt_esaldia1.IsEnabled = true;
            bt_esaldia2.IsEnabled = false;
            bt_esaldia3.IsEnabled = false;
            bt_esaldia4.IsEnabled = false;
            bt_esaldia5.IsEnabled = false;
            bt_batu.IsEnabled = false;
        }

        private void BtIrten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}