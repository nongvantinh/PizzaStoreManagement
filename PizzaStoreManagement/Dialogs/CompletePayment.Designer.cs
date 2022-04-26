namespace PizzaStoreManagement.Dialogs
{
    partial class CompletePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompletePayment));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseDialog = new RJCodeAdvance.RJControls.RJButton();
            this.lbHeader = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPay = new RJCodeAdvance.RJControls.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnApplyVoucher = new RJCodeAdvance.RJControls.RJButton();
            this.rtbVoucherContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbVoucherCode = new RJCodeAdvance.RJControls.RJTextBox();
            this.pnPromotions = new System.Windows.Forms.Panel();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.pnHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnPromotions.SuspendLayout();
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
            this.pnHeader.Size = new System.Drawing.Size(1262, 56);
            this.pnHeader.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseDialog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1203, 0);
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
            this.lbHeader.MinimumSize = new System.Drawing.Size(1262, 56);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(1262, 56);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Hoàn Thành Thanh Toán";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbHeader_MouseDown);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.pnMain.Controls.Add(this.dataGridView1);
            this.pnMain.Controls.Add(this.panel3);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(431, 56);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(831, 617);
            this.pnMain.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_name,
            this.Column1,
            this.product_kind,
            this.product_unit,
            this.product_price});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(831, 555);
            this.dataGridView1.TabIndex = 7;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "ID";
            this.product_id.MinimumWidth = 6;
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Width = 6;
            // 
            // product_name
            // 
            this.product_name.HeaderText = "Tên Sản Phẩm";
            this.product_name.MinimumWidth = 6;
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            this.product_name.Width = 275;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Giá Tiền";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // product_kind
            // 
            this.product_kind.HeaderText = "Số Lượng";
            this.product_kind.MinimumWidth = 6;
            this.product_kind.Name = "product_kind";
            this.product_kind.ReadOnly = true;
            this.product_kind.Width = 125;
            // 
            // product_unit
            // 
            this.product_unit.HeaderText = "Đơn Vị Tính";
            this.product_unit.MinimumWidth = 6;
            this.product_unit.Name = "product_unit";
            this.product_unit.ReadOnly = true;
            this.product_unit.Width = 125;
            // 
            // product_price
            // 
            this.product_price.HeaderText = "Thành Tiền";
            this.product_price.MinimumWidth = 6;
            this.product_price.Name = "product_price";
            this.product_price.ReadOnly = true;
            this.product_price.Width = 150;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbTotal);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 555);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 62);
            this.panel3.TabIndex = 6;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lbTotal.Location = new System.Drawing.Point(536, 18);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(100, 25);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "10000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(361, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng Tiền(VND):";
            // 
            // btnPay
            // 
            this.btnPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.btnPay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.btnPay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPay.BorderRadius = 0;
            this.btnPay.BorderSize = 0;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(669, 10);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(150, 40);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "Thu Tiền";
            this.btnPay.TextColor = System.Drawing.Color.White;
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnApplyVoucher);
            this.panel4.Controls.Add(this.rtbVoucherContent);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.tbVoucherCode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 410);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(431, 207);
            this.panel4.TabIndex = 5;
            // 
            // btnApplyVoucher
            // 
            this.btnApplyVoucher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApplyVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(209)))), ((int)(((byte)(55)))));
            this.btnApplyVoucher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(209)))), ((int)(((byte)(55)))));
            this.btnApplyVoucher.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnApplyVoucher.BorderRadius = 0;
            this.btnApplyVoucher.BorderSize = 0;
            this.btnApplyVoucher.FlatAppearance.BorderSize = 0;
            this.btnApplyVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyVoucher.ForeColor = System.Drawing.Color.White;
            this.btnApplyVoucher.Location = new System.Drawing.Point(275, 48);
            this.btnApplyVoucher.Name = "btnApplyVoucher";
            this.btnApplyVoucher.Size = new System.Drawing.Size(150, 40);
            this.btnApplyVoucher.TabIndex = 10;
            this.btnApplyVoucher.Text = "Áp dụng";
            this.btnApplyVoucher.TextColor = System.Drawing.Color.White;
            this.btnApplyVoucher.UseVisualStyleBackColor = false;
            this.btnApplyVoucher.Click += new System.EventHandler(this.btnApplyVoucher_Click);
            // 
            // rtbVoucherContent
            // 
            this.rtbVoucherContent.Location = new System.Drawing.Point(19, 139);
            this.rtbVoucherContent.Name = "rtbVoucherContent";
            this.rtbVoucherContent.Size = new System.Drawing.Size(406, 62);
            this.rtbVoucherContent.TabIndex = 9;
            this.rtbVoucherContent.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.MinimumSize = new System.Drawing.Size(0, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nội dung Voucher:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label7.Location = new System.Drawing.Point(14, 4);
            this.label7.MinimumSize = new System.Drawing.Size(0, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 40);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nhập mã Voucher:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbVoucherCode
            // 
            this.tbVoucherCode.BackColor = System.Drawing.SystemColors.Window;
            this.tbVoucherCode.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbVoucherCode.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbVoucherCode.BorderRadius = 0;
            this.tbVoucherCode.BorderSize = 2;
            this.tbVoucherCode.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbVoucherCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbVoucherCode.Location = new System.Drawing.Point(19, 48);
            this.tbVoucherCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbVoucherCode.Multiline = false;
            this.tbVoucherCode.Name = "tbVoucherCode";
            this.tbVoucherCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbVoucherCode.PasswordChar = false;
            this.tbVoucherCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbVoucherCode.PlaceholderText = "";
            this.tbVoucherCode.Size = new System.Drawing.Size(217, 40);
            this.tbVoucherCode.TabIndex = 7;
            this.tbVoucherCode.Texts = "";
            this.tbVoucherCode.UnderlinedStyle = false;
            // 
            // pnPromotions
            // 
            this.pnPromotions.AutoScroll = true;
            this.pnPromotions.Controls.Add(this.btnStatistics);
            this.pnPromotions.Controls.Add(this.panel4);
            this.pnPromotions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPromotions.Location = new System.Drawing.Point(0, 56);
            this.pnPromotions.Name = "pnPromotions";
            this.pnPromotions.Size = new System.Drawing.Size(431, 617);
            this.pnPromotions.TabIndex = 4;
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
            this.btnStatistics.Size = new System.Drawing.Size(431, 57);
            this.btnStatistics.TabIndex = 6;
            this.btnStatistics.Text = "     Chương trình khuyễn mãi";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistics.UseVisualStyleBackColor = true;
            // 
            // CompletePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnPromotions);
            this.Controls.Add(this.pnHeader);
            this.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "CompletePayment";
            this.Text = "CompletePayment";
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnPromotions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJButton btnCloseDialog;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJButton btnPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_price;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnPromotions;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Label label7;
        private RJCodeAdvance.RJControls.RJTextBox tbVoucherCode;
        private System.Windows.Forms.RichTextBox rtbVoucherContent;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJButton btnApplyVoucher;
    }
}