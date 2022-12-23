namespace Final_Project_PBO_1
{
    partial class AdminPageUserList
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
            this.components = new System.ComponentModel.Container();
            this.HeaderBorrower = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.accounts = new Final_Project_PBO_1.Accounts();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.IDUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderBorrower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderBorrower
            // 
            this.HeaderBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.HeaderBorrower.Controls.Add(this.pictureBox1);
            this.HeaderBorrower.Location = new System.Drawing.Point(0, 0);
            this.HeaderBorrower.Name = "HeaderBorrower";
            this.HeaderBorrower.Size = new System.Drawing.Size(650, 80);
            this.HeaderBorrower.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project_PBO_1.Properties.Resources.userlist;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDUser,
            this.NameUser,
            this.UsernameUser});
            this.dataGridViewUser.GridColor = System.Drawing.Color.Black;
            this.dataGridViewUser.Location = new System.Drawing.Point(139, 100);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.Size = new System.Drawing.Size(299, 300);
            this.dataGridViewUser.TabIndex = 2;
            this.dataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // accounts
            // 
            this.accounts.DataSetName = "Accounts";
            this.accounts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataSource = this.accounts;
            this.accountsBindingSource.Position = 0;
            // 
            // accountsBindingSource1
            // 
            this.accountsBindingSource1.DataSource = this.accounts;
            this.accountsBindingSource1.Position = 0;
            // 
            // IDUser
            // 
            this.IDUser.HeaderText = "ID";
            this.IDUser.Name = "IDUser";
            this.IDUser.ReadOnly = true;
            this.IDUser.Width = 50;
            // 
            // NameUser
            // 
            this.NameUser.HeaderText = "Name";
            this.NameUser.Name = "NameUser";
            this.NameUser.ReadOnly = true;
            // 
            // UsernameUser
            // 
            this.UsernameUser.HeaderText = "Username";
            this.UsernameUser.Name = "UsernameUser";
            this.UsernameUser.ReadOnly = true;
            // 
            // AdminPageUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.HeaderBorrower);
            this.Name = "AdminPageUserList";
            this.Size = new System.Drawing.Size(650, 500);
            this.HeaderBorrower.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderBorrower;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private Accounts accounts;
        private System.Windows.Forms.BindingSource accountsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameUser;
    }
}
