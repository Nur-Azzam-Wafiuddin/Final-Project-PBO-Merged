namespace Final_Project_PBO_1
{
    partial class AdminPageBorrowerList
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
            this.HeaderBorrower = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewBorrower = new System.Windows.Forms.DataGridView();
            this.BorrowerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowerUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsToBorrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptBorrow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RejectBorrow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HeaderBorrower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrower)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderBorrower
            // 
            this.HeaderBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.HeaderBorrower.Controls.Add(this.pictureBox1);
            this.HeaderBorrower.Location = new System.Drawing.Point(0, 0);
            this.HeaderBorrower.Name = "HeaderBorrower";
            this.HeaderBorrower.Size = new System.Drawing.Size(650, 80);
            this.HeaderBorrower.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project_PBO_1.Properties.Resources.borrowerist1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewBorrower
            // 
            this.dataGridViewBorrower.AllowUserToDeleteRows = false;
            this.dataGridViewBorrower.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBorrower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrower.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BorrowerName,
            this.BorrowerUsername,
            this.ItemsToBorrow,
            this.AcceptBorrow,
            this.RejectBorrow});
            this.dataGridViewBorrower.Location = new System.Drawing.Point(12, 86);
            this.dataGridViewBorrower.Name = "dataGridViewBorrower";
            this.dataGridViewBorrower.ReadOnly = true;
            this.dataGridViewBorrower.Size = new System.Drawing.Size(625, 150);
            this.dataGridViewBorrower.TabIndex = 1;
            this.dataGridViewBorrower.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // BorrowerName
            // 
            this.BorrowerName.HeaderText = "Borrower Name";
            this.BorrowerName.Name = "BorrowerName";
            this.BorrowerName.ReadOnly = true;
            this.BorrowerName.Width = 150;
            // 
            // BorrowerUsername
            // 
            this.BorrowerUsername.HeaderText = "Username";
            this.BorrowerUsername.Name = "BorrowerUsername";
            this.BorrowerUsername.ReadOnly = true;
            // 
            // ItemsToBorrow
            // 
            this.ItemsToBorrow.HeaderText = "Items to Borrow";
            this.ItemsToBorrow.Name = "ItemsToBorrow";
            this.ItemsToBorrow.ReadOnly = true;
            this.ItemsToBorrow.Width = 230;
            // 
            // AcceptBorrow
            // 
            this.AcceptBorrow.HeaderText = "Accept";
            this.AcceptBorrow.Name = "AcceptBorrow";
            this.AcceptBorrow.ReadOnly = true;
            this.AcceptBorrow.Width = 50;
            // 
            // RejectBorrow
            // 
            this.RejectBorrow.HeaderText = "Reject";
            this.RejectBorrow.Name = "RejectBorrow";
            this.RejectBorrow.ReadOnly = true;
            this.RejectBorrow.Width = 50;
            // 
            // AdminPageBorrowerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewBorrower);
            this.Controls.Add(this.HeaderBorrower);
            this.Name = "AdminPageBorrowerList";
            this.Size = new System.Drawing.Size(650, 500);
            this.Load += new System.EventHandler(this.AdminPageBorrowerList_Load);
            this.HeaderBorrower.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HeaderBorrower;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewBorrower;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowerUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsToBorrow;
        private System.Windows.Forms.DataGridViewButtonColumn AcceptBorrow;
        private System.Windows.Forms.DataGridViewButtonColumn RejectBorrow;
    }
}
