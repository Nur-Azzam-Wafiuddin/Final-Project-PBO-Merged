namespace Final_Project_PBO_1
{
    partial class SignUpPage
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
            this.txtPasswordSignUp = new System.Windows.Forms.TextBox();
            this.txtEmailSignUpPage = new System.Windows.Forms.Label();
            this.txtPasswordSignUpPage = new System.Windows.Forms.Label();
            this.txtUsernameSignUp = new System.Windows.Forms.MaskedTextBox();
            this.txtNameSignUpPage = new System.Windows.Forms.Label();
            this.txtNameSignUp = new System.Windows.Forms.MaskedTextBox();
            this.txtConfirmPasswordSignUp = new System.Windows.Forms.TextBox();
            this.txtConfirmSignUpPage = new System.Windows.Forms.Label();
            this.ClearDataSignUp = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backSignUpPage = new System.Windows.Forms.PictureBox();
            this.btnHideCPW = new System.Windows.Forms.Button();
            this.btnShowCPW = new System.Windows.Forms.Button();
            this.btnHidePW = new System.Windows.Forms.Button();
            this.btnShowPW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backSignUpPage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPasswordSignUp
            // 
            this.txtPasswordSignUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordSignUp.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignUp.Location = new System.Drawing.Point(189, 174);
            this.txtPasswordSignUp.Name = "txtPasswordSignUp";
            this.txtPasswordSignUp.PasswordChar = '*';
            this.txtPasswordSignUp.Size = new System.Drawing.Size(200, 17);
            this.txtPasswordSignUp.TabIndex = 8;
            this.txtPasswordSignUp.TextChanged += new System.EventHandler(this.txtUsernameSignUp_TextChanged);
            // 
            // txtEmailSignUpPage
            // 
            this.txtEmailSignUpPage.AutoSize = true;
            this.txtEmailSignUpPage.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailSignUpPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmailSignUpPage.Location = new System.Drawing.Point(185, 105);
            this.txtEmailSignUpPage.Name = "txtEmailSignUpPage";
            this.txtEmailSignUpPage.Size = new System.Drawing.Size(65, 19);
            this.txtEmailSignUpPage.TabIndex = 7;
            this.txtEmailSignUpPage.Text = "Username";
            this.txtEmailSignUpPage.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPasswordSignUpPage
            // 
            this.txtPasswordSignUpPage.AutoSize = true;
            this.txtPasswordSignUpPage.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignUpPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPasswordSignUpPage.Location = new System.Drawing.Point(185, 152);
            this.txtPasswordSignUpPage.Name = "txtPasswordSignUpPage";
            this.txtPasswordSignUpPage.Size = new System.Drawing.Size(61, 19);
            this.txtPasswordSignUpPage.TabIndex = 6;
            this.txtPasswordSignUpPage.Text = "Password";
            this.txtPasswordSignUpPage.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsernameSignUp
            // 
            this.txtUsernameSignUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernameSignUp.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameSignUp.Location = new System.Drawing.Point(189, 127);
            this.txtUsernameSignUp.Name = "txtUsernameSignUp";
            this.txtUsernameSignUp.Size = new System.Drawing.Size(200, 17);
            this.txtUsernameSignUp.TabIndex = 5;
            this.txtUsernameSignUp.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtUsername_MaskInputRejected);
            // 
            // txtNameSignUpPage
            // 
            this.txtNameSignUpPage.AutoSize = true;
            this.txtNameSignUpPage.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSignUpPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNameSignUpPage.Location = new System.Drawing.Point(185, 56);
            this.txtNameSignUpPage.Name = "txtNameSignUpPage";
            this.txtNameSignUpPage.Size = new System.Drawing.Size(42, 19);
            this.txtNameSignUpPage.TabIndex = 12;
            this.txtNameSignUpPage.Text = "Name";
            this.txtNameSignUpPage.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNameSignUp
            // 
            this.txtNameSignUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameSignUp.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSignUp.Location = new System.Drawing.Point(189, 80);
            this.txtNameSignUp.Name = "txtNameSignUp";
            this.txtNameSignUp.Size = new System.Drawing.Size(200, 17);
            this.txtNameSignUp.TabIndex = 11;
            this.txtNameSignUp.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtNameSignUp_MaskInputRejected);
            // 
            // txtConfirmPasswordSignUp
            // 
            this.txtConfirmPasswordSignUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPasswordSignUp.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPasswordSignUp.Location = new System.Drawing.Point(189, 221);
            this.txtConfirmPasswordSignUp.Name = "txtConfirmPasswordSignUp";
            this.txtConfirmPasswordSignUp.PasswordChar = '*';
            this.txtConfirmPasswordSignUp.Size = new System.Drawing.Size(200, 17);
            this.txtConfirmPasswordSignUp.TabIndex = 14;
            this.txtConfirmPasswordSignUp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtConfirmSignUpPage
            // 
            this.txtConfirmSignUpPage.AutoSize = true;
            this.txtConfirmSignUpPage.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmSignUpPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmSignUpPage.Location = new System.Drawing.Point(185, 199);
            this.txtConfirmSignUpPage.Name = "txtConfirmSignUpPage";
            this.txtConfirmSignUpPage.Size = new System.Drawing.Size(108, 19);
            this.txtConfirmSignUpPage.TabIndex = 13;
            this.txtConfirmSignUpPage.Text = "Confirm Password";
            // 
            // ClearDataSignUp
            // 
            this.ClearDataSignUp.AutoSize = true;
            this.ClearDataSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.ClearDataSignUp.Location = new System.Drawing.Point(196, 257);
            this.ClearDataSignUp.Name = "ClearDataSignUp";
            this.ClearDataSignUp.Size = new System.Drawing.Size(31, 13);
            this.ClearDataSignUp.TabIndex = 17;
            this.ClearDataSignUp.TabStop = true;
            this.ClearDataSignUp.Text = "Clear";
            this.ClearDataSignUp.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.ClearDataSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClearDataSignUp_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Poppins ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.label6.Location = new System.Drawing.Point(244, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 37);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sign Up";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel1.Location = new System.Drawing.Point(189, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel2.Location = new System.Drawing.Point(189, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel3.Location = new System.Drawing.Point(189, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel4.Location = new System.Drawing.Point(189, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 2);
            this.panel4.TabIndex = 22;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(306, 252);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(83, 27);
            this.btnSignUp.TabIndex = 23;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Final_Project_PBO_1.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(552, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // backSignUpPage
            // 
            this.backSignUpPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backSignUpPage.Image = global::Final_Project_PBO_1.Properties.Resources.back;
            this.backSignUpPage.Location = new System.Drawing.Point(12, 12);
            this.backSignUpPage.Name = "backSignUpPage";
            this.backSignUpPage.Size = new System.Drawing.Size(39, 17);
            this.backSignUpPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backSignUpPage.TabIndex = 24;
            this.backSignUpPage.TabStop = false;
            this.backSignUpPage.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnHideCPW
            // 
            this.btnHideCPW.BackgroundImage = global::Final_Project_PBO_1.Properties.Resources.see;
            this.btnHideCPW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHideCPW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHideCPW.FlatAppearance.BorderSize = 0;
            this.btnHideCPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideCPW.Location = new System.Drawing.Point(373, 218);
            this.btnHideCPW.Name = "btnHideCPW";
            this.btnHideCPW.Size = new System.Drawing.Size(16, 20);
            this.btnHideCPW.TabIndex = 27;
            this.btnHideCPW.UseVisualStyleBackColor = true;
            this.btnHideCPW.Visible = false;
            this.btnHideCPW.Click += new System.EventHandler(this.btnHidePW_Click);
            // 
            // btnShowCPW
            // 
            this.btnShowCPW.BackgroundImage = global::Final_Project_PBO_1.Properties.Resources.hide;
            this.btnShowCPW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowCPW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowCPW.FlatAppearance.BorderSize = 0;
            this.btnShowCPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCPW.Location = new System.Drawing.Point(373, 218);
            this.btnShowCPW.Name = "btnShowCPW";
            this.btnShowCPW.Size = new System.Drawing.Size(16, 20);
            this.btnShowCPW.TabIndex = 26;
            this.btnShowCPW.UseVisualStyleBackColor = true;
            this.btnShowCPW.Visible = false;
            this.btnShowCPW.Click += new System.EventHandler(this.btnShowPW_Click);
            // 
            // btnHidePW
            // 
            this.btnHidePW.BackgroundImage = global::Final_Project_PBO_1.Properties.Resources.see;
            this.btnHidePW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHidePW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHidePW.FlatAppearance.BorderSize = 0;
            this.btnHidePW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePW.Location = new System.Drawing.Point(373, 166);
            this.btnHidePW.Name = "btnHidePW";
            this.btnHidePW.Size = new System.Drawing.Size(16, 20);
            this.btnHidePW.TabIndex = 29;
            this.btnHidePW.UseVisualStyleBackColor = true;
            this.btnHidePW.Visible = false;
            this.btnHidePW.Click += new System.EventHandler(this.btnHidePW_Click_1);
            // 
            // btnShowPW
            // 
            this.btnShowPW.BackgroundImage = global::Final_Project_PBO_1.Properties.Resources.hide;
            this.btnShowPW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPW.FlatAppearance.BorderSize = 0;
            this.btnShowPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPW.Location = new System.Drawing.Point(373, 166);
            this.btnShowPW.Name = "btnShowPW";
            this.btnShowPW.Size = new System.Drawing.Size(16, 20);
            this.btnShowPW.TabIndex = 28;
            this.btnShowPW.UseVisualStyleBackColor = true;
            this.btnShowPW.Visible = false;
            this.btnShowPW.Click += new System.EventHandler(this.btnShowPW_Click_1);
            // 
            // SignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.btnHidePW);
            this.Controls.Add(this.btnShowPW);
            this.Controls.Add(this.btnHideCPW);
            this.Controls.Add(this.btnShowCPW);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backSignUpPage);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClearDataSignUp);
            this.Controls.Add(this.txtConfirmPasswordSignUp);
            this.Controls.Add(this.txtConfirmSignUpPage);
            this.Controls.Add(this.txtNameSignUpPage);
            this.Controls.Add(this.txtNameSignUp);
            this.Controls.Add(this.txtPasswordSignUp);
            this.Controls.Add(this.txtEmailSignUpPage);
            this.Controls.Add(this.txtPasswordSignUpPage);
            this.Controls.Add(this.txtUsernameSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backSignUpPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPasswordSignUp;
        private System.Windows.Forms.Label txtEmailSignUpPage;
        private System.Windows.Forms.Label txtPasswordSignUpPage;
        private System.Windows.Forms.MaskedTextBox txtUsernameSignUp;
        private System.Windows.Forms.Label txtNameSignUpPage;
        private System.Windows.Forms.MaskedTextBox txtNameSignUp;
        private System.Windows.Forms.TextBox txtConfirmPasswordSignUp;
        private System.Windows.Forms.Label txtConfirmSignUpPage;
        private System.Windows.Forms.LinkLabel ClearDataSignUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox backSignUpPage;
        private System.Windows.Forms.Button btnHideCPW;
        private System.Windows.Forms.Button btnShowCPW;
        private System.Windows.Forms.Button btnHidePW;
        private System.Windows.Forms.Button btnShowPW;
    }
}