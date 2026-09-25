using System;
using System.Windows;

namespace daten_funtzioak
{
    public partial class Window1 : Window
    {
        public string EmaitzaTextua = "";
        private DateTime sartutakoData;
        private int pausoa = 1;

        public Window1()
        {
            InitializeComponent();
        }

        private void bt_utzi_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_onartu_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (pausoa == 1)
                {
                    sartutakoData = Convert.ToDateTime(tb_datak.Text);
                    lb_datak.Content = $"Sartu datari gehitu behar zaion \nhilabete kopurua";
                    tb_datak.Text = "";
                    pausoa = 2;
                }
                else if (pausoa == 2)
                {
                    int hilabeteak = Convert.ToInt32(tb_datak.Text);
                    DateTime dataBerria = sartutakoData.AddMonths(hilabeteak);

                    EmaitzaTextua = $"Hasierako data: {sartutakoData:dd/MM/yyyy}, gehitutako hilabeteak: {hilabeteak}, data berria: {dataBerria:dd/MM/yyyy}";

                    this.DialogResult = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sartu datuak ondo edo sakatu utzi", "Errorea");
                tb_datak.Text = "";
            }
        }
    }
}