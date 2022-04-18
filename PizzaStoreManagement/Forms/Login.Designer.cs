namespace PizzaStoreManagement.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnSIdeMenu = new System.Windows.Forms.Panel();
            this.pnSideMenuContents = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLogin = new RJCodeAdvance.RJControls.RJButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbPassword = new CustomBox.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbUsername = new CustomBox.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnSideMenuManage = new System.Windows.Forms.Panel();
            this.pnSideMenuHeader = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnSIdeMenu.SuspendLayout();
            this.pnSideMenuContents.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnSideMenuHeader.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnSIdeMenu.TabIndex = 2;
            // 
            // pnSideMenuContents
            // 
            this.pnSideMenuContents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.pnSideMenuContents.Controls.Add(this.panel6);
            this.pnSideMenuContents.Controls.Add(this.panel5);
            this.pnSideMenuContents.Controls.Add(this.panel3);
            this.pnSideMenuContents.Controls.Add(this.pnSideMenuManage);
            this.pnSideMenuContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSideMenuContents.Location = new System.Drawing.Point(0, 330);
            this.pnSideMenuContents.Name = "pnSideMenuContents";
            this.pnSideMenuContents.Size = new System.Drawing.Size(249, 296);
            this.pnSideMenuContents.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnLogin);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 154);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(249, 142);
            this.panel6.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(51, 61);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbPassword);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(249, 77);
            this.panel5.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Window;
            this.tbPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.tbPassword.BorderRadius = 0;
            this.tbPassword.BorderSize = 2;
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassword.Location = new System.Drawing.Point(0, 30);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbPassword.PasswordChar = false;
            this.tbPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPassword.PlaceholderText = "";
            this.tbPassword.Size = new System.Drawing.Size(249, 40);
            this.tbPassword.TabIndex = 12;
            this.tbPassword.Texts = "";
            this.tbPassword.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.MinimumSize = new System.Drawing.Size(249, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbUsername);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 77);
            this.panel3.TabIndex = 4;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.Window;
            this.tbUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.tbUsername.BorderRadius = 0;
            this.tbUsername.BorderSize = 2;
            this.tbUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUsername.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsername.Location = new System.Drawing.Point(0, 30);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsername.Multiline = false;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbUsername.PasswordChar = false;
            this.tbUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbUsername.PlaceholderText = "";
            this.tbUsername.Size = new System.Drawing.Size(249, 40);
            this.tbUsername.TabIndex = 12;
            this.tbUsername.Texts = "";
            this.tbUsername.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.MinimumSize = new System.Drawing.Size(249, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnSideMenuManage
            // 
            this.pnSideMenuManage.AutoSize = true;
            this.pnSideMenuManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSideMenuManage.Location = new System.Drawing.Point(0, 0);
            this.pnSideMenuManage.Name = "pnSideMenuManage";
            this.pnSideMenuManage.Size = new System.Drawing.Size(249, 0);
            this.pnSideMenuManage.TabIndex = 3;
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
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 273);
            this.panel4.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 57);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 57);
            this.panel2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.MinimumSize = new System.Drawing.Size(249, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 57);
            this.label5.TabIndex = 8;
            this.label5.Text = "LOGIN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 626);
            this.Controls.Add(this.pnSIdeMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.pnSIdeMenu.ResumeLayout(false);
            this.pnSideMenuContents.ResumeLayout(false);
            this.pnSideMenuContents.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnSideMenuHeader.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSIdeMenu;
        private System.Windows.Forms.Panel pnSideMenuContents;
        private System.Windows.Forms.Panel pnSideMenuManage;
        private System.Windows.Forms.Panel pnSideMenuHeader;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private CustomBox.RJControls.RJTextBox tbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private CustomBox.RJControls.RJTextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private RJCodeAdvance.RJControls.RJButton btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}