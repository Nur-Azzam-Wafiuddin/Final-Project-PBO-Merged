namespace Final_Project_PBO_1
{
    partial class CheckOut
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGearName
            // 
            this.lblGearName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGearName.Font = new System.Drawing.Font("Poppins", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGearName.Location = new System.Drawing.Point(0, 0);
            this.lblGearName.Name = "lblGearName";
            this.lblGearName.Size = new System.Drawing.Size(412, 45);
            this.lblGearName.TabIndex = 11;
            this.lblGearName.Text = "GearName";
            this.lblGearName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = global::Final_Project_PBO_1.Properties.Resources.cross_circle__1_;
            this.btnRemove.Location = new System.Drawing.Point(531, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(65, 45);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGearName);
            this.Controls.Add(this.btnRemove);
            this.Name = "CheckOut";
            this.Load += new System.EventHandler(this.LoadThis);
            this.Size = new System.Drawing.Size(596, 45);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblGearName;
    }
}
