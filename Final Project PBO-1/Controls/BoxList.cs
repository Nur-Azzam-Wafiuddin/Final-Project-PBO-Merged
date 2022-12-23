using Final_Project_PBO_1.Controller;
using Final_Project_PBO_1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_PBO_1
{
    public partial class BoxList : UserControl
    {
        public BoxList()
        {
            InitializeComponent();
        }

        public void LoadThis(object sender , EventArgs e)
        {
            ProductController productController = new ProductController();
            List<Product> productList = productController.GetAllProduct();

            string changeName = productList.Find(y=>y.id==this.TabIndex+1).name.ToString();
            lblGearName.Text = changeName;
            bool changeAvailability = productList.Find(y => y.id == this.TabIndex + 1).isAvailable;
            if (changeAvailability == false)
            {
                lblAvailability.Text = "Unavailable";
                lblAvailability.ForeColor = System.Drawing.Color.OrangeRed;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //masukin ke list
            //ganti warna
        }


    }
}
