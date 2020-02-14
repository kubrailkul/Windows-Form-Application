namespace Vektorel.Windows.Oyun
{
    partial class frmGiris
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
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.Lblsoyad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdKolay = new System.Windows.Forms.RadioButton();
            this.rdOrta = new System.Windows.Forms.RadioButton();
            this.rdZor = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(197, 312);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(100, 23);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(21, 22);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Ad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(64, 45);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(64, 19);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 4;
            // 
            // Lblsoyad
            // 
            this.Lblsoyad.AutoSize = true;
            this.Lblsoyad.Location = new System.Drawing.Point(21, 52);
            this.Lblsoyad.Name = "Lblsoyad";
            this.Lblsoyad.Size = new System.Drawing.Size(37, 13);
            this.Lblsoyad.TabIndex = 5;
            this.Lblsoyad.Text = "Soyad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.Lblsoyad);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Location = new System.Drawing.Point(133, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 106);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oyuncu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdKolay);
            this.groupBox2.Controls.Add(this.rdOrta);
            this.groupBox2.Controls.Add(this.rdZor);
            this.groupBox2.Location = new System.Drawing.Point(133, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 96);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seviye";
            // 
            // rdKolay
            // 
            this.rdKolay.AutoSize = true;
            this.rdKolay.Location = new System.Drawing.Point(64, 27);
            this.rdKolay.Name = "rdKolay";
            this.rdKolay.Size = new System.Drawing.Size(51, 17);
            this.rdKolay.TabIndex = 8;
            this.rdKolay.TabStop = true;
            this.rdKolay.Tag = "1";
            this.rdKolay.Text = "Kolay";
            this.rdKolay.UseVisualStyleBackColor = true;
            this.rdKolay.CheckedChanged += new System.EventHandler(this.Rd_CheckedChanged);
            // 
            // rdOrta
            // 
            this.rdOrta.AutoSize = true;
            this.rdOrta.Location = new System.Drawing.Point(64, 50);
            this.rdOrta.Name = "rdOrta";
            this.rdOrta.Size = new System.Drawing.Size(45, 17);
            this.rdOrta.TabIndex = 9;
            this.rdOrta.TabStop = true;
            this.rdOrta.Tag = "2";
            this.rdOrta.Text = "Orta";
            this.rdOrta.UseVisualStyleBackColor = true;
            this.rdOrta.CheckedChanged += new System.EventHandler(this.Rd_CheckedChanged);
            // 
            // rdZor
            // 
            this.rdZor.AutoSize = true;
            this.rdZor.Location = new System.Drawing.Point(64, 73);
            this.rdZor.Name = "rdZor";
            this.rdZor.Size = new System.Drawing.Size(41, 17);
            this.rdZor.TabIndex = 10;
            this.rdZor.TabStop = true;
            this.rdZor.Tag = "3";
            this.rdZor.Text = "Zor";
            this.rdZor.UseVisualStyleBackColor = true;
            this.rdZor.CheckedChanged += new System.EventHandler(this.Rd_CheckedChanged);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 347);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGiris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label Lblsoyad;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdKolay;
        private System.Windows.Forms.RadioButton rdOrta;
        private System.Windows.Forms.RadioButton rdZor;
    }
}