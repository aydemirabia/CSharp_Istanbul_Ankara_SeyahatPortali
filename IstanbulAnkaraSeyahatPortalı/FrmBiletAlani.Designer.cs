
namespace IstanbulAnkaraSeyahatPortalı
{
    partial class FrmBiletAlani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiletAlani));
            this.btnBiletAlani = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnTRTTurku = new System.Windows.Forms.Button();
            this.btnMetro = new System.Windows.Forms.Button();
            this.btnPowerTurk = new System.Windows.Forms.Button();
            this.btnKral = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBiletAlani
            // 
            this.btnBiletAlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBiletAlani.Location = new System.Drawing.Point(42, 29);
            this.btnBiletAlani.Name = "btnBiletAlani";
            this.btnBiletAlani.Size = new System.Drawing.Size(158, 66);
            this.btnBiletAlani.TabIndex = 0;
            this.btnBiletAlani.Text = "Bilet Alanı";
            this.btnBiletAlani.UseVisualStyleBackColor = true;
            this.btnBiletAlani.Click += new System.EventHandler(this.btnBiletAlani_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(221, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Radyo Dinle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKral);
            this.groupBox1.Controls.Add(this.btnPowerTurk);
            this.groupBox1.Controls.Add(this.btnMetro);
            this.groupBox1.Controls.Add(this.btnTRTTurku);
            this.groupBox1.Controls.Add(this.axWindowsMediaPlayer1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(21, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 393);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RADYO";
            this.groupBox1.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(21, 30);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(257, 347);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // btnTRTTurku
            // 
            this.btnTRTTurku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTRTTurku.BackgroundImage")));
            this.btnTRTTurku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTRTTurku.Location = new System.Drawing.Point(284, 30);
            this.btnTRTTurku.Name = "btnTRTTurku";
            this.btnTRTTurku.Size = new System.Drawing.Size(131, 90);
            this.btnTRTTurku.TabIndex = 2;
            this.btnTRTTurku.UseVisualStyleBackColor = true;
            this.btnTRTTurku.Click += new System.EventHandler(this.btnTRTTurku_Click);
            // 
            // btnMetro
            // 
            this.btnMetro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMetro.BackgroundImage")));
            this.btnMetro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMetro.Location = new System.Drawing.Point(284, 300);
            this.btnMetro.Name = "btnMetro";
            this.btnMetro.Size = new System.Drawing.Size(131, 77);
            this.btnMetro.TabIndex = 3;
            this.btnMetro.UseVisualStyleBackColor = true;
            this.btnMetro.Click += new System.EventHandler(this.btnMetro_Click);
            // 
            // btnPowerTurk
            // 
            this.btnPowerTurk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPowerTurk.BackgroundImage")));
            this.btnPowerTurk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPowerTurk.Location = new System.Drawing.Point(284, 216);
            this.btnPowerTurk.Name = "btnPowerTurk";
            this.btnPowerTurk.Size = new System.Drawing.Size(131, 81);
            this.btnPowerTurk.TabIndex = 5;
            this.btnPowerTurk.UseVisualStyleBackColor = true;
            this.btnPowerTurk.Click += new System.EventHandler(this.btnPowerTurk_Click);
            // 
            // btnKral
            // 
            this.btnKral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKral.BackgroundImage")));
            this.btnKral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKral.Location = new System.Drawing.Point(284, 125);
            this.btnKral.Name = "btnKral";
            this.btnKral.Size = new System.Drawing.Size(131, 85);
            this.btnKral.TabIndex = 6;
            this.btnKral.UseVisualStyleBackColor = true;
            this.btnKral.Click += new System.EventHandler(this.btnKral_Click);
            // 
            // FrmBiletAlani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(529, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBiletAlani);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBiletAlani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBiletAlani";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBiletAlani;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnKral;
        private System.Windows.Forms.Button btnPowerTurk;
        private System.Windows.Forms.Button btnMetro;
        private System.Windows.Forms.Button btnTRTTurku;
    }
}