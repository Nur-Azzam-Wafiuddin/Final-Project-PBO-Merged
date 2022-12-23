namespace Final_Project_PBO_1
{
    partial class AdminHomePageBorrower
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUserList = new System.Windows.Forms.Button();
            this.AdminPageLogout = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrower = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.AdminPageBorrowerList1 = new Final_Project_PBO_1.AdminPageBorrowerList();
            this.adminPageUserList1 = new Final_Project_PBO_1.AdminPageUserList();
            this.adminPageItemList1 = new Final_Project_PBO_1.AdminPageItemList();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.btnUserList);
            this.panel1.Controls.Add(this.AdminPageLogout);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnBorrower);
            this.panel1.Controls.Add(this.btnItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 500);
            this.panel1.TabIndex = 0;
            // 
            // btnUserList
            // 
            this.btnUserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.btnUserList.BackgroundImage = global::Final_Project_PBO_1.Properties.Resources.userlist;
            this.btnUserList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUserList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserList.FlatAppearance.BorderSize = 0;
            this.btnUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserList.Location = new System.Drawing.Point(0, 200);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(150, 60);
            this.btnUserList.TabIndex = 7;
            this.btnUserList.UseVisualStyleBackColor = false;
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // AdminPageLogout
            // 
            this.AdminPageLogout.AutoSize = true;
            this.AdminPageLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminPageLogout.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.AdminPageLogout.ForeColor = System.Drawing.Color.White;
            this.AdminPageLogout.Location = new System.Drawing.Point(42, 459);
            this.AdminPageLogout.Name = "AdminPageLogout";
            this.AdminPageLogout.Size = new System.Drawing.Size(51, 19);
            this.AdminPageLogout.TabIndex = 3;
            this.AdminPageLogout.Text = "Log Out";
            this.AdminPageLogout.Click += new System.EventHandler(this.AdminPageLogout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(76, 697);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Log Out";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 80);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 7.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project_PBO_1.Properties.Resources.tetiren;
            this.pictureBox1.Location = new System.Drawing.Point(19, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnBorrower
            // 
            this.btnBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(168)))), ((int)(((byte)(7)))));
            this.btnBorrower.BackgroundImage = global::Final_Project_PBO_1.Properties.Resources.borrowerist1;
            this.btnBorrower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrower.FlatAppearance.BorderSize = 0;
            this.btnBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrower.Location = new System.Drawing.Point(0, 80);
            this.btnBorrower.Name = "btnBorrower";
            this.btnBorrower.Size = new System.Drawing.Size(150, 60);
            this.btnBorrower.TabIndex = 5;
            this.btnBorrower.UseVisualStyleBackColor = false;
            this.btnBorrower.Click += new System.EventHandler(this.btnBorrower_Click);
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.btnItem.BackgroundImage = global::Final_Project_PBO_1.Properties.Resources.itemlistlist1;
            this.btnItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItem.FlatAppearance.BorderSize = 0;
            this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItem.Location = new System.Drawing.Point(0, 140);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(150, 60);
            this.btnItem.TabIndex = 6;
            this.btnItem.UseVisualStyleBackColor = false;
            this.btnItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Final_Project_PBO_1.Properties.Resources.x;
            this.pictureBox4.Location = new System.Drawing.Point(768, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 17);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // AdminPageBorrowerList1
            // 
            this.AdminPageBorrowerList1.BackColor = System.Drawing.Color.White;
            this.AdminPageBorrowerList1.Location = new System.Drawing.Point(150, 0);
            this.AdminPageBorrowerList1.Name = "AdminPageBorrowerList1";
            this.AdminPageBorrowerList1.Size = new System.Drawing.Size(650, 500);
            this.AdminPageBorrowerList1.TabIndex = 14;
            this.AdminPageBorrowerList1.Load += new System.EventHandler(this.adminPageBorrowerList1_Load);
            // 
            // adminPageUserList1
            // 
            this.adminPageUserList1.BackColor = System.Drawing.Color.White;
            this.adminPageUserList1.Location = new System.Drawing.Point(150, 0);
            this.adminPageUserList1.Name = "adminPageUserList1";
            this.adminPageUserList1.Size = new System.Drawing.Size(650, 500);
            this.adminPageUserList1.TabIndex = 16;
            // 
            // adminPageItemList1
            // 
            this.adminPageItemList1.BackColor = System.Drawing.Color.White;
            this.adminPageItemList1.Location = new System.Drawing.Point(150, 0);
            this.adminPageItemList1.Name = "adminPageItemList1";
            this.adminPageItemList1.Size = new System.Drawing.Size(650, 500);
            this.adminPageItemList1.TabIndex = 15;
            // 
            // AdminHomePageBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminPageBorrowerList1);
            this.Controls.Add(this.adminPageUserList1);
            this.Controls.Add(this.adminPageItemList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminHomePageBorrower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHomePage";
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AdminPageLogout;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnBorrower;
        private System.Windows.Forms.Button btnUserList;
        private AdminPageBorrowerList AdminPageBorrowerList1;
        private AdminPageItemList adminPageItemList1;
        private AdminPageUserList adminPageUserList1;
    }
}