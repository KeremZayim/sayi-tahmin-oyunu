using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rndm = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            RandomSayi = Convert.ToString(rndm.Next(1, 11));
        }

        int kalansure = 10;
        int yanlissayi = 0;
        int dogrusayi = 0;

        string RandomSayi;

        private void geriSayim_Tick(object sender, EventArgs e)
        {
            kalansure--;
            lblKalanSure.Text = Convert.ToString(kalansure);
            if (kalansure == 0)
            {
                yanlissayi++;
                lblYanlisSayi.Text = Convert.ToString(yanlissayi);
                geriSayim.Enabled = false;
                MessageBox.Show("Süreniz Bitti!");
                kalansure = 10;
                lblKalanSure.Text = "10";
                geriSayim.Enabled = true;

                RandomSayi = Convert.ToString(rndm.Next(1, 11));
            }
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (tbSayi.Text == RandomSayi)
            {
                geriSayim.Enabled = false;
                dogrusayi++;
                lblDogruSayi.Text = Convert.ToString(dogrusayi);
                MessageBox.Show("Tebrikler, Doğru Tahmin Yaptınız!");
                kalansure = 10;
                lblKalanSure.Text = Convert.ToString(kalansure);
                geriSayim.Enabled = true;
                RandomSayi = Convert.ToString(rndm.Next(1, 11));
            }
            else if (tbSayi.Text != RandomSayi)
            {
                if (Convert.ToInt32(tbSayi.Text) > Convert.ToInt32(RandomSayi))
                {
                    lblDurumAsagiYukari.Text = "Asagi";
                    lblDurumAsagiYukari.ForeColor = Color.Red;
                }
                else if (Convert.ToInt32(tbSayi.Text) < Convert.ToInt32(RandomSayi))
                {
                    lblDurumAsagiYukari.Text = "Yukari";
                    lblDurumAsagiYukari.ForeColor = Color.Green;
                }
            }
        }
    }
}
