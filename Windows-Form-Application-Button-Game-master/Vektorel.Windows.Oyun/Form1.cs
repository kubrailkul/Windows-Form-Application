using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.Windows.Oyun
{
    public enum Seviye
    {
        Kolay = 1,
        Orta,
        Zor,



    }

    public partial class frmOyun : Form
    {
        Random rnd = new Random();
        int skor = 0;
        //int sure = 5;
        int sure;
        List<int> skorlar = new List<int>();
        private frmGiris giris;
        int a;
       
        public frmOyun(string ad, string soyad, Seviye seviye)
        {
            InitializeComponent();
            lblKullanici.Text = $"{ad}\n{soyad}";
            a = Convert.ToInt32(seviye);
            
            switch (seviye)
            {
                case Seviye.Kolay:
                    sure = 10;
                    tmrButon.Interval = 1000;
                    break;
                case Seviye.Orta:
                    sure = 5;
                    tmrButon.Interval = 500;
                    break;
                case Seviye.Zor:
                    sure = 3;
                    tmrButon.Interval = 100;

                    break;

            }
        }

        public frmOyun(frmGiris giris)
        {
            this.giris = giris;
            InitializeComponent();
        }

        private void TmrButon_Tick(object sender, EventArgs e)
        {

            Button btn = new Button();   //yeni nesne oluştu
            btn.Size = new Size(50, 50);
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - btn.Width - pnlbilgi.Width), rnd.Next(this.ClientSize.Height - btn.Height));
            btn.Text = rnd.Next(100).ToString();   //buttonlara atılacak değerler
            btn.Click += Btn_Click;
            this.Controls.Add(btn);   //Button ekleme yapıldı                       
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            Button btn = (Button)sender;
            int.Parse(btn.Text);
            btn.Dispose();
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            skor += int.Parse(btn.Text);
            skorlar.Add(skor);
            btn.Visible = false;
        }

        private void FrmOyun_Load(object sender, EventArgs e)
        {
            tmrButon.Start();
            tmrSure.Start();

        }

        private void TmrSure_Tick(object sender, EventArgs e)
        {
            lblSure.Text = sure.ToString();
            lblSkor.Text = skor.ToString();
            this.Text = sure.ToString();
            sure--;
            if (sure == 0)
            {
                tmrSure.Stop();
                tmrButon.Stop();
                DialogResult cvp = MessageBox.Show($"Puan:{skor}\nYeniden oynamak ister misiniz?",
                    "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cvp == DialogResult.Yes)
                {

                    yenidenbaslat();
                }
                else
                {
                    int max = 0;
                    foreach (int item in skorlar)
                    {
                        if (item > max)
                        {
                            max = item;

                        }
                    }
                    MessageBox.Show($"En yüksek skor:{max}");

                }

            }


        }

        void yenidenbaslat()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is Button)
                {
                    this.Controls[i].Dispose();
                    i--;
                }
            }

            if (a == 1)
            {
                sure = 10;
                tmrButon.Interval = 1000;
            }

            else if (a == 2)
            {
                sure = 5;
                tmrButon.Interval = 500;

            }

            else
            {
                sure = 3;
                tmrButon.Interval = 100;
            }

            tmrButon.Start();
            tmrSure.Start();

        }

        private void FrmOyun_Resize(object sender, EventArgs e)
        {
            pnlbilgi.Height = this.ClientSize.Height;
            pnlbilgi.Location = new Point(this.ClientSize.Width - pnlbilgi.Size.Width);
        }

    }
}
