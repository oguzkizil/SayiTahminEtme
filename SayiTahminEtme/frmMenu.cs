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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnTut_Click(object sender, EventArgs e)
        {
            frmTut tut = new frmTut();
            tut.ShowDialog();
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            frmTahmin tahmin = new frmTahmin();
            tahmin.ShowDialog();
        }
    }
}
