namespace PizzaStoreManagement.Dialogs
{
    partial class Promotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Promotion));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseDialog = new RJCodeAdvance.RJControls.RJButton();
            this.lbHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbContents = new System.Windows.Forms.RichTextBox();
            this.cbkindOfPromotion = new RJCodeAdvance.RJControls.RJComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPercentDiscount = new RJCodeAdvance.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCashDiscount = new RJCodeAdvance.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaxDiscount = new RJCodeAdvance.RJControls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCondition = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new RJCodeAdvance.RJControls.RJButton();
            this.btnConfirm = new RJCodeAdvance.RJControls.RJButton();
            this.lbProductName = new System.Windows.Forms.Label();
            this.cbProductName = new RJCodeAdvance.RJControls.RJComboBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cbIncremental = new System.Windows.Forms.CheckBox();
            this.pnHeader.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnHeader.Size = new System.Drawing.Size(579, 56);
            this.pnHeader.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseDialog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(520, 0);
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
            this.lbHeader.MinimumSize = new System.Drawing.Size(499, 56);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(499, 56);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Thông Tin Khuyễn Mãi";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbHeader_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(4, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nội dung khuyễn mãi";
            // 
            // rtbContents
            // 
            this.rtbContents.Location = new System.Drawing.Point(218, 75);
            this.rtbContents.Name = "rtbContents";
            this.rtbContents.Size = new System.Drawing.Size(351, 87);
            this.rtbContents.TabIndex = 14;
            this.rtbContents.Text = "";
            // 
            // cbkindOfPromotion
            // 
            this.cbkindOfPromotion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbkindOfPromotion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbkindOfPromotion.BorderSize = 1;
            this.cbkindOfPromotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbkindOfPromotion.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.cbkindOfPromotion.ForeColor = System.Drawing.Color.DimGray;
            this.cbkindOfPromotion.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbkindOfPromotion.Items.AddRange(new object[] {
            "Giảm hóa đơn",
            "Giảm món"});
            this.cbkindOfPromotion.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbkindOfPromotion.ListTextColor = System.Drawing.Color.DimGray;
            this.cbkindOfPromotion.Location = new System.Drawing.Point(218, 168);
            this.cbkindOfPromotion.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbkindOfPromotion.Name = "cbkindOfPromotion";
            this.cbkindOfPromotion.Padding = new System.Windows.Forms.Padding(1);
            this.cbkindOfPromotion.Size = new System.Drawing.Size(351, 37);
            this.cbkindOfPromotion.TabIndex = 15;
            this.cbkindOfPromotion.Texts = "";
            this.cbkindOfPromotion.OnSelectedIndexChanged += new System.EventHandler(this.cbkindOfPromotion_OnSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Loại khuyễn mãi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(13, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Giảm (%):";
            // 
            // tbPercentDiscount
            // 
            this.tbPercentDiscount.BackColor = System.Drawing.SystemColors.Window;
            this.tbPercentDiscount.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbPercentDiscount.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbPercentDiscount.BorderRadius = 0;
            this.tbPercentDiscount.BorderSize = 2;
            this.tbPercentDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPercentDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPercentDiscount.Location = new System.Drawing.Point(217, 255);
            this.tbPercentDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.tbPercentDiscount.Multiline = false;
            this.tbPercentDiscount.Name = "tbPercentDiscount";
            this.tbPercentDiscount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbPercentDiscount.PasswordChar = false;
            this.tbPercentDiscount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPercentDiscount.PlaceholderText = "";
            this.tbPercentDiscount.Size = new System.Drawing.Size(350, 35);
            this.tbPercentDiscount.TabIndex = 16;
            this.tbPercentDiscount.Texts = "";
            this.tbPercentDiscount.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(13, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giảm (tiền mặt):";
            // 
            // tbCashDiscount
            // 
            this.tbCashDiscount.BackColor = System.Drawing.SystemColors.Window;
            this.tbCashDiscount.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbCashDiscount.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbCashDiscount.BorderRadius = 0;
            this.tbCashDiscount.BorderSize = 2;
            this.tbCashDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCashDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCashDiscount.Location = new System.Drawing.Point(217, 298);
            this.tbCashDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.tbCashDiscount.Multiline = false;
            this.tbCashDiscount.Name = "tbCashDiscount";
            this.tbCashDiscount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbCashDiscount.PasswordChar = false;
            this.tbCashDiscount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbCashDiscount.PlaceholderText = "";
            this.tbCashDiscount.Size = new System.Drawing.Size(350, 35);
            this.tbCashDiscount.TabIndex = 16;
            this.tbCashDiscount.Texts = "";
            this.tbCashDiscount.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label5.Location = new System.Drawing.Point(13, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giảm tối đa:";
            // 
            // tbMaxDiscount
            // 
            this.tbMaxDiscount.BackColor = System.Drawing.SystemColors.Window;
            this.tbMaxDiscount.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbMaxDiscount.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbMaxDiscount.BorderRadius = 0;
            this.tbMaxDiscount.BorderSize = 2;
            this.tbMaxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMaxDiscount.Location = new System.Drawing.Point(217, 341);
            this.tbMaxDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaxDiscount.Multiline = false;
            this.tbMaxDiscount.Name = "tbMaxDiscount";
            this.tbMaxDiscount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbMaxDiscount.PasswordChar = false;
            this.tbMaxDiscount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbMaxDiscount.PlaceholderText = "";
            this.tbMaxDiscount.Size = new System.Drawing.Size(350, 35);
            this.tbMaxDiscount.TabIndex = 16;
            this.tbMaxDiscount.Texts = "";
            this.tbMaxDiscount.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label6.Location = new System.Drawing.Point(13, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Điều kiện:";
            // 
            // tbCondition
            // 
            this.tbCondition.BackColor = System.Drawing.SystemColors.Window;
            this.tbCondition.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbCondition.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbCondition.BorderRadius = 0;
            this.tbCondition.BorderSize = 2;
            this.tbCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCondition.Location = new System.Drawing.Point(217, 384);
            this.tbCondition.Margin = new System.Windows.Forms.Padding(4);
            this.tbCondition.Multiline = false;
            this.tbCondition.Name = "tbCondition";
            this.tbCondition.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbCondition.PasswordChar = false;
            this.tbCondition.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbCondition.PlaceholderText = "";
            this.tbCondition.Size = new System.Drawing.Size(350, 35);
            this.tbCondition.TabIndex = 16;
            this.tbCondition.Texts = "";
            this.tbCondition.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 52);
            this.panel2.TabIndex = 22;
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
            this.btnConfirm.Location = new System.Drawing.Point(454, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(125, 52);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Xác Nhận";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lbProductName.Location = new System.Drawing.Point(11, 216);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(99, 25);
            this.lbProductName.TabIndex = 13;
            this.lbProductName.Text = "Mặt hàng:";
            // 
            // cbProductName
            // 
            this.cbProductName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbProductName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbProductName.BorderSize = 1;
            this.cbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbProductName.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.cbProductName.ForeColor = System.Drawing.Color.DimGray;
            this.cbProductName.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbProductName.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbProductName.ListTextColor = System.Drawing.Color.DimGray;
            this.cbProductName.Location = new System.Drawing.Point(217, 211);
            this.cbProductName.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Padding = new System.Windows.Forms.Padding(1);
            this.cbProductName.Size = new System.Drawing.Size(351, 37);
            this.cbProductName.TabIndex = 15;
            this.cbProductName.Texts = "";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(155, 426);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(131, 32);
            this.dtpStartDate.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label8.Location = new System.Drawing.Point(13, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ngày bắt đầu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label9.Location = new System.Drawing.Point(292, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ngày kết thúc:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(434, 426);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(131, 32);
            this.dtpEndDate.TabIndex = 23;
            // 
            // cbIncremental
            // 
            this.cbIncremental.AutoSize = true;
            this.cbIncremental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.cbIncremental.Location = new System.Drawing.Point(17, 464);
            this.cbIncremental.Name = "cbIncremental";
            this.cbIncremental.Size = new System.Drawing.Size(310, 29);
            this.cbIncremental.TabIndex = 24;
            this.cbIncremental.Text = "Cho phép cộng dồn khuyễn mãi";
            this.cbIncremental.UseVisualStyleBackColor = true;
            // 
            // Promotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(579, 548);
            this.Controls.Add(this.cbIncremental);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbCondition);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbMaxDiscount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCashDiscount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPercentDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbProductName);
            this.Controls.Add(this.cbkindOfPromotion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.rtbContents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnHeader);
            this.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Promotion";
            this.Text = "Promotion";
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJButton btnCloseDialog;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbContents;
        private RJCodeAdvance.RJControls.RJComboBox cbkindOfPromotion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJTextBox tbPercentDiscount;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJTextBox tbCashDiscount;
        private System.Windows.Forms.Label label5;
        private RJCodeAdvance.RJControls.RJTextBox tbMaxDiscount;
        private System.Windows.Forms.Label label6;
        private RJCodeAdvance.RJControls.RJTextBox tbCondition;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton btnClose;
        private RJCodeAdvance.RJControls.RJButton btnConfirm;
        private System.Windows.Forms.Label lbProductName;
        private RJCodeAdvance.RJControls.RJComboBox cbProductName;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.CheckBox cbIncremental;
    }
}