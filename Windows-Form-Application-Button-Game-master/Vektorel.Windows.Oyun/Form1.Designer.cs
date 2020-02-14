namespace Vektorel.Windows.Oyun
{
    partial class frmOyun
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOyun));
            this.tmrButon = new System.Windows.Forms.Timer(this.components);
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.pnlbilgi = new System.Windows.Forms.Panel();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.pnlbilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrButon
            // 
            this.tmrButon.Interval = 1000;
            this.tmrButon.Tick += new System.EventHandler(this.TmrButon_Tick);
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 1000;
            this.tmrSure.Tick += new System.EventHandler(this.TmrSure_Tick);
            // 
            // pnlbilgi
            // 
            this.pnlbilgi.BackColor = System.Drawing.SystemColors.Info;
            this.pnlbilgi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlbilgi.BackgroundImage")));
            this.pnlbilgi.Controls.Add(this.lblSure);
            this.pnlbilgi.Controls.Add(this.lblSkor);
            this.pnlbilgi.Controls.Add(this.lblKullanici);
            this.pnlbilgi.Location = new System.Drawing.Point(320, 0);
            this.pnlbilgi.Name = "pnlbilgi";
            this.pnlbilgi.Size = new System.Drawing.Size(102, 287);
            this.pnlbilgi.TabIndex = 1;

            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(20, 149);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(29, 13);
            this.lblSure.TabIndex = 2;
            this.lblSure.Text = "Sure";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(20, 123);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(29, 13);
            this.lblSkor.TabIndex = 1;
            this.lblSkor.Text = "Skor";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(20, 72);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(46, 13);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "Kullanıcı";
            // 
            // frmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(415, 279);
            this.Controls.Add(this.pnlbilgi);
            this.Name = "frmOyun";
            this.Text = "Oyun";
            this.Load += new System.EventHandler(this.FrmOyun_Load);
            this.Resize += new System.EventHandler(this.FrmOyun_Resize);
            this.pnlbilgi.ResumeLayout(false);
            this.pnlbilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrButon;
        private System.Windows.Forms.Timer tmrSure;
        private System.Windows.Forms.Panel pnlbilgi;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblKullanici;
    }
}

