using Final_Project_PBO_1.Controller;
using Final_Project_PBO_1.Model;
using Final_Project_PBO_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartTemp;

namespace Final_Project_PBO_1
{
    public partial class BoxList : UserControl
    {
        public BoxList()
        {
            InitializeComponent();
        }

        public void LoadThis(object sender, EventArgs e)
        {
            ProductController productController = new ProductController();

            if (productController.GetProductById(this.TabIndex + 1).name != null)
            {
                string changeName = productController.GetProductById(this.TabIndex + 1).name;
                lblGearName.Text = changeName;
                bool changeAvailability = productController.GetProductById(this.TabIndex + 1).isAvailable;
                if (changeAvailability == false)
                {
                    lblAvailability.Text = "Unavailable";
                    lblAvailability.ForeColor = System.Drawing.Color.OrangeRed;
                }
            }
            else
            {
                lblGearName.Text = "Object not Found";
                lblGearName.ForeColor = System.Drawing.Color.OrangeRed;
                lblAvailability.Text = "Unavailable";
                lblAvailability.ForeColor = System.Drawing.Color.OrangeRed;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProductController productController = new ProductController();
            string Name = productController.GetProductById(this.TabIndex + 1).name;
            Cart.add(Name);
        }
    }
}