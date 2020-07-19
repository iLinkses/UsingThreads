namespace UsingThreads
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_employ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_uneploy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеПодключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDeps = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPost = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStat = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.NameStatus,
            this.NameDep,
            this.NamePost,
            this.date_employ,
            this.date_uneploy});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 289);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // FIO
            // 
            this.FIO.DataPropertyName = "FIO";
            this.FIO.HeaderText = "ФИО";
            this.FIO.MinimumWidth = 6;
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            // 
            // NameStatus
            // 
            this.NameStatus.DataPropertyName = "NameStatus";
            this.NameStatus.HeaderText = "Статус";
            this.NameStatus.MinimumWidth = 6;
            this.NameStatus.Name = "NameStatus";
            this.NameStatus.ReadOnly = true;
            // 
            // NameDep
            // 
            this.NameDep.DataPropertyName = "NameDep";
            this.NameDep.HeaderText = "Отдел";
            this.NameDep.MinimumWidth = 6;
            this.NameDep.Name = "NameDep";
            this.NameDep.ReadOnly = true;
            // 
            // NamePost
            // 
            this.NamePost.DataPropertyName = "NamePost";
            this.NamePost.HeaderText = "Должность";
            this.NamePost.MinimumWidth = 6;
            this.NamePost.Name = "NamePost";
            this.NamePost.ReadOnly = true;
            // 
            // date_employ
            // 
            this.date_employ.DataPropertyName = "date_employ";
            this.date_employ.HeaderText = "Дата приема";
            this.date_employ.MinimumWidth = 6;
            this.date_employ.Name = "date_employ";
            this.date_employ.ReadOnly = true;
            // 
            // date_uneploy
            // 
            this.date_uneploy.DataPropertyName = "date_uneploy";
            this.date_uneploy.HeaderText = "Дата увольнения";
            this.date_uneploy.MinimumWidth = 6;
            this.date_uneploy.Name = "date_uneploy";
            this.date_uneploy.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новоеПодключениеToolStripMenuItem,
            this.сохранитьОтчетToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // новоеПодключениеToolStripMenuItem
            // 
            this.новоеПодключениеToolStripMenuItem.Name = "новоеПодключениеToolStripMenuItem";
            this.новоеПодключениеToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.новоеПодключениеToolStripMenuItem.Text = "Новое подключение...";
            this.новоеПодключениеToolStripMenuItem.Click += new System.EventHandler(this.новоеПодключениеToolStripMenuItem_Click);
            // 
            // сохранитьОтчетToolStripMenuItem
            // 
            this.сохранитьОтчетToolStripMenuItem.Name = "сохранитьОтчетToolStripMenuItem";
            this.сохранитьОтчетToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.сохранитьОтчетToolStripMenuItem.Text = "Сохранить отчет";
            this.сохранитьОтчетToolStripMenuItem.Click += new System.EventHandler(this.сохранитьОтчетToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(71, 31);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(177, 24);
            this.cbStatus.TabIndex = 3;
            this.cbStatus.SelectionChangeCommitted += new System.EventHandler(this.cbStatus_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Статус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Отдел";
            // 
            // cbDeps
            // 
            this.cbDeps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeps.FormattingEnabled = true;
            this.cbDeps.Location = new System.Drawing.Point(310, 31);
            this.cbDeps.Name = "cbDeps";
            this.cbDeps.Size = new System.Drawing.Size(196, 24);
            this.cbDeps.TabIndex = 5;
            this.cbDeps.SelectionChangeCommitted += new System.EventHandler(this.cbDeps_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Должность";
            // 
            // cbPost
            // 
            this.cbPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPost.FormattingEnabled = true;
            this.cbPost.Location = new System.Drawing.Point(599, 31);
            this.cbPost.Name = "cbPost";
            this.cbPost.Size = new System.Drawing.Size(189, 24);
            this.cbPost.TabIndex = 7;
            this.cbPost.SelectionChangeCommitted += new System.EventHandler(this.cbPost_SelectionChangeCommitted);
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(12, 61);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(107, 22);
            this.dtpStart.TabIndex = 9;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(125, 61);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(107, 22);
            this.dtpEnd.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSSL
            // 
            this.tSSL.Name = "tSSL";
            this.tSSL.Size = new System.Drawing.Size(0, 16);
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Location = new System.Drawing.Point(111, 418);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(0, 17);
            this.lblStat.TabIndex = 12;
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(12, 90);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(131, 22);
            this.tbFIO.TabIndex = 13;
            this.tbFIO.TextChanged += new System.EventHandler(this.tbFIO_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDeps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеПодключениеToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDeps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePost;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_employ;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_uneploy;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ToolStripMenuItem сохранитьОтчетToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSSL;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.TextBox tbFIO;
    }
}