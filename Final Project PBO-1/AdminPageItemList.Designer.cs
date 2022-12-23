namespace Final_Project_PBO_1
{
    partial class AdminPageItemList
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
            this.dataGridViewItem = new System.Windows.Forms.DataGridView();
            this.HeaderBorrower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderBorrower
            // 
            this.HeaderBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.HeaderBorrower.Controls.Add(this.pictureBox1);
            this.HeaderBorrower.Location = new System.Drawing.Point(0, 0);
            this.HeaderBorrower.Name = "HeaderBorrower";
            this.HeaderBorrower.Size = new System.Drawing.Size(650, 80);
            this.HeaderBorrower.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project_PBO_1.Properties.Resources.itemlistlist1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewItem
            // 
            this.dataGridViewItem.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.dataGridViewItem.Location = new System.Drawing.Point(25, 100);
            this.dataGridViewItem.Name = "dataGridViewItem";
            this.dataGridViewItem.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewItem.TabIndex = 2;
            // 
            // AdminPageItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewItem);
            this.Controls.Add(this.HeaderBorrower);
            this.Name = "AdminPageItemList";
            this.Size = new System.Drawing.Size(650, 500);
            this.HeaderBorrower.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderBorrower;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewItem;
    }
}
