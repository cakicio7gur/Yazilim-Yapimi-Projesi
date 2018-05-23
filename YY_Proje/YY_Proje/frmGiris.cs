using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YY_Proje
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
            if(txtKAdi.Text=="User" && txtSifre.Text=="123456")
            {
                 frmAnaSayfa af = new frmAnaSayfa();
                 af.Show();
                 this.Hide();
            }
            else
            {
                label3.Text = "Kullanıcı Adı veya Şifre Yanlış..!";
               
            }
            
        }
    }
}
