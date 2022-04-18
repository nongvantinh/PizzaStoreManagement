namespace PizzaStoreManagement.Controls
{
    partial class BuildingFloor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildingFloor));
            this.label = new System.Windows.Forms.Label();
            this.pbFloor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.label.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label.Location = new System.Drawing.Point(45, 99);
            this.label.MinimumSize = new System.Drawing.Size(56, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 31);
            this.label.TabIndex = 5;
            this.label.Text = "1";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFloor
            // 
            this.pbFloor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFloor.Image = ((System.Drawing.Image)(resources.GetObject("pbFloor.Image")));
            this.pbFloor.Location = new System.Drawing.Point(8, 21);
            this.pbFloor.Name = "pbFloor";
            this.pbFloor.Size = new System.Drawing.Size(135, 75);
            this.pbFloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFloor.TabIndex = 4;
            this.pbFloor.TabStop = false;
            this.pbFloor.Click += new System.EventHandler(this.pbFloor_Click);
            // 
            // BuildingFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.Controls.Add(this.label);
            this.Controls.Add(this.pbFloor);
            this.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "BuildingFloor";
            ((System.ComponentModel.ISupportInitialize)(this.pbFloor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pbFloor;
    }
}
