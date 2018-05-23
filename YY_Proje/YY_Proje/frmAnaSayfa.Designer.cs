namespace YY_Proje
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dgwStorie = new System.Windows.Forms.DataGridView();
            this.Baslik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yazar = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TarihStorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Storie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnScrumTable = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbTasks = new System.Windows.Forms.GroupBox();
            this.btnTaskEkle = new DevExpress.XtraEditors.SimpleButton();
            this.dgwTask = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YazarTask = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TarihTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStorie)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTask)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AutoWidthInLayoutControl = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(110, 25);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(192, 75);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Story Oluştur";
            // 
            // dgwStorie
            // 
            this.dgwStorie.AllowUserToOrderColumns = true;
            this.dgwStorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStorie.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwStorie.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwStorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Baslik,
            this.Yazar,
            this.TarihStorie,
            this.Storie});
            this.dgwStorie.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgwStorie.Location = new System.Drawing.Point(8, 26);
            this.dgwStorie.Name = "dgwStorie";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwStorie.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwStorie.RowTemplate.Height = 24;
            this.dgwStorie.Size = new System.Drawing.Size(1500, 54);
            this.dgwStorie.TabIndex = 1;
            this.dgwStorie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStorie_CellClick);
            this.dgwStorie.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgwStorie_ColumnWidthChanged);
            this.dgwStorie.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgwStorie_Scroll);
            // 
            // Baslik
            // 
            this.Baslik.HeaderText = "Baslik";
            this.Baslik.Name = "Baslik";
            // 
            // Yazar
            // 
            this.Yazar.HeaderText = "Yazar";
            this.Yazar.Name = "Yazar";
            // 
            // TarihStorie
            // 
            this.TarihStorie.HeaderText = "Tarih";
            this.TarihStorie.Name = "TarihStorie";
            // 
            // Storie
            // 
            this.Storie.HeaderText = "Story";
            this.Storie.Name = "Storie";
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
            this.btnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.ImageOptions.Image")));
            this.btnListele.Location = new System.Drawing.Point(360, 25);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(192, 75);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Story Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
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
            this.btnScrumTable.TabIndex = 3;
            this.btnScrumTable.Text = "Scrum Tablosu Oluştur";
            this.btnScrumTable.Click += new System.EventHandler(this.btnScrumTable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dgwStorie);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1548, 101);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Story";
            // 
            // grbTasks
            // 
            this.grbTasks.Controls.Add(this.btnTaskEkle);
            this.grbTasks.Controls.Add(this.dgwTask);
            this.grbTasks.Controls.Add(this.btnKaydet);
            this.grbTasks.Location = new System.Drawing.Point(12, 234);
            this.grbTasks.Name = "grbTasks";
            this.grbTasks.Size = new System.Drawing.Size(1548, 233);
            this.grbTasks.TabIndex = 7;
            this.grbTasks.TabStop = false;
            this.grbTasks.Text = "Tasklar";
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTaskEkle.Appearance.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaskEkle.Appearance.Options.UseBackColor = true;
            this.btnTaskEkle.Appearance.Options.UseFont = true;
            this.btnTaskEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTaskEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaskEkle.ImageOptions.Image")));
            this.btnTaskEkle.Location = new System.Drawing.Point(1313, 24);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(195, 44);
            this.btnTaskEkle.TabIndex = 8;
            this.btnTaskEkle.Text = "Task Ekle";
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // dgwTask
            // 
            this.dgwTask.AllowUserToOrderColumns = true;
            this.dgwTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTask.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwTask.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.YazarTask,
            this.TarihTask});
            this.dgwTask.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgwTask.Location = new System.Drawing.Point(8, 74);
            this.dgwTask.Name = "dgwTask";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTask.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwTask.RowTemplate.Height = 24;
            this.dgwTask.Size = new System.Drawing.Size(1500, 54);
            this.dgwTask.TabIndex = 2;
            this.dgwTask.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTask_CellClick);
            this.dgwTask.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgwTask_ColumnWidthChanged);
            this.dgwTask.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgwTask_Scroll);
            // 
            // Task
            // 
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            // 
            // YazarTask
            // 
            this.YazarTask.HeaderText = "Görevli";
            this.YazarTask.Name = "YazarTask";
            // 
            // TarihTask
            // 
            this.TarihTask.HeaderText = "Teslim Tarihi";
            this.TarihTask.Name = "TarihTask";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnKaydet.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnKaydet.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseBorderColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(1298, 138);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(210, 51);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1784, 644);
            this.Controls.Add(this.grbTasks);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnScrumTable);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.simpleButton1);
            this.Name = "frmAnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStorie)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grbTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView dgwStorie;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnScrumTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbTasks;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.DataGridView dgwTask;
        private DevExpress.XtraEditors.SimpleButton btnTaskEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewComboBoxColumn YazarTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarihTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baslik;
        private System.Windows.Forms.DataGridViewComboBoxColumn Yazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarihStorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Storie;

    }
}

