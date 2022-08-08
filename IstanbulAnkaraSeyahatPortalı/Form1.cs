using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IstanbulAnkaraSeyahatPortalı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtKullanici.Text=="admin34" && txtSifre.Text == "12300")
            {
                FrmBiletAlani yolcu = new FrmBiletAlani();
                yolcu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış giriş bilgileri yapılmıştır.", "DİKKAT", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtKullanici.Clear();
                txtSifre.Clear();
            }
        }

    }
}
