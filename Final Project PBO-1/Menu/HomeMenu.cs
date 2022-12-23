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
    public partial class HomeMenu : UserControl
    {
        public HomeMenu()
        {
            InitializeComponent();
        }
        
        public void HomeMenu_Load(object sender, EventArgs e)
        {
            ProductController productController = new ProductController();
            List<Product> productList = productController.GetAllProduct();

            int ItemNum = productList.Count;

            for (int i = 0; i < ItemNum; i++)
            {
                BoxList Container = new Final_Project_PBO_1.BoxList();
                this.panel3.Controls.Add(Container);

                Container.BackColor = System.Drawing.Color.White;
                Container.Location = new System.Drawing.Point(30 + (300 * (i % 4)), 38 + (200 * (i / 4)));
                Container.Margin = new System.Windows.Forms.Padding(3, 1012, 3, 1012);
                Container.Name = "boxList1";
                Container.Size = new System.Drawing.Size(257, 165);
                Container.TabIndex = i;
                Container.Load += new System.EventHandler(this.Container_Load);
            }
        }

        private void Container_Load(object sender, EventArgs e)
        {

        }

        private void HomeMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
