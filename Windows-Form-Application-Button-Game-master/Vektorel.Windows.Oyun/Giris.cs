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
    public partial class frmGiris : Form
    {
        Seviye seviye;
        public frmGiris()
        {
            InitializeComponent();
        }


        private void BtnGiris_Click(object sender, EventArgs e)
        {
            frmOyun frm = new frmOyun(txtAd.Text.Trim().ToUpper(), txtSoyad.Text.Trim().ToUpper(), seviye);
            frm.Show();

        }


        private void Rd_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            if (rd.Checked)
            {
                seviye = (Seviye)(Convert.ToInt32(rd.Tag));
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
