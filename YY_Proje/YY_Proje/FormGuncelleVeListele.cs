using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YY_Proje
{
    public partial class FormGuncelleVeListele : Form
    {
        SqlConnection con; SqlCommandBuilder build; DataSet ds; SqlDataAdapter da; SqlCommand komut;
        public FormGuncelleVeListele()
        {
            InitializeComponent();
            string str = @"Data Source=LAPTOP-5A3164A4\SQLEXPRESS;Initial Catalog=Scrum;Integrated Security=True";
            con = new SqlConnection(str);
        }
        public void renklendir()
        {
            for (int i = 0; i < dgwGuncelle.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dgwGuncelle.Rows[i].DefaultCellStyle.BackColor = Color.Bisque;
                }
            }
        }
        public void bilgiGetir()
        {
            string sql = "SELECT * FROM Kullanici";
            ds = new DataSet();
            da = new SqlDataAdapter(sql, con);
            build = new SqlCommandBuilder(da);
            da.Fill(ds);
            dgwGuncelle.DataSource = ds.Tables[0]; 
        }
        
        private void FormGuncelleVeListele_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            bilgiGetir();
            renklendir();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            frmAnaSayfa af = new frmAnaSayfa();
            af.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables[0]);
                MessageBox.Show("Kayıt Başarıyla Güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
           
        }

        private void btnScrumTable_Click(object sender, EventArgs e)
        {
            FormScrumTable st = new FormScrumTable();
            st.Show();
            this.Hide();
        }
        public void kayıtSil(int ID)
        {
            string sql = "DELETE FROM Kullanici WHERE ID=@ID";
            komut = new SqlCommand(sql, con);
            komut.Parameters.AddWithValue("@ID", ID);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dgwGuncelle.SelectedRows) 
            {
                int ID = Convert.ToInt32(drow.Cells[0].Value);
                kayıtSil(ID);
                MessageBox.Show("Silme İşlemi Başarılı.");
            }
            bilgiGetir();
            renklendir();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            FormGuncelleVeListele fgl = new FormGuncelleVeListele();
            fgl.Show();
            this.Hide();
        }

    }
}
