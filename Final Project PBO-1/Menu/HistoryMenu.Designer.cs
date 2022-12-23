namespace Final_Project_PBO_1
{
    partial class HistoryMenu
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labeltumbal1 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.labeltumbal1);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(937, 98);
            this.panel7.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins ExtraBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "History";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Poppins", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(937, 474);
            this.panel3.TabIndex = 9;
            // 
            // labeltumbal1
            // 
            this.labeltumbal1.AutoSize = true;
            this.labeltumbal1.Location = new System.Drawing.Point(423, 31);
            this.labeltumbal1.Name = "labeltumbal1";
            this.labeltumbal1.Size = new System.Drawing.Size(35, 13);
            this.labeltumbal1.TabIndex = 6;
            this.labeltumbal1.Text = "label1";
            this.labeltumbal1.Visible = false;
            this.labeltumbal1.Click += new System.EventHandler(this.labeltumbal1_Click);
            // 
            // HistoryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HistoryMenu";
            this.Size = new System.Drawing.Size(937, 572);
            this.Load += new System.EventHandler(this.HistoryMenu_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labeltumbal1;
    }
}
