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
    public partial class AdminPageItemList : UserControl
    {
        public AdminPageItemList()
        {
            InitializeComponent();
            ProductController productController = new ProductController();
            List<Product> productList = productController.GetAllProduct();
            foreach (Product product in productList)
            {
                dataGridViewItem.Rows.Add(product.name.ToString(), product.isAvailable);
            }
        }

        public class DataRow
        {
            public string Nama { get; set; }
            public string Alamat { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if(textBoxAddItem.Text.Length > 0 )
            {
                ProductController productController = new ProductController();
                productController.PostProduct(textBoxAddItem.Text, true);
                dataGridViewItem.Rows.Add(textBoxAddItem.Text, true);
            }
        }
    }
}
