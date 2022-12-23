namespace Final_Project_PBO_1
{
    partial class LoginPage
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
            this.txtUsernameSignIn = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordSignIn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ClearDataSignIn = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowPW = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnHidePW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsernameSignIn
            // 
            this.txtUsernameSignIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernameSignIn.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameSignIn.Location = new System.Drawing.Point(181, 104);
            this.txtUsernameSignIn.Name = "txtUsernameSignIn";
            this.txtUsernameSignIn.Size = new System.Drawing.Size(200, 17);
            this.txtUsernameSignIn.TabIndex = 0;
            this.txtUsernameSignIn.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtUsername_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(177, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(177, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username/Email";
            // 
            // txtPasswordSignIn
            // 
            this.txtPasswordSignIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordSignIn.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignIn.Location = new System.Drawing.Point(181, 151);
            this.txtPasswordSignIn.Name = "txtPasswordSignIn";
            this.txtPasswordSignIn.PasswordChar = '*';
            this.txtPasswordSignIn.Size = new System.Drawing.Size(200, 17);
            this.txtPasswordSignIn.TabIndex = 3;
            this.txtPasswordSignIn.TextChanged += new System.EventHandler(this.txtPasswordSignIn_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(300, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 7.25F);
            this.label3.Location = new System.Drawing.Point(195, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Don\'t Have an Account?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Poppins", 7.25F);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.linkLabel1.Location = new System.Drawing.Point(317, 232);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(46, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Up";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ClearDataSignIn
            // 
            this.ClearDataSignIn.AutoSize = true;
            this.ClearDataSignIn.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearDataSignIn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.ClearDataSignIn.Location = new System.Drawing.Point(177, 183);
            this.ClearDataSignIn.Name = "ClearDataSignIn";
            this.ClearDataSignIn.Size = new System.Drawing.Size(38, 19);
            this.ClearDataSignIn.TabIndex = 8;
            this.ClearDataSignIn.TabStop = true;
            this.ClearDataSignIn.Text = "Clear";
            this.ClearDataSignIn.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.ClearDataSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel1.Location = new System.Drawing.Point(181, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Poppins ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.label4.Location = new System.Drawing.Point(244, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Log In";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel2.Location = new System.Drawing.Point(181, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 10;
            // 
            // btnShowPW
            // 
            this.btnShowPW.BackgroundImage = global::Final_Project_PBO_1.Properties.Resources.hide;
            this.btnShowPW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPW.FlatAppearance.BorderSize = 0;
            this.btnShowPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPW.Location = new System.Drawing.Point(365, 148);
            this.btnShowPW.Name = "btnShowPW";
            this.btnShowPW.Size = new System.Drawing.Size(16, 20);
            this.btnShowPW.TabIndex = 13;
            this.btnShowPW.UseVisualStyleBackColor = true;
            this.btnShowPW.Visible = false;
            this.btnShowPW.Click += new System.EventHandler(this.ShowPW_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Final_Project_PBO_1.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(552, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Final_Project_PBO_1.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnHidePW
            // 
            this.btnHidePW.BackgroundImage = global::Final_Project_PBO_1.Properties.Resources.see;
            this.btnHidePW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHidePW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHidePW.FlatAppearance.BorderSize = 0;
            this.btnHidePW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePW.Location = new System.Drawing.Point(365, 148);
            this.btnHidePW.Name = "btnHidePW";
            this.btnHidePW.Size = new System.Drawing.Size(16, 20);
            this.btnHidePW.TabIndex = 14;
            this.btnHidePW.UseVisualStyleBackColor = true;
            this.btnHidePW.Visible = false;
            this.btnHidePW.Click += new System.EventHandler(this.btnHidePW_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.btnHidePW);
            this.Controls.Add(this.btnShowPW);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClearDataSignIn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPasswordSignIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsernameSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtUsernameSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordSignIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel ClearDataSignIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShowPW;
        private System.Windows.Forms.Button btnHidePW;
    }
}