using System.Windows;
using System.Windows.Media;

namespace dieten_kalkuloa
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void moztu_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEditor.Text))
            {
                Clipboard.SetText(txtEditor.Text);
                txtEditor.Text = "";
            }
        }

        private void kopiatu_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEditor.Text))
            {
                Clipboard.SetText(txtEditor.Text);
            }
        }

        private void itsasi_Click(object sender, RoutedEventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                txtEditor.Text += Clipboard.GetText();
            }
        }

        private void ezabatu_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Text = "";
        }

        private void fontArial_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.FontFamily = new FontFamily("Arial");
        }

        private void fontCourier_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.FontFamily = new FontFamily("Courier New");
        }

        private void fontImpact_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.FontFamily = new FontFamily("Impact");
        }

        private void fontSymbol_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.FontFamily = new FontFamily("Symbol");
        }
    }
}