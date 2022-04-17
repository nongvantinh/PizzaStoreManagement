namespace PizzaStoreManagement.Forms
{
    partial class ManageEmployee
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
            this.employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_date_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employee_id,
            this.employee_name,
            this.employee_role,
            this.employee_date_of_birth,
            this.Column1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(977, 526);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // employee_id
            // 
            this.employee_id.HeaderText = "ID";
            this.employee_id.MinimumWidth = 6;
            this.employee_id.Name = "employee_id";
            this.employee_id.ReadOnly = true;
            this.employee_id.Width = 150;
            // 
            // employee_name
            // 
            this.employee_name.HeaderText = "Tên Nhân Viên";
            this.employee_name.MinimumWidth = 6;
            this.employee_name.Name = "employee_name";
            this.employee_name.ReadOnly = true;
            this.employee_name.Width = 300;
            // 
            // employee_role
            // 
            this.employee_role.HeaderText = "Chức Vụ";
            this.employee_role.MinimumWidth = 6;
            this.employee_role.Name = "employee_role";
            this.employee_role.ReadOnly = true;
            this.employee_role.Width = 150;
            // 
            // employee_date_of_birth
            // 
            this.employee_date_of_birth.HeaderText = "Ngày Sinh";
            this.employee_date_of_birth.MinimumWidth = 6;
            this.employee_date_of_birth.Name = "employee_date_of_birth";
            this.employee_date_of_birth.ReadOnly = true;
            this.employee_date_of_birth.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SDT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 225;
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(977, 526);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageEmployee";
            this.Text = "Quản Lý Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_date_of_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}