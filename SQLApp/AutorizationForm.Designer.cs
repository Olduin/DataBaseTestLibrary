namespace SQLApp
{
    partial class AutorizationForm
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
            this.btnAuhorization = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAuhorization
            // 
            this.btnAuhorization.Location = new System.Drawing.Point(66, 80);
            this.btnAuhorization.Name = "btnAuhorization";
            this.btnAuhorization.Size = new System.Drawing.Size(105, 23);
            this.btnAuhorization.TabIndex = 0;
            this.btnAuhorization.Text = "Авторизоваться";
            this.btnAuhorization.UseVisualStyleBackColor = true;
            this.btnAuhorization.Click += new System.EventHandler(this.btnAuhorization_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(63, 16);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(138, 20);
            this.tbLogin.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(63, 42);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(138, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 135);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(243, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(19, 19);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(38, 13);
            this.lbLogin.TabIndex = 4;
            this.lbLogin.Text = "Логин";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(12, 45);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(45, 13);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Пароль";
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 157);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.btnAuhorization);
            this.Name = "AutorizationForm";
            this.Text = "Авторизация";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuhorization;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbPassword;
    }
}

