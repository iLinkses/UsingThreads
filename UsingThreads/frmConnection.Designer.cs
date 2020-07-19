namespace UsingThreads
{
    partial class frmConnection
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tbDataSourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInitialCatalog = new System.Windows.Forms.TextBox();
            this.chbIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(180, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbDataSourse
            // 
            this.tbDataSourse.Location = new System.Drawing.Point(110, 12);
            this.tbDataSourse.Name = "tbDataSourse";
            this.tbDataSourse.Size = new System.Drawing.Size(146, 22);
            this.tbDataSourse.TabIndex = 1;
            this.tbDataSourse.Text = ".\\SQL_EXPRESS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сервер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "База данных";
            // 
            // tbInitialCatalog
            // 
            this.tbInitialCatalog.Location = new System.Drawing.Point(110, 40);
            this.tbInitialCatalog.Name = "tbInitialCatalog";
            this.tbInitialCatalog.Size = new System.Drawing.Size(146, 22);
            this.tbInitialCatalog.TabIndex = 3;
            this.tbInitialCatalog.Text = "dbo";
            // 
            // chbIntegratedSecurity
            // 
            this.chbIntegratedSecurity.AutoSize = true;
            this.chbIntegratedSecurity.Checked = true;
            this.chbIntegratedSecurity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIntegratedSecurity.Location = new System.Drawing.Point(15, 68);
            this.chbIntegratedSecurity.Name = "chbIntegratedSecurity";
            this.chbIntegratedSecurity.Size = new System.Drawing.Size(184, 21);
            this.chbIntegratedSecurity.TabIndex = 5;
            this.chbIntegratedSecurity.Text = "Проверка подлинности";
            this.chbIntegratedSecurity.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(64, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Подключится";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmConnection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(267, 136);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chbIntegratedSecurity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInitialCatalog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDataSourse);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно подключения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbDataSourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInitialCatalog;
        private System.Windows.Forms.CheckBox chbIntegratedSecurity;
        private System.Windows.Forms.Button button2;
    }
}

