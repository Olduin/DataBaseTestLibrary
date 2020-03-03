namespace SQLApp
{
    partial class LibrarianForm
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
            this.LBSelectPosition = new System.Windows.Forms.ListBox();
            this.LbPositionFilter = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // LBSelectPosition
            // 
            this.LBSelectPosition.FormattingEnabled = true;
            this.LBSelectPosition.Items.AddRange(new object[] {
            "Нет",
            "Библиотекарь",
            "Библиограф",
            "Работник отдела кадров"});
            this.LBSelectPosition.Location = new System.Drawing.Point(129, 308);
            this.LBSelectPosition.Name = "LBSelectPosition";
            this.LBSelectPosition.Size = new System.Drawing.Size(95, 56);
            this.LBSelectPosition.TabIndex = 1;
            this.LBSelectPosition.SelectedIndexChanged += new System.EventHandler(this.LBSelectPosition_SelectedIndexChanged);
            // 
            // LbPositionFilter
            // 
            this.LbPositionFilter.AutoSize = true;
            this.LbPositionFilter.Location = new System.Drawing.Point(12, 308);
            this.LbPositionFilter.Name = "LbPositionFilter";
            this.LbPositionFilter.Size = new System.Drawing.Size(111, 13);
            this.LbPositionFilter.TabIndex = 2;
            this.LbPositionFilter.Text = "Фитр по должности:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(620, 432);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(142, 23);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Добавить пользователя";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 469);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.LbPositionFilter);
            this.Controls.Add(this.LBSelectPosition);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LibrarianForm";
            this.Text = "LibrarianForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox LBSelectPosition;
        private System.Windows.Forms.Label LbPositionFilter;
        private System.Windows.Forms.Button btnAddUser;
    }
}