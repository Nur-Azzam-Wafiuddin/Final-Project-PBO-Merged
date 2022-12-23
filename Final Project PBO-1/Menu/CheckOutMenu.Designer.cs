namespace Final_Project_PBO_1
{
    partial class CheckOutMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labeltumbal = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.labeltumbal);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1249, 121);
            this.panel7.TabIndex = 7;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins ExtraBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 57);
            this.label2.TabIndex = 5;
            this.label2.Text = "Check Out";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnBook);
            this.panel3.Controls.Add(this.dateTimePicker);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1249, 583);
            this.panel3.TabIndex = 9;
            this.panel3.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 583);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 0);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(910, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 47);
            this.label5.TabIndex = 11;
            this.label5.Text = "Book Now";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBook
            // 
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Image = global::Final_Project_PBO_1.Properties.Resources.square_plus;
            this.btnBook.Location = new System.Drawing.Point(1056, 32);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(81, 79);
            this.btnBook.TabIndex = 10;
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "ddd, dd MMM yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(98, 82);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 47);
            this.label4.TabIndex = 8;
            this.label4.Text = "Booking Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 47);
            this.label3.TabIndex = 7;
            this.label3.Text = "Summary of Your Book:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labeltumbal
            // 
            this.labeltumbal.AutoSize = true;
            this.labeltumbal.Location = new System.Drawing.Point(480, 52);
            this.labeltumbal.Name = "labeltumbal";
            this.labeltumbal.Size = new System.Drawing.Size(0, 13);
            this.labeltumbal.TabIndex = 6;
            this.labeltumbal.Visible = false;
            // 
            // CheckOutMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Name = "CheckOutMenu";
            this.Size = new System.Drawing.Size(1249, 704);
            this.Load += new System.EventHandler(this.CheckOutMenu_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeltumbal;
    }
}
