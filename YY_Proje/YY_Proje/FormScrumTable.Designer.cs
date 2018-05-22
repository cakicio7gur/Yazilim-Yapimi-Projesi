namespace YY_Proje
{
    partial class FormScrumTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScrumTable));
            this.txtBul = new System.Windows.Forms.TextBox();
            this.btnStorieBul = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwStory = new System.Windows.Forms.DataGridView();
            this.btnAnaSayfa = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInProgressAktar = new DevExpress.XtraEditors.SimpleButton();
            this.dgwNotStarted = new System.Windows.Forms.DataGridView();
            this.SecimNotStarted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDoneAktar = new DevExpress.XtraEditors.SimpleButton();
            this.dgwInProgress = new System.Windows.Forms.DataGridView();
            this.SecimInProgress = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNotStartedAktar = new DevExpress.XtraEditors.SimpleButton();
            this.dgwDone = new System.Windows.Forms.DataGridView();
            this.SecimDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStory)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotStarted)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInProgress)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDone)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(111, 93);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(158, 28);
            this.txtBul.TabIndex = 13;
            this.txtBul.Text = "Story1";
            // 
            // btnStorieBul
            // 
            this.btnStorieBul.Appearance.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStorieBul.Appearance.Options.UseFont = true;
            this.btnStorieBul.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnStorieBul.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStorieBul.ImageOptions.Image")));
            this.btnStorieBul.Location = new System.Drawing.Point(293, 77);
            this.btnStorieBul.Name = "btnStorieBul";
            this.btnStorieBul.Size = new System.Drawing.Size(134, 50);
            this.btnStorieBul.TabIndex = 12;
            this.btnStorieBul.Text = "Bul";
            this.btnStorieBul.Click += new System.EventHandler(this.btnStorieBul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(128, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Story Giriniz :";
            // 
            // dgwStory
            // 
            this.dgwStory.AllowUserToAddRows = false;
            this.dgwStory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStory.Location = new System.Drawing.Point(6, 142);
            this.dgwStory.Name = "dgwStory";
            this.dgwStory.RowTemplate.Height = 24;
            this.dgwStory.Size = new System.Drawing.Size(420, 545);
            this.dgwStory.TabIndex = 4;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.Image")));
            this.btnAnaSayfa.Location = new System.Drawing.Point(29, 68);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(54, 50);
            this.btnAnaSayfa.TabIndex = 15;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAnaSayfa);
            this.groupBox1.Controls.Add(this.dgwStory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnStorieBul);
            this.groupBox1.Controls.Add(this.txtBul);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 693);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(149, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "STORİES";
            // 
            // btnInProgressAktar
            // 
            this.btnInProgressAktar.Appearance.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInProgressAktar.Appearance.Options.UseFont = true;
            this.btnInProgressAktar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInProgressAktar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnInProgressAktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInProgressAktar.ImageOptions.Image")));
            this.btnInProgressAktar.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnInProgressAktar.Location = new System.Drawing.Point(266, 72);
            this.btnInProgressAktar.Name = "btnInProgressAktar";
            this.btnInProgressAktar.Size = new System.Drawing.Size(162, 59);
            this.btnInProgressAktar.TabIndex = 9;
            this.btnInProgressAktar.Text = "Gönder";
            this.btnInProgressAktar.Click += new System.EventHandler(this.btnInProgressAktar_Click);
            // 
            // dgwNotStarted
            // 
            this.dgwNotStarted.AllowDrop = true;
            this.dgwNotStarted.AllowUserToAddRows = false;
            this.dgwNotStarted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwNotStarted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNotStarted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SecimNotStarted});
            this.dgwNotStarted.Location = new System.Drawing.Point(8, 142);
            this.dgwNotStarted.Name = "dgwNotStarted";
            this.dgwNotStarted.RowTemplate.Height = 24;
            this.dgwNotStarted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwNotStarted.Size = new System.Drawing.Size(420, 545);
            this.dgwNotStarted.TabIndex = 8;
            // 
            // SecimNotStarted
            // 
            this.SecimNotStarted.HeaderText = "Seç";
            this.SecimNotStarted.Name = "SecimNotStarted";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Orchid;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgwNotStarted);
            this.groupBox2.Controls.Add(this.btnInProgressAktar);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(450, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 693);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(155, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "NOT STARTED";
            // 
            // btnDoneAktar
            // 
            this.btnDoneAktar.Appearance.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoneAktar.Appearance.Options.UseFont = true;
            this.btnDoneAktar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDoneAktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoneAktar.ImageOptions.Image")));
            this.btnDoneAktar.Location = new System.Drawing.Point(264, 72);
            this.btnDoneAktar.Name = "btnDoneAktar";
            this.btnDoneAktar.Size = new System.Drawing.Size(162, 59);
            this.btnDoneAktar.TabIndex = 10;
            this.btnDoneAktar.Text = "Gönder";
            this.btnDoneAktar.Click += new System.EventHandler(this.btnDoneAktar_Click);
            // 
            // dgwInProgress
            // 
            this.dgwInProgress.AllowDrop = true;
            this.dgwInProgress.AllowUserToAddRows = false;
            this.dgwInProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwInProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInProgress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SecimInProgress});
            this.dgwInProgress.Location = new System.Drawing.Point(6, 142);
            this.dgwInProgress.Name = "dgwInProgress";
            this.dgwInProgress.RowTemplate.Height = 24;
            this.dgwInProgress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwInProgress.Size = new System.Drawing.Size(420, 545);
            this.dgwInProgress.TabIndex = 8;
            // 
            // SecimInProgress
            // 
            this.SecimInProgress.HeaderText = "Seç";
            this.SecimInProgress.Name = "SecimInProgress";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SlateBlue;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dgwInProgress);
            this.groupBox3.Controls.Add(this.btnDoneAktar);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(896, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 693);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(149, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "IN PROGRESS";
            // 
            // btnNotStartedAktar
            // 
            this.btnNotStartedAktar.Appearance.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotStartedAktar.Appearance.Options.UseFont = true;
            this.btnNotStartedAktar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNotStartedAktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNotStartedAktar.ImageOptions.Image")));
            this.btnNotStartedAktar.Location = new System.Drawing.Point(265, 72);
            this.btnNotStartedAktar.Name = "btnNotStartedAktar";
            this.btnNotStartedAktar.Size = new System.Drawing.Size(162, 59);
            this.btnNotStartedAktar.TabIndex = 11;
            this.btnNotStartedAktar.Text = "Gönder";
            this.btnNotStartedAktar.Click += new System.EventHandler(this.btnNotStartedAktar_Click);
            // 
            // dgwDone
            // 
            this.dgwDone.AllowDrop = true;
            this.dgwDone.AllowUserToAddRows = false;
            this.dgwDone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SecimDone});
            this.dgwDone.Location = new System.Drawing.Point(7, 142);
            this.dgwDone.Name = "dgwDone";
            this.dgwDone.RowTemplate.Height = 24;
            this.dgwDone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDone.Size = new System.Drawing.Size(420, 545);
            this.dgwDone.TabIndex = 7;
            // 
            // SecimDone
            // 
            this.SecimDone.HeaderText = "Seç";
            this.SecimDone.Name = "SecimDone";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Pink;
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dgwDone);
            this.groupBox4.Controls.Add(this.btnNotStartedAktar);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(1343, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(447, 693);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(200, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "DONE";
            // 
            // FormScrumTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1796, 698);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormScrumTable";
            this.Text = "Scrum Table";
            this.Load += new System.EventHandler(this.FormScrumTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotStarted)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInProgress)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDone)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBul;
        private DevExpress.XtraEditors.SimpleButton btnStorieBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwStory;
        private DevExpress.XtraEditors.SimpleButton btnAnaSayfa;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnInProgressAktar;
        private System.Windows.Forms.DataGridView dgwNotStarted;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SecimNotStarted;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnDoneAktar;
        private System.Windows.Forms.DataGridView dgwInProgress;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SecimInProgress;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnNotStartedAktar;
        private System.Windows.Forms.DataGridView dgwDone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SecimDone;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;


    }
}