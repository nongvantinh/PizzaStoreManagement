namespace PizzaStoreManagement.Dialogs
{
    partial class ProductInfomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfomation));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseDialog = new RJCodeAdvance.RJControls.RJButton();
            this.lbHeader = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbName = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKind = new RJCodeAdvance.RJControls.RJComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrice = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new RJCodeAdvance.RJControls.RJButton();
            this.btnConfirm = new RJCodeAdvance.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUnit = new RJCodeAdvance.RJControls.RJComboBox();
            this.pnHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.pnHeader.TabIndex = 3;
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
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(12, 62);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(200, 200);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 4;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.pbAvatar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label7.Location = new System.Drawing.Point(253, 74);
            this.label7.MinimumSize = new System.Drawing.Size(0, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 40);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tên Sản Phẩm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Window;
            this.tbName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbName.BorderRadius = 0;
            this.tbName.BorderSize = 2;
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbName.Location = new System.Drawing.Point(403, 74);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbName.PasswordChar = false;
            this.tbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbName.PlaceholderText = "";
            this.tbName.Size = new System.Drawing.Size(287, 40);
            this.tbName.TabIndex = 0;
            this.tbName.Texts = "";
            this.tbName.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(253, 118);
            this.label1.MinimumSize = new System.Drawing.Size(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Loại Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbKind
            // 
            this.cbKind.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbKind.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbKind.BorderSize = 2;
            this.cbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbKind.ForeColor = System.Drawing.Color.DimGray;
            this.cbKind.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbKind.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbKind.ListTextColor = System.Drawing.Color.DimGray;
            this.cbKind.Location = new System.Drawing.Point(402, 121);
            this.cbKind.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbKind.Name = "cbKind";
            this.cbKind.Padding = new System.Windows.Forms.Padding(2);
            this.cbKind.Size = new System.Drawing.Size(288, 40);
            this.cbKind.TabIndex = 1;
            this.cbKind.Texts = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(254, 214);
            this.label2.MinimumSize = new System.Drawing.Size(0, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Giá Tiền";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.SystemColors.Window;
            this.tbPrice.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbPrice.BorderRadius = 0;
            this.tbPrice.BorderSize = 2;
            this.tbPrice.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPrice.Location = new System.Drawing.Point(403, 214);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice.Multiline = false;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbPrice.PasswordChar = false;
            this.tbPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPrice.PlaceholderText = "";
            this.tbPrice.Size = new System.Drawing.Size(287, 40);
            this.tbPrice.TabIndex = 2;
            this.tbPrice.Texts = "";
            this.tbPrice.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 52);
            this.panel2.TabIndex = 10;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(254, 164);
            this.label3.MinimumSize = new System.Drawing.Size(0, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đơn Vị Tính";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbUnit
            // 
            this.cbUnit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbUnit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbUnit.BorderSize = 2;
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbUnit.ForeColor = System.Drawing.Color.DimGray;
            this.cbUnit.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbUnit.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbUnit.ListTextColor = System.Drawing.Color.DimGray;
            this.cbUnit.Location = new System.Drawing.Point(403, 167);
            this.cbUnit.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Padding = new System.Windows.Forms.Padding(2);
            this.cbUnit.Size = new System.Drawing.Size(288, 40);
            this.cbUnit.TabIndex = 1;
            this.cbUnit.Texts = "";
            // 
            // ProductInfomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(709, 329);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbKind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.pnHeader);
            this.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductInfomation";
            this.Text = "Thông Tin Bàn Ăn";
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJButton btnCloseDialog;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label label7;
        private RJCodeAdvance.RJControls.RJTextBox tbName;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJComboBox cbKind;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox tbPrice;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton btnClose;
        private RJCodeAdvance.RJControls.RJButton btnConfirm;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJComboBox cbUnit;
    }
}