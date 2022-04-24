namespace PizzaStoreManagement.Dialogs
{
    partial class OrderProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderProduct));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseDialog = new RJCodeAdvance.RJControls.RJButton();
            this.lbHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new RJCodeAdvance.RJControls.RJButton();
            this.btnConfirm = new RJCodeAdvance.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbQuantity = new RJCodeAdvance.RJControls.RJTextBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.tbKind = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pnHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.pnHeader.Controls.Add(this.panel1);
            this.pnHeader.Controls.Add(this.lbHeader);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(709, 56);
            this.pnHeader.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseDialog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(650, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(59, 56);
            this.panel1.TabIndex = 1;
            // 
            // btnCloseDialog
            // 
            this.btnCloseDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseDialog.BackColor = System.Drawing.Color.Red;
            this.btnCloseDialog.BackgroundColor = System.Drawing.Color.Red;
            this.btnCloseDialog.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCloseDialog.BorderRadius = 0;
            this.btnCloseDialog.BorderSize = 0;
            this.btnCloseDialog.FlatAppearance.BorderSize = 0;
            this.btnCloseDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseDialog.ForeColor = System.Drawing.Color.White;
            this.btnCloseDialog.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseDialog.Image")));
            this.btnCloseDialog.Location = new System.Drawing.Point(6, 3);
            this.btnCloseDialog.Name = "btnCloseDialog";
            this.btnCloseDialog.Size = new System.Drawing.Size(50, 50);
            this.btnCloseDialog.TabIndex = 2;
            this.btnCloseDialog.TextColor = System.Drawing.Color.White;
            this.btnCloseDialog.UseVisualStyleBackColor = false;
            this.btnCloseDialog.Click += new System.EventHandler(this.btnCloseDialog_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.MinimumSize = new System.Drawing.Size(644, 56);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(644, 56);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Thông Tin Sản Phẩm";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbHeader_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 52);
            this.panel2.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 20;
            this.btnClose.BorderSize = 0;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 52);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.btnConfirm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.btnConfirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirm.BorderRadius = 20;
            this.btnConfirm.BorderSize = 0;
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(584, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(125, 52);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Xác Nhận";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(260, 214);
            this.label2.MinimumSize = new System.Drawing.Size(0, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 40);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số lượng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(253, 118);
            this.label1.MinimumSize = new System.Drawing.Size(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "Loại Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label7.Location = new System.Drawing.Point(253, 74);
            this.label7.MinimumSize = new System.Drawing.Size(0, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 40);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tên Sản Phẩm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbQuantity
            // 
            this.tbQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.tbQuantity.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbQuantity.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbQuantity.BorderRadius = 0;
            this.tbQuantity.BorderSize = 2;
            this.tbQuantity.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbQuantity.Location = new System.Drawing.Point(409, 214);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuantity.Multiline = false;
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbQuantity.PasswordChar = false;
            this.tbQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbQuantity.PlaceholderText = "";
            this.tbQuantity.Size = new System.Drawing.Size(287, 40);
            this.tbQuantity.TabIndex = 14;
            this.tbQuantity.Texts = "";
            this.tbQuantity.UnderlinedStyle = false;
            this.tbQuantity._TextChanged += new System.EventHandler(this.tbQuantity__TextChanged);
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(12, 62);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(200, 200);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 16;
            this.pbAvatar.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(254, 164);
            this.label3.MinimumSize = new System.Drawing.Size(0, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 40);
            this.label3.TabIndex = 20;
            this.label3.Text = "Đơn Vị Tính";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(261, 262);
            this.label4.MinimumSize = new System.Drawing.Size(0, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 40);
            this.label4.TabIndex = 17;
            this.label4.Text = "Giá Tiền";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Location = new System.Drawing.Point(409, 262);
            this.tbPrice.MinimumSize = new System.Drawing.Size(0, 40);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(286, 25);
            this.tbPrice.TabIndex = 22;
            // 
            // tbUnit
            // 
            this.tbUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.tbUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUnit.Location = new System.Drawing.Point(409, 164);
            this.tbUnit.MinimumSize = new System.Drawing.Size(0, 40);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.ReadOnly = true;
            this.tbUnit.Size = new System.Drawing.Size(286, 25);
            this.tbUnit.TabIndex = 22;
            // 
            // tbKind
            // 
            this.tbKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.tbKind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKind.Location = new System.Drawing.Point(409, 120);
            this.tbKind.MinimumSize = new System.Drawing.Size(0, 40);
            this.tbKind.Name = "tbKind";
            this.tbKind.ReadOnly = true;
            this.tbKind.Size = new System.Drawing.Size(286, 25);
            this.tbKind.TabIndex = 22;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Location = new System.Drawing.Point(409, 74);
            this.tbName.MinimumSize = new System.Drawing.Size(0, 40);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(286, 25);
            this.tbName.TabIndex = 22;
            // 
            // OrderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(709, 368);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbKind);
            this.Controls.Add(this.tbUnit);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderProduct";
            this.Text = "OrderProduct";
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJButton btnCloseDialog;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton btnClose;
        private RJCodeAdvance.RJControls.RJButton btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private RJCodeAdvance.RJControls.RJTextBox tbQuantity;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.TextBox tbKind;
        private System.Windows.Forms.TextBox tbName;
    }
}