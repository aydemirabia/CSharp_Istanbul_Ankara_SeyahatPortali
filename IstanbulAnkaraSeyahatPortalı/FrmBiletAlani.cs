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
    public partial class FrmBiletAlani : Form
    {
        public FrmBiletAlani()
        {
            InitializeComponent();
        }

        private void btnPowerTurk_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://icast.powergroup.com.tr/PowerTurk/mpeg/128/home"; 
        }

        private void btnKral_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.204:80/";
        }

        private void btnMetro_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://provisioning.streamtheworld.com/pls/METRO_FMAAC.pls";
        }

        private void btnTRTTurku_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://trtcanlifm-lh.akamaihd.net/i/TRTFM_1@181846/master.m3u8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void btnBiletAlani_Click(object sender, EventArgs e)
        {
            FrmYolcuBilgileri seyahat = new FrmYolcuBilgileri();
            seyahat.Show();
            this.Hide();
        }
    }
}
