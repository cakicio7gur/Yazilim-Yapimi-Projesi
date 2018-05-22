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
    public partial class frmAnaSayfa : Form
    {
        DateTimePicker dtp = new DateTimePicker();
        DateTimePicker dtp2 = new DateTimePicker();
        Kullanici k = new Kullanici();
        SqlConnection baglanti = new SqlConnection();
        string komut;
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        void dgwStorieTarihOlustur()
        {
            Yazar.Items.Add("Kullanici");
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd/MM/yyyy";
            dtp.ValueChanged += dg1_valueChanged;
            dgwStorie.Controls.Add(dtp);
            dgwStorie.CellClick += dgwStorie_CellClick;
        }
        void dgwTaskTarihOlustur()
        {
            YazarTask.Items.Add("Görevli 1");
            YazarTask.Items.Add("Görevli 2");
            YazarTask.Items.Add("Görevli 3");
            YazarTask.Items.Add("Görevli 4");
            YazarTask.Items.Add("Görevli 5");
            YazarTask.Items.Add("Görevli 6");
            dtp2.Visible = false;
            dtp2.Format = DateTimePickerFormat.Custom;
            dtp2.CustomFormat = "dd/MM/yyyy";
            dtp2.ValueChanged += dg2_valueChanged;
            dgwTask.Controls.Add(dtp2);
            dgwTask.CellClick += dgwTask_CellClick;
        }
        void bilgileriAl()
        {
            k.Baslik = dgwStorie.CurrentRow.Cells[0].Value.ToString();
            k.Yazar = dgwStorie.CurrentRow.Cells[1].Value.ToString();
            k.Tarih = dgwStorie.CurrentRow.Cells[2].Value.ToString();
            k.Story = dgwStorie.CurrentRow.Cells[3].Value.ToString();
            k.Task = dgwTask.CurrentRow.Cells[0].Value.ToString();
            k.Gorevli = dgwTask.CurrentRow.Cells[1].Value.ToString();
            k.TeslimTarihi = dgwTask.CurrentRow.Cells[2].Value.ToString();
            k.NotStarted = dgwTask.CurrentRow.Cells[0].Value.ToString();
        }
        void sqlVeriYaz()
        {
            baglanti.ConnectionString = @"Data Source=LAPTOP-5A3164A4\SQLEXPRESS;Initial Catalog=Scrum;Integrated Security=True";
            komut = "INSERT INTO Kullanici(Yazar,Baslik,Tarih,Story,Task,Gorevli,TeslimTarihi,NotStarted) VALUES('" + k.Yazar + "','" + k.Baslik + "','" + k.Tarih + "','" + k.Story
                + "','" + k.Task + "','" + k.Gorevli + "','" + k.TeslimTarihi + "','" + k.NotStarted + "')";
            SqlCommand Ekle = new SqlCommand(komut, baglanti);
            baglanti.Open();
            Ekle.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dgwStorieTarihOlustur();
            dgwTaskTarihOlustur();
        }
       
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bilgileriAl();
            sqlVeriYaz();
            MessageBox.Show("Kaydedildi..");
        }

        private void dgwStorie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwStorie.Columns[e.ColumnIndex].Name == "TarihStorie")
            {
                Rectangle _Rectangle = dgwStorie.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                dtp.Location = _Rectangle.Location; 
                dtp.Width = _Rectangle.Width;
                try 
                {
                    dtp.Value=DateTime.Parse(dgwStorie.CurrentCell.Value.ToString());
                }
                catch 
                {

                }
                dtp.Visible=true;
            }
            else 
            {
                dtp.Visible=false;
            }
        }
        public void dg1_valueChanged(object sender, EventArgs e)
        {
            dgwStorie.CurrentCell.Value = dtp.Value.ToShortDateString();
            dtp.Visible = false;
        }
        public void dg2_valueChanged(object sender, EventArgs e)
        {
            dgwTask.CurrentCell.Value = dtp2.Value.ToShortDateString();
            dtp2.Visible = false;
        }

        private void dgwStorie_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;
        }

        private void dgwStorie_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }


        private void dgwTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwTask.Columns[e.ColumnIndex].Name == "TarihTask")
            {
                Rectangle _Rectangle = dgwTask.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                dtp2.Location = _Rectangle.Location;
                dtp2.Width = _Rectangle.Width;
                try
                {
                    dtp2.Value = DateTime.Parse(dgwTask.CurrentCell.Value.ToString());
                }
                catch
                {

                }
                dtp2.Visible = true;
            }
            else
            {
                dtp2.Visible = false;
            }
        }

        private void dgwTask_Scroll(object sender, ScrollEventArgs e)
        {
            dtp2.Visible = false;
        }

        private void dgwTask_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp2.Visible = false;
        }
        public void dgwTemizle()
        {
            dgwTask.Rows.Clear();
        }
        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            dgwTemizle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            FormGuncelleVeListele fgl = new FormGuncelleVeListele();
            fgl.Show();
            this.Hide();
        }

        private void btnScrumTable_Click(object sender, EventArgs e)
        {
            FormScrumTable st = new FormScrumTable();
            st.Show();
            this.Hide();
        }
     
    }
}
