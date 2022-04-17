namespace PizzaStoreManagement.Forms
{
    partial class SideMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideMenu));
            this.pnSIdeMenu = new System.Windows.Forms.Panel();
            this.pnSideMenuContents = new System.Windows.Forms.Panel();
            this.pnSideMenuManage = new System.Windows.Forms.Panel();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.pnSideMenuHeader = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnSIdeMenu.SuspendLayout();
            this.pnSideMenuContents.SuspendLayout();
            this.pnSideMenuManage.SuspendLayout();
            this.pnSideMenuHeader.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSIdeMenu
            // 
            this.pnSIdeMenu.Controls.Add(this.pnSideMenuContents);
            this.pnSIdeMenu.Controls.Add(this.pnSideMenuHeader);
            this.pnSIdeMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSIdeMenu.Location = new System.Drawing.Point(0, 0);
            this.pnSIdeMenu.Name = "pnSIdeMenu";
            this.pnSIdeMenu.Size = new System.Drawing.Size(249, 626);
            this.pnSIdeMenu.TabIndex = 1;
            // 
            // pnSideMenuContents
            // 
            this.pnSideMenuContents.AutoScroll = true;
            this.pnSideMenuContents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.pnSideMenuContents.Controls.Add(this.pnSideMenuManage);
            this.pnSideMenuContents.Controls.Add(this.btnManage);
            this.pnSideMenuContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSideMenuContents.Location = new System.Drawing.Point(0, 330);
            this.pnSideMenuContents.Name = "pnSideMenuContents";
            this.pnSideMenuContents.Size = new System.Drawing.Size(249, 296);
            this.pnSideMenuContents.TabIndex = 3;
            // 
            // pnSideMenuManage
            // 
            this.pnSideMenuManage.AutoSize = true;
            this.pnSideMenuManage.Controls.Add(this.btnStore);
            this.pnSideMenuManage.Controls.Add(this.btnRole);
            this.pnSideMenuManage.Controls.Add(this.btnEmployee);
            this.pnSideMenuManage.Controls.Add(this.btnProduct);
            this.pnSideMenuManage.Controls.Add(this.btnStatistics);
            this.pnSideMenuManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSideMenuManage.Location = new System.Drawing.Point(0, 57);
            this.pnSideMenuManage.Name = "pnSideMenuManage";
            this.pnSideMenuManage.Size = new System.Drawing.Size(228, 285);
            this.pnSideMenuManage.TabIndex = 3;
            // 
            // btnStore
            // 
            this.btnStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStore.FlatAppearance.BorderSize = 0;
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnStore.Image = ((System.Drawing.Image)(resources.GetObject("btnStore.Image")));
            this.btnStore.Location = new System.Drawing.Point(0, 228);
            this.btnStore.Name = "btnStore";
            this.btnStore.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStore.Size = new System.Drawing.Size(228, 57);
            this.btnStore.TabIndex = 9;
            this.btnStore.Text = "     Cửa Hàng";
            this.btnStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStore.UseVisualStyleBackColor = true;
            // 
            // btnRole
            // 
            this.btnRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRole.FlatAppearance.BorderSize = 0;
            this.btnRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnRole.Image = ((System.Drawing.Image)(resources.GetObject("btnRole.Image")));
            this.btnRole.Location = new System.Drawing.Point(0, 171);
            this.btnRole.Name = "btnRole";
            this.btnRole.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRole.Size = new System.Drawing.Size(228, 57);
            this.btnRole.TabIndex = 8;
            this.btnRole.Text = "     Chức Vụ";
            this.btnRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRole.UseVisualStyleBackColor = true;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.Location = new System.Drawing.Point(0, 114);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(228, 57);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "     Nhân Viên";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.Location = new System.Drawing.Point(0, 57);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(228, 57);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "     Sản Phẩm";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnStatistics.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistics.Image")));
            this.btnStatistics.Location = new System.Drawing.Point(0, 0);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStatistics.Size = new System.Drawing.Size(228, 57);
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.Text = "     Thống Kê";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnManage
            // 
            this.btnManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnManage.Image = ((System.Drawing.Image)(resources.GetObject("btnManage.Image")));
            this.btnManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.Location = new System.Drawing.Point(0, 0);
            this.btnManage.Name = "btnManage";
            this.btnManage.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnManage.Size = new System.Drawing.Size(228, 57);
            this.btnManage.TabIndex = 2;
            this.btnManage.Text = "     Quản lý";
            this.btnManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // pnSideMenuHeader
            // 
            this.pnSideMenuHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.pnSideMenuHeader.Controls.Add(this.panel4);
            this.pnSideMenuHeader.Controls.Add(this.panel1);
            this.pnSideMenuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSideMenuHeader.Location = new System.Drawing.Point(0, 0);
            this.pnSideMenuHeader.Name = "pnSideMenuHeader";
            this.pnSideMenuHeader.Size = new System.Drawing.Size(249, 330);
            this.pnSideMenuHeader.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rjCircularPictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 273);
            this.panel4.TabIndex = 8;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox1.Image")));
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(249, 249);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox1.TabIndex = 8;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 57);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(105, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 57);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(0, -3);
            this.label4.MinimumSize = new System.Drawing.Size(150, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nông Văn Tình";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label5.Location = new System.Drawing.Point(0, 27);
            this.label5.MinimumSize = new System.Drawing.Size(150, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Can\'t tell it";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(105, 57);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(0, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(0, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chức Vụ:";
            // 
            // SideMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(249, 626);
            this.Controls.Add(this.pnSIdeMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SideMenu";
            this.Text = "SideMenu";
            this.pnSIdeMenu.ResumeLayout(false);
            this.pnSideMenuContents.ResumeLayout(false);
            this.pnSideMenuContents.PerformLayout();
            this.pnSideMenuManage.ResumeLayout(false);
            this.pnSideMenuHeader.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSIdeMenu;
        private System.Windows.Forms.Panel pnSideMenuContents;
        private System.Windows.Forms.Panel pnSideMenuManage;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Panel pnSideMenuHeader;
        private System.Windows.Forms.Panel panel4;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.Button btnStore;
    }
}