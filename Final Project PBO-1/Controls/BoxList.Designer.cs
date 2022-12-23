namespace Final_Project_PBO_1
{
    partial class BoxList
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
            this.lblGearName = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGearName
            // 
            this.lblGearName.BackColor = System.Drawing.Color.Transparent;
            this.lblGearName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGearName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGearName.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGearName.Location = new System.Drawing.Point(0, 0);
            this.lblGearName.Margin = new System.Windows.Forms.Padding(0);
            this.lblGearName.Name = "lblGearName";
            this.lblGearName.Size = new System.Drawing.Size(259, 62);
            this.lblGearName.TabIndex = 0;
            this.lblGearName.Text = "GearName";
            this.lblGearName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvailability
            // 
            this.lblAvailability.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailability.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAvailability.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblAvailability.Location = new System.Drawing.Point(0, 62);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(259, 28);
            this.lblAvailability.TabIndex = 2;
            this.lblAvailability.Text = "Available";
            this.lblAvailability.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Final_Project_PBO_1.Properties.Resources.Asset_11;
            this.button1.Location = new System.Drawing.Point(0, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 47);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BoxList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.lblGearName);
            this.Name = "BoxList";
            this.Size = new System.Drawing.Size(259, 151);
            this.Load += new System.EventHandler(this.LoadThis);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGearName;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Button button1;
    }
}
