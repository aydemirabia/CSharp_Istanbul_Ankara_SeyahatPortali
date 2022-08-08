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
    public partial class FrmYolcuBilgileri : Form
    {
        public FrmYolcuBilgileri()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            listAdSoyad.Items.Add(txtAdSoyad.Text);
            listTelefon.Items.Add(mskTel.Text);
            listIlceler.Items.Add(cmbIlceler.Text);
            listKoltuk.Items.Add("1");
            listSaat.Items.Add(mskSaat.Text);

            if (rbErkek.Checked == true)
            {
                listCinsiyet.Items.Add("Erkek");
            }
            if (rbKadin.Checked == true)
            {
                listCinsiyet.Items.Add("Kadın");
            }

            txtAdSoyad.Clear();
            mskTel.Clear();
            cmbIlceler.Text = "";
            mskSaat.Clear();
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            listAdSoyad.Items.Add(txtAdSoyad.Text);
            listTelefon.Items.Add(mskTel.Text);
            listIlceler.Items.Add(cmbIlceler.Text);
            listKoltuk.Items.Add("2");
            listSaat.Items.Add(mskSaat.Text);

            if (rbErkek.Checked == true)
            {
                listCinsiyet.Items.Add("Erkek");
            }
            if (rbKadin.Checked == true)
            {
                listCinsiyet.Items.Add("Kadın");
            }

            txtAdSoyad.Clear();
            mskTel.Clear();
            cmbIlceler.Text = "";
            mskSaat.Clear();
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            listAdSoyad.Items.Add(txtAdSoyad.Text);
            listTelefon.Items.Add(mskTel.Text);
            listIlceler.Items.Add(cmbIlceler.Text);
            listKoltuk.Items.Add("3");
            listSaat.Items.Add(mskSaat.Text);

            if (rbErkek.Checked == true)
            {
                listCinsiyet.Items.Add("Erkek");
            }
            if (rbKadin.Checked == true)
            {
                listCinsiyet.Items.Add("Kadın");
            }

            txtAdSoyad.Clear();
            mskTel.Clear();
            cmbIlceler.Text = "";
            mskSaat.Clear();
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            listAdSoyad.Items.Add(txtAdSoyad.Text);
            listTelefon.Items.Add(mskTel.Text);
            listIlceler.Items.Add(cmbIlceler.Text);
            listKoltuk.Items.Add("4");
            listSaat.Items.Add(mskSaat.Text);

            if (rbErkek.Checked == true)
            {
                listCinsiyet.Items.Add("Erkek");
            }
            if (rbKadin.Checked == true)
            {
                listCinsiyet.Items.Add("Kadın");
            }

            txtAdSoyad.Clear();
            mskTel.Clear();
            cmbIlceler.Text = "";
            mskSaat.Clear();
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            listAdSoyad.Items.Add(txtAdSoyad.Text);
            listTelefon.Items.Add(mskTel.Text);
            listIlceler.Items.Add(cmbIlceler.Text);
            listKoltuk.Items.Add("5");
            listSaat.Items.Add(mskSaat.Text);

            if (rbErkek.Checked == true)
            {
                listCinsiyet.Items.Add("Erkek");
            }
            if (rbKadin.Checked == true)
            {
                listCinsiyet.Items.Add("Kadın");
            }

            txtAdSoyad.Clear();
            mskTel.Clear();
            cmbIlceler.Text = "";
            mskSaat.Clear();
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            listAdSoyad.Items.Add(txtAdSoyad.Text);
            listTelefon.Items.Add(mskTel.Text);
            listIlceler.Items.Add(cmbIlceler.Text);
            listKoltuk.Items.Add("6");
            listSaat.Items.Add(mskSaat.Text);

            if (rbErkek.Checked == true)
            {
                listCinsiyet.Items.Add("Erkek");
            }
            if (rbKadin.Checked == true)
            {
                listCinsiyet.Items.Add("Kadın");
            }

            txtAdSoyad.Clear();
            mskTel.Clear();
            cmbIlceler.Text = "";
            mskSaat.Clear();
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            listAdSoyad.Items.Add(txtAdSoyad.Text);
            listTelefon.Items.Add(mskTel.Text);
            listIlceler.Items.Add(cmbIlceler.Text);
            listKoltuk.Items.Add("7");
            listSaat.Items.Add(mskSaat.Text);

            if (rbErkek.Checked == true)
            {
                listCinsiyet.Items.Add("Erkek");
            }
            if (rbKadin.Checked == true)
            {
                listCinsiyet.Items.Add("Kadın");
            }

            txtAdSoyad.Clear();
            mskTel.Clear();
            cmbIlceler.Text = "";
            mskSaat.Clear();
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            listAdSoyad.Items.Add(txtAdSoyad.Text);
            listTelefon.Items.Add(mskTel.Text);
            listIlceler.Items.Add(cmbIlceler.Text);
            listKoltuk.Items.Add("8");
            listSaat.Items.Add(mskSaat.Text);

            if (rbErkek.Checked == true)
            {
                listCinsiyet.Items.Add("Erkek");
            }
            if (rbKadin.Checked == true)
            {
                listCinsiyet.Items.Add("Kadın");
            }

            txtAdSoyad.Clear();
            mskTel.Clear();
            cmbIlceler.Text = "";
            mskSaat.Clear();
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            listAdSoyad.Items.Add(txtAdSoyad.Text);
            listTelefon.Items.Add(mskTel.Text);
            listIlceler.Items.Add(cmbIlceler.Text);
            listKoltuk.Items.Add("9");
            listSaat.Items.Add(mskSaat.Text);

            if (rbErkek.Checked == true)
            {
                listCinsiyet.Items.Add("Erkek");
            }
            if (rbKadin.Checked == true)
            {
                listCinsiyet.Items.Add("Kadın");
            }

            txtAdSoyad.Clear();
            mskTel.Clear();
            cmbIlceler.Text = "";
            mskSaat.Clear();
            btn9.Enabled = false;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            listAdSoyad.Items.Add(txtAdSoyad.Text);
            listTelefon.Items.Add(mskTel.Text);
            listIlceler.Items.Add(cmbIlceler.Text);
            listKoltuk.Items.Add("10");
            listSaat.Items.Add(mskSaat.Text);

            if (rbErkek.Checked == true)
            {
                listCinsiyet.Items.Add("Erkek");
            }
            if (rbKadin.Checked == true)
            {
                listCinsiyet.Items.Add("Kadın");
            }

            txtAdSoyad.Clear();
            mskTel.Clear();
            cmbIlceler.Text = "";
            mskSaat.Clear();
            btn10.Enabled = false;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            listAdSoyad.Items.Add(txtAdSoyad.Text);
            listTelefon.Items.Add(mskTel.Text);
            listIlceler.Items.Add(cmbIlceler.Text);
            listKoltuk.Items.Add("11");
            listSaat.Items.Add(mskSaat.Text);

            if (rbErkek.Checked == true)
            {
                listCinsiyet.Items.Add("Erkek");
            }
            if (rbKadin.Checked == true)
            {
                listCinsiyet.Items.Add("Kadın");
            }

            txtAdSoyad.Clear();
            mskTel.Clear();
            cmbIlceler.Text = "";
            mskSaat.Clear();
            btn11.Enabled = false;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            listAdSoyad.Items.Add(txtAdSoyad.Text);
            listTelefon.Items.Add(mskTel.Text);
            listIlceler.Items.Add(cmbIlceler.Text);
            listKoltuk.Items.Add("12");
            listSaat.Items.Add(mskSaat.Text);

            if (rbErkek.Checked == true)
            {
                listCinsiyet.Items.Add("Erkek");
            }
            if (rbKadin.Checked == true)
            {
                listCinsiyet.Items.Add("Kadın");
            }

            txtAdSoyad.Clear();
            mskTel.Clear();
            cmbIlceler.Text = "";
            mskSaat.Clear();
            btn12.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmBiletAlani yolcu = new FrmBiletAlani();
            yolcu.Show();
            this.Hide();
        }
    }
}
