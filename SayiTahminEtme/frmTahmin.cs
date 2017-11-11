using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminEtme
{
    public partial class frmTahmin : Form
    {
        public frmTahmin()
        {
            InitializeComponent();
        }

        int[] dizi = new int[4];
        int deneme = 1;
        

        private void btnBasla_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rakam;

            for( int i = 0; i < 4; i++)
            {
                if( i == 0 )
                    rakam = rnd.Next(1, 9);
                else
                    rakam = rnd.Next(0, 9);

                dizi[i] = rakam;

                int sayac = 0;

                for (int j = i; j >= 0; j--)
                {
                    if (dizi[j] == rakam)
                        sayac++;

                    if( sayac > 1 )
                    {
                        rakam = rnd.Next(0, 9);
                        dizi[i] = rakam;

                        j = i+1; // döngü başa dönünce azaltarak dönüyor
                        sayac = 0;
                    }
                    
                }                 
            }

            lblDurum.Text = "Sayı Oluşturuldu.";

            //test 
            /*
            for (int i = 0; i < 4; i++)
            {
                lblDurum.Text += dizi[i];
            } */
        }

        private void btnDene_Click(object sender, EventArgs e)
        {
            int sd = 0, yy=0; //sayı doğru , yer yanlış

            int[] tahmin = new int[4];

            int sayi = Convert.ToInt32(txtTahmin.Text);
            int girilen = sayi;
            int x = 1000;
            
            for (int i = 0; i < 4; i++)
            {
                if (i == 3)
                {
                    tahmin[i] = sayi % 10;
                }
                else
                {
                    tahmin[i] = sayi / x;
                    sayi -= tahmin[i]*x;
                    x /= 10;
                }    
               // lblSonuc.Text += ""+tahmin[i];
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (dizi[j] == tahmin[i])
                    {
                        if (i == j)
                            sd++;
                        else
                            yy++;
                    } 
                }
            }


            if (sd == 4)
            {
                MessageBox.Show("KAZANDINIZ");
                lblDurum.Text = ("Tebrikler Doğru Tahmin");
                lblSonuc.Text = "Sayı: ";
                for (int i = 0; i < 4; i++)
                {
                    lblSonuc.Text += dizi[i];
                }
                
            }
            else
                lblSonuc.Text = "+" + sd + " -" + yy;

            lstBoxSonuc.Items.Add(deneme + ". Deneme: " + girilen + ",    +" + sd + " ,-" + yy);
            deneme++;

            txtTahmin.Text = "";

        }

        //integer only textbox. Src: stackoverflow/question/463299
        private void txtTahmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnPes_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "Sayı: ";
            for (int i = 0; i < 4; i++)
            {
                lblSonuc.Text += dizi[i];
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstBoxSonuc.Items.Clear();
            lblSonuc.Text = "";
            deneme = 1;
            lblDurum.Text = " Tekrar Başlatın ";
        }

       
    }
}
