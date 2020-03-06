namespace SQLApp
{
    partial class Employee
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LbPositionFilter = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.cbFilterPosition = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // LbPositionFilter
            // 
            this.LbPositionFilter.AutoSize = true;
            this.LbPositionFilter.Location = new System.Drawing.Point(549, 24);
            this.LbPositionFilter.Name = "LbPositionFilter";
            this.LbPositionFilter.Size = new System.Drawing.Size(111, 13);
            this.LbPositionFilter.TabIndex = 2;
            this.LbPositionFilter.Text = "Фитр по должности:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(645, 424);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(142, 23);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Добавить пользователя";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // cbFilterPosition
            // 
            this.cbFilterPosition.FormattingEnabled = true;
            this.cbFilterPosition.Items.AddRange(new object[] {
            "Все",
            "Библиотекарь",
            "Библиограф",
            "Работник отдела кадров"});
            this.cbFilterPosition.Location = new System.Drawing.Point(666, 21);
            this.cbFilterPosition.Name = "cbFilterPosition";
            this.cbFilterPosition.Size = new System.Drawing.Size(121, 21);
            this.cbFilterPosition.TabIndex = 4;
            this.cbFilterPosition.SelectedIndexChanged += new System.EventHandler(this.cbFilterPosition_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbFilterPosition);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.LbPositionFilter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LibrarianForm";
            this.Text = "LibrarianForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LbPositionFilter;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ComboBox cbFilterPosition;
        private System.Windows.Forms.Button button1;
    }
}