namespace Final_Project_PBO_1
{
    partial class FirstPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGetStarted = new System.Windows.Forms.Button();
            this.FirstPageExit = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Final_Project_PBO_1.Properties.Resources.tetiren;
            this.pictureBox1.Location = new System.Drawing.Point(157, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.BackColor = System.Drawing.Color.Transparent;
            this.btnGetStarted.BackgroundImage = global::Final_Project_PBO_1.Properties.Resources.getstart;
            this.btnGetStarted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGetStarted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetStarted.FlatAppearance.BorderSize = 0;
            this.btnGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetStarted.ForeColor = System.Drawing.Color.White;
            this.btnGetStarted.Location = new System.Drawing.Point(231, 164);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.Size = new System.Drawing.Size(130, 32);
            this.btnGetStarted.TabIndex = 1;
            this.btnGetStarted.UseVisualStyleBackColor = false;
            this.btnGetStarted.Click += new System.EventHandler(this.button1_Click);
            // 
            // FirstPageExit
            // 
            this.FirstPageExit.AutoSize = true;
            this.FirstPageExit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FirstPageExit.Location = new System.Drawing.Point(281, 259);
            this.FirstPageExit.Name = "FirstPageExit";
            this.FirstPageExit.Size = new System.Drawing.Size(24, 13);
            this.FirstPageExit.TabIndex = 3;
            this.FirstPageExit.TabStop = true;
            this.FirstPageExit.Text = "Exit";
            this.FirstPageExit.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FirstPageExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FirstPageExit_LinkClicked);
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.FirstPageExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGetStarted);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGetStarted;
        private System.Windows.Forms.LinkLabel FirstPageExit;
    }
}

