namespace YY_Proje
{
    partial class FormGuncelleVeListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuncelleVeListele));
            this.btnScrumTable = new DevExpress.XtraEditors.SimpleButton();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.dgwGuncelle = new System.Windows.Forms.DataGridView();
            this.grbListe = new System.Windows.Forms.GroupBox();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGuncelle)).BeginInit();
            this.grbListe.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScrumTable
            // 
            this.btnScrumTable.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnScrumTable.Appearance.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScrumTable.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnScrumTable.Appearance.Options.UseBackColor = true;
            this.btnScrumTable.Appearance.Options.UseFont = true;
            this.btnScrumTable.Appearance.Options.UseForeColor = true;
            this.btnScrumTable.AutoWidthInLayoutControl = true;
            this.btnScrumTable.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnScrumTable.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnScrumTable.ImageOptions.Image")));
            this.btnScrumTable.Location = new System.Drawing.Point(610, 25);
            this.btnScrumTable.Name = "btnScrumTable";
            this.btnScrumTable.Size = new System.Drawing.Size(271, 75);
            this.btnScrumTable.TabIndex = 10;
            this.btnScrumTable.Text = "Scrum Tablosu Oluştur";
            this.btnScrumTable.Click += new System.EventHandler(this.btnScrumTable_Click);
            // 
            // btnListele
            // 
            this.btnListele.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnListele.Appearance.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListele.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnListele.Appearance.Options.UseBackColor = true;
            this.btnListele.Appearance.Options.UseFont = true;
            this.btnListele.Appearance.Options.UseForeColor = true;
            this.btnListele.AutoWidthInLayoutControl = true;
            this.btnListele.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnListele.Location = new System.Drawing.Point(360, 25);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(192, 75);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Story Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOlustur.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOlustur.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnOlustur.Appearance.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlustur.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnOlustur.Appearance.Options.UseBackColor = true;
            this.btnOlustur.Appearance.Options.UseBorderColor = true;
            this.btnOlustur.Appearance.Options.UseFont = true;
            this.btnOlustur.Appearance.Options.UseForeColor = true;
            this.btnOlustur.AutoWidthInLayoutControl = true;
            this.btnOlustur.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnOlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOlustur.ImageOptions.Image")));
            this.btnOlustur.Location = new System.Drawing.Point(110, 25);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(192, 75);
            this.btnOlustur.TabIndex = 8;
            this.btnOlustur.Text = "Story Oluştur";
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // dgwGuncelle
            // 
            this.dgwGuncelle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGuncelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGuncelle.Location = new System.Drawing.Point(31, 93);
            this.dgwGuncelle.Name = "dgwGuncelle";
            this.dgwGuncelle.RowTemplate.Height = 24;
            this.dgwGuncelle.Size = new System.Drawing.Size(1487, 397);
            this.dgwGuncelle.TabIndex = 12;
            // 
            // grbListe
            // 
            this.grbListe.Controls.Add(this.btnSil);
            this.grbListe.Controls.Add(this.dgwGuncelle);
            this.grbListe.Controls.Add(this.btnGuncelle);
            this.grbListe.Location = new System.Drawing.Point(12, 127);
            this.grbListe.Name = "grbListe";
            this.grbListe.Size = new System.Drawing.Size(1548, 516);
            this.grbListe.TabIndex = 13;
            this.grbListe.TabStop = false;
            this.grbListe.Text = "Veriler";
            // 
            // btnSil
            // 
            this.btnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSil.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSil.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnSil.Appearance.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseBorderColor = true;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(1073, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(210, 51);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGuncelle.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGuncelle.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseBackColor = true;
            this.btnGuncelle.Appearance.Options.UseBorderColor = true;
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(1308, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(210, 51);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FormGuncelleVeListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 644);
            this.Controls.Add(this.grbListe);
            this.Controls.Add(this.btnScrumTable);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnOlustur);
            this.Name = "FormGuncelleVeListele";
            this.Text = "Güncelle";
            this.Load += new System.EventHandler(this.FormGuncelleVeListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGuncelle)).EndInit();
            this.grbListe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnScrumTable;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnOlustur;
        private System.Windows.Forms.DataGridView dgwGuncelle;
        private System.Windows.Forms.GroupBox grbListe;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
    }
}