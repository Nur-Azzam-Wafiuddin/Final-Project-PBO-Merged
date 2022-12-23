using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_PBO_1
{
    public partial class AdminHomePageBorrower : Form
    {
        public AdminHomePageBorrower()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //var homepage = new HomePageGabut();
            //this.Hide();
            //homepage.Show();
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {

        }

        private void AdminPageLogout_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var backtologinpage = new LoginPage();

                this.Hide();

                backtologinpage.Show();
            }

            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPageBorrowerList1.Hide();
            adminPageUserList1.Hide();
            adminPageItemList1.Show();

            btnBorrower.BackColor = Color.FromArgb(15, 26, 56);
            btnItem.BackColor = Color.FromArgb(242, 168, 7);
            btnUserList.BackColor = Color.FromArgb(15, 26, 56);
        }

        private void btnBorrower_Click(object sender, EventArgs e)
        {
            adminPageItemList1.Hide();
            adminPageUserList1.Hide();
            AdminPageBorrowerList1.Show();

            btnBorrower.BackColor = Color.FromArgb(242, 168, 7);
            btnItem.BackColor = Color.FromArgb(15, 26, 56);
            btnUserList.BackColor = Color.FromArgb(15, 26, 56);
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            AdminPageBorrowerList1.Hide();
            adminPageItemList1.Hide();
            adminPageUserList1.Show();

            btnBorrower.BackColor = Color.FromArgb(15, 26, 56);
            btnItem.BackColor = Color.FromArgb(15, 26, 56);
            btnUserList.BackColor = Color.FromArgb(242, 168, 7);
        }

        private void adminPageBorrowerList1_Load(object sender, EventArgs e)
        {

        }
    }
}
