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
    public partial class FormScrumTable : Form
    {
        DataSet dtst;
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-5A3164A4\SQLEXPRESS;Initial Catalog=Scrum;Integrated Security=True");
        public FormScrumTable()
        {
            InitializeComponent();
        }

        public void storieGetir()
        {
            dtst = new DataSet();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT Story,Yazar,Tarih FROM Kullanici WHERE Story='" + txtBul.Text + "'", baglanti);
            baglanti.Open();
            adtr.Fill(dtst, "Kullanici");
            dgwStory.DataSource = dtst.Tables["Kullanici"];
            adtr.Dispose();
            baglanti.Close();
        }
        public void notStartedGetir()
        {
            dtst = new DataSet();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT NotStarted,TeslimTarihi FROM Kullanici WHERE Story='" + txtBul.Text + "'", baglanti);
            baglanti.Open();
            adtr.Fill(dtst, "Kullanici");
            dgwNotStarted.DataSource = dtst.Tables["Kullanici"];
            adtr.Dispose();
            baglanti.Close();
        }
        public void notStartedGuncelle()
        {
            baglanti.Open();
            dtst = new DataSet();
            foreach (DataGridViewRow row in dgwNotStarted.Rows)
            {

                bool isSelected = Convert.ToBoolean(row.Cells["SecimNotStarted"].Value);
                if (isSelected)
                {
                    SqlDataAdapter adtr = new SqlDataAdapter("UPDATE Kullanici SET IPTeslimTarihi='" + row.Cells[2].Value + "',TeslimTarihi='" + null + "', NotStarted='" + null + "' ,InProgress='" + row.Cells[1].Value + "' WHERE NotStarted='" + row.Cells[1].Value + "' AND TeslimTarihi='" + row.Cells[2].Value + "'", baglanti);
                    adtr.Fill(dtst, "Kullanici");
                    dgwDone.DataSource = dtst.Tables["Kullanici"];
                    adtr.Dispose();
                    baglanti.Close();
                }

            }

        }
       



        public void ınProgressGetir()
        {
            dtst = new DataSet();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT InProgress,IPTeslimTarihi FROM Kullanici WHERE Story='" + txtBul.Text + "'", baglanti);
            baglanti.Open();
            adtr.Fill(dtst, "Kullanici");
            dgwInProgress.DataSource = dtst.Tables["Kullanici"];
            adtr.Dispose();
            baglanti.Close();
        }
        public void ınProgressGuncelle()
        {
            baglanti.Open();
            dtst = new DataSet();
            foreach (DataGridViewRow row in dgwInProgress.Rows)
            {

                bool isSelected = Convert.ToBoolean(row.Cells["SecimInProgress"].Value);
                if (isSelected)
                {
                    SqlDataAdapter adtr = new SqlDataAdapter("UPDATE Kullanici SET DTeslimTarihi='" + row.Cells[2].Value + "',IPTeslimTarihi='" + null + "', InProgress='" + null + "' ,Done='" + row.Cells[1].Value + "'  WHERE InProgress='" + row.Cells[1].Value + "' AND IPTeslimTarihi='" + row.Cells[2].Value + "'", baglanti);
                    adtr.Fill(dtst, "Kullanici");
                    dgwDone.DataSource = dtst.Tables["Kullanici"];
                    adtr.Dispose();
                    baglanti.Close();
                }

            }

        }
        
        public void doneGetir()
        {
            DataSet dtst = new DataSet();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT Done,DTeslimTarihi FROM Kullanici WHERE Story='" + txtBul.Text + "'", baglanti);
            baglanti.Open();
            adtr.Fill(dtst, "Kullanici");
            dgwDone.DataSource = dtst.Tables["Kullanici"];
            adtr.Dispose();
            baglanti.Close();
        }
        public void doneGuncelle()
        {
            baglanti.Open();
            dtst = new DataSet();
            foreach (DataGridViewRow row in dgwDone.Rows)
            {

                bool isSelected = Convert.ToBoolean(row.Cells["SecimDone"].Value);
                if (isSelected)
                {
                    SqlDataAdapter adtr = new SqlDataAdapter("UPDATE Kullanici SET TeslimTarihi='" + row.Cells[2].Value + "',DTeslimTarihi='" + null + "', Done='" + null + "' ,NotStarted='" + row.Cells[1].Value + "'  WHERE Done='" + row.Cells[1].Value + "' AND DTeslimTarihi='" + row.Cells[2].Value + "'", baglanti);
                    adtr.Fill(dtst, "Kullanici");
                    dgwDone.DataSource = dtst.Tables["Kullanici"];
                    adtr.Dispose();
                    baglanti.Close();
                }

            }

        }


        private void FormScrumTable_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        public void storyRenklendir()
        {
            for (int i = 0; i < dgwStory.Rows.Count; i++)
            {
                if (i % 2 == 1)
                {
                    dgwStory.Rows[i].DefaultCellStyle.BackColor = Color.Bisque;
                }
            }
        }
       
        private void btnStorieBul_Click(object sender, EventArgs e)
        {
            storieGetir();
            notStartedGetir();
            ınProgressGetir();
            doneGetir();
            storyRenklendir();
            
        }

        private void btnInProgressAktar_Click(object sender, EventArgs e)
        {
            
            notStartedGetir();
            ınProgressGetir();
            doneGetir();
           
        }

        private void btnDoneAktar_Click(object sender, EventArgs e)
        {
           
            notStartedGetir();
            ınProgressGetir();
            doneGetir();
            
        }

        private void btnNotStartedAktar_Click(object sender, EventArgs e)
        {
            
            notStartedGetir();
            ınProgressGetir();
            doneGetir();
       
        }
        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            frmAnaSayfa fa = new frmAnaSayfa();
            fa.Show();
            this.Hide();
        }

    }
}