using System.Windows;

namespace egitura_aldagai_orokorrak
{
    public partial class BistaratuLeihoa : Window
    {
        public BistaratuLeihoa()
        {
            InitializeComponent();

            lb_name.Content = "Izena: " + Globalak.PertsonaGlobala.Izena;
            lb_surname1.Content = "1. Abizena: " + Globalak.PertsonaGlobala.Abizena1;
            lb_surname2.Content = "2. Abizena: " + Globalak.PertsonaGlobala.Abizena2;
            lb_dni.Content = "NAN: " + Globalak.PertsonaGlobala.NAN;
        }

        private void bt_irten2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}