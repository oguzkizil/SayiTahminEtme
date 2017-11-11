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
    public partial class frmTut : Form
    {
        public frmTut()
        {
            InitializeComponent();
        }

        int yy;
        int sd;
        private int tur = 1;

        int[] turindex = new int[6];
        
        
        frmOlasilik frm = new frmOlasilik();

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (txtYY.Text == "")
                yy = 0;
            else
                yy = Convert.ToInt32(txtYY.Text);

            if (txtSD.Text == "")
                sd = 0;
            else
                sd = Convert.ToInt32(txtSD.Text);

            lstBoxSonuc.Items.Add(tur+". Deneme= "+ txtTahmin.Text+"     +"+sd+" -"+yy);
            tur++;

            if(sd==4)
                MessageBox.Show("Kolaydı.");

            string ara = (sd +""+ yy);

            tahminOlustur(ara);
            //MessageBox.Show(ara); //test

            txtSD.Text = "";
            txtYY.Text = "";
        }

        public void tahminOlustur(string aranan)
        {
            string sonuc="";
            
            switch (tur)
            {
                case 1: turindex[0] = 0;
                    break;
                case 2:
                    {
                        for (int i=0; i < frm.tvwOlasilik.Nodes[turindex[0]].Nodes.Count; i++)
                        {
                            if (aranan == frm.tvwOlasilik.Nodes[turindex[0]].Nodes[i].Name)
                            {
                                sonuc = Convert.ToString(frm.tvwOlasilik.Nodes[turindex[0]].Nodes[i].Tag);
                                turindex[1] = i;
                            }

                        }
                    }
                    break;
                case 3:
                    {
                        for (int i = 0; i < frm.tvwOlasilik.Nodes[turindex[0]].Nodes[turindex[1]].Nodes.Count; i++)
                        {
                            if (aranan == frm.tvwOlasilik.Nodes[turindex[0]].Nodes[turindex[1]].Nodes[i].Name)
                            {
                                sonuc = Convert.ToString(frm.tvwOlasilik.Nodes[turindex[0]].Nodes[turindex[1]].Nodes[i].Tag);
                                turindex[2] = i;
                            }

                        }
                    }

                    break;
                case 4:
                    {
                        for (int i = 0; i < frm.tvwOlasilik.Nodes[turindex[0]].Nodes[turindex[1]].Nodes[turindex[2]].Nodes.Count; i++)
                        {
                            if (aranan == frm.tvwOlasilik.Nodes[turindex[0]].Nodes[turindex[1]].Nodes[turindex[2]].Nodes[i].Name)
                            {
                                sonuc = Convert.ToString(frm.tvwOlasilik.Nodes[turindex[0]].Nodes[turindex[1]].Nodes[turindex[2]].Nodes[i].Tag);
                                turindex[3] = i;
                            }

                        }
                    }
                    break;
                case 5:
                    {
                        for (int i = 0; i < frm.tvwOlasilik.Nodes[turindex[0]].Nodes[turindex[1]].Nodes[turindex[2]].Nodes[turindex[3]].Nodes.Count; i++)
                        {
                            if (aranan == frm.tvwOlasilik.Nodes[turindex[0]].Nodes[turindex[1]].Nodes[turindex[2]].Nodes[turindex[3]].Nodes[i].Name)
                            {
                                sonuc = Convert.ToString(frm.tvwOlasilik.Nodes[turindex[0]].Nodes[turindex[1]].Nodes[turindex[2]].Nodes[turindex[3]].Nodes[i].Tag);
                                turindex[4] = i;
                            }

                        }
                    }
                    break;
                case 6:
                    {
                        for (int i = 0; i < frm.tvwOlasilik.Nodes[turindex[0]].Nodes[turindex[1]].Nodes[turindex[2]].Nodes[turindex[3]].Nodes[turindex[4]].Nodes.Count; i++)
                        {
                            if (aranan == frm.tvwOlasilik.Nodes[turindex[0]].Nodes[turindex[1]].Nodes[turindex[2]].Nodes[turindex[3]].Nodes[turindex[4]].Nodes[i].Name)
                            {
                                sonuc = Convert.ToString(frm.tvwOlasilik.Nodes[turindex[0]].Nodes[turindex[1]].Nodes[turindex[2]].Nodes[turindex[3]].Nodes[turindex[4]].Nodes[i].Tag);
                                turindex[5] = i;
                            }

                        }
                    }
                    break;
                case 7:
                    {
                        for (int i = 0; i < frm.tvwOlasilik.Nodes[turindex[0]].Nodes[turindex[1]].Nodes[turindex[2]].Nodes[turindex[3]].Nodes[turindex[4]].Nodes[turindex[5]].Nodes.Count; i++)
                        {
                            if (aranan == frm.tvwOlasilik.Nodes[turindex[0]].Nodes[turindex[1]].Nodes[turindex[2]].Nodes[turindex[3]].Nodes[turindex[4]].Nodes[turindex[5]].Nodes[i].Name)
                            {
                                sonuc = Convert.ToString(frm.tvwOlasilik.Nodes[turindex[0]].Nodes[turindex[1]].Nodes[turindex[2]].Nodes[turindex[3]].Nodes[turindex[4]].Nodes[turindex[5]].Nodes[i].Tag);
                                turindex[6] = i;
                            }

                        }
                    }
                    break;
            }
            txtTahmin.Text = sonuc;
        }

        

        private void btnOlasilik_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
        }
    }
}
