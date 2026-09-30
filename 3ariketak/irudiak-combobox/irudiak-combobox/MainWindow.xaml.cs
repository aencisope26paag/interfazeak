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

namespace irudiak_combobox
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (cb_irudiak.SelectedIndex == 0)
            {
                img_1.Visibility = Visibility.Visible;
                img_2.Visibility = Visibility.Hidden;
                img_3.Visibility = Visibility.Hidden;
            }
            if (cb_irudiak.SelectedIndex == 1)
            {
                img_1.Visibility = Visibility.Hidden;
                img_2.Visibility = Visibility.Visible;
                img_3.Visibility = Visibility.Hidden;
            }
            if (cb_irudiak.SelectedIndex == 2)
            {
                img_1.Visibility = Visibility.Hidden;
                img_2.Visibility = Visibility.Hidden;
                img_3.Visibility = Visibility.Visible;
            }
        }

        private void cb_4_Checked(object sender, RoutedEventArgs e)
        {
            img_4.Visibility = Visibility.Visible;
        }

        private void cb_4_Unchecked(object sender, RoutedEventArgs e)
        {
            img_4.Visibility = Visibility.Hidden;
        }

        private void cb_5_Checked(object sender, RoutedEventArgs e)
        {
            img_5.Visibility = Visibility.Visible;
        }

        private void cb_5_Unchecked(object sender, RoutedEventArgs e)
        {
            img_5.Visibility = Visibility.Hidden;
        }

        private void cb_6_Checked(object sender, RoutedEventArgs e)
        {
            img_6.Visibility = Visibility.Visible;
        }

        private void cb_6_Unchecked(object sender, RoutedEventArgs e)
        {
            img_6.Visibility = Visibility.Hidden;
        }

    }
}