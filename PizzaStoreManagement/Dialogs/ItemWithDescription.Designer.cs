namespace PizzaStoreManagement.Dialogs
{
    partial class ItemWithDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemWithDescription));
            this.lbHeader = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseDialog = new RJCodeAdvance.RJControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new RJCodeAdvance.RJControls.RJButton();
            this.btnConfirm = new RJCodeAdvance.RJControls.RJButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbTitle = new RJCodeAdvance.RJControls.RJTextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.pnHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.MinimumSize = new System.Drawing.Size(715, 56);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(715, 56);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Thông Tin Item";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbHeader_MouseDown);
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.pnHeader.Controls.Add(this.panel1);
            this.pnHeader.Controls.Add(this.lbHeader);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(658, 56);
            this.pnHeader.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseDialog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(599, 0);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 52);
            this.panel2.TabIndex = 14;
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
            this.btnConfirm.Location = new System.Drawing.Point(533, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(125, 52);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Xác Nhận";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lbTitle.Location = new System.Drawing.Point(21, 86);
            this.lbTitle.MinimumSize = new System.Drawing.Size(0, 40);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(79, 40);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "Tiêu đề";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.Window;
            this.tbTitle.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbTitle.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbTitle.BorderRadius = 0;
            this.tbTitle.BorderSize = 2;
            this.tbTitle.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTitle.Location = new System.Drawing.Point(123, 86);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbTitle.Multiline = false;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbTitle.PasswordChar = false;
            this.tbTitle.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbTitle.PlaceholderText = "";
            this.tbTitle.Size = new System.Drawing.Size(429, 40);
            this.tbTitle.TabIndex = 12;
            this.tbTitle.Texts = "";
            this.tbTitle.UnderlinedStyle = false;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(123, 165);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(429, 123);
            this.rtbDescription.TabIndex = 15;
            this.rtbDescription.Text = "";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lbDescription.Location = new System.Drawing.Point(21, 165);
            this.lbDescription.MinimumSize = new System.Drawing.Size(0, 40);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(64, 40);
            this.lbDescription.TabIndex = 16;
            this.lbDescription.Text = "Mô tả";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemWithDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(658, 392);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tbTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ItemWithDescription";
            this.Text = "ItemWithDescription";
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJButton btnCloseDialog;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton btnClose;
        private RJCodeAdvance.RJControls.RJButton btnConfirm;
        private System.Windows.Forms.Label lbTitle;
        private RJCodeAdvance.RJControls.RJTextBox tbTitle;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lbDescription;
    }
}