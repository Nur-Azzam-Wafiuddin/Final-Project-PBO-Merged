using Final_Project_PBO_1.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_PBO_1.Model;

namespace Final_Project_PBO_1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          /*  ProductController productController = new ProductController();
            List<Product> productList = productController.GetAllProduct();
            for (int i = 0; i < 3; i++)
            {
                productController.PostProduct("Kamera", "kategorikamera", true);
                productController.PostProduct("Kamerade", "sadkategorikamera", true);
                productController.PostProduct("Kamerade", "sadkategorikamera", false);
                productController.PostProduct("akuKamerade", "sadkategorikameradas", true);
            }*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FirstPage());
        }
    }
}
