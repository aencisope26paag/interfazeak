using System;
using System.Windows;

namespace daten_funtzioak
{
    public partial class Window2 : Window
    {
        public string EmaitzaTextua = "";
        private DateTime lehenData;
        private int pasoa = 1;

        public Window2()
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
                if (pasoa == 1)
                {
                    lehenData = Convert.ToDateTime(tb_datak.Text);
                    lb_datak.Content = "Sartu bigarren data (dd/MM/yyyy):";
                    tb_datak.Text = "";
                    pasoa = 2;
                }
                else if (pasoa == 2)
                {
                    DateTime bigarrenData = Convert.ToDateTime(tb_datak.Text);


                    TimeSpan aldea = bigarrenData - lehenData;
                    int egunak = Math.Abs(aldea.Days);

                    EmaitzaTextua = $"1. data: {lehenData:dd/MM/yyyy}, 2. data: {bigarrenData:dd/MM/yyyy}, aldea: {egunak} egun";

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