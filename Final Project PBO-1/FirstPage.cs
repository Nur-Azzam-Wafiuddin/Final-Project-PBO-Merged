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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountController accountController = new AccountController();
            List<Account> accoutList = accountController.GetAllAccount();

            ProductController productController = new ProductController();

            var initAdmin = accoutList.Find(x => x.id == 1);

            if(initAdmin == null)
            {
                accountController.PostAccount("admin", "admin", "admin");
            }

            var loginpage = new LoginPage();

            this.Hide();

            loginpage.Show();
        }

        private void FirstPageExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
