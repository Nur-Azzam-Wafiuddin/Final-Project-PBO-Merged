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
using Final_Project_PBO_1.Controller;
using Final_Project_PBO_1.Model;

namespace Final_Project_PBO_1
{
    public partial class MainForm : Form
    {
        HomeMenu menuHome = new Final_Project_PBO_1.HomeMenu();
        CheckOutMenu menuCheckOut = new Final_Project_PBO_1.CheckOutMenu(temp);
        private static string temp; 
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(string user)
        {
            InitializeComponent();
            this.label1.Text = user;
            temp = user;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            AccountController accountController = new AccountController();
            List<Account> accoutList = accountController.GetAllAccount();
            Account FoundUser = accoutList.Find(x => x.username == this.label1.Text);
            this.label1.Text = FoundUser.username;
            btnHome_Click(sender, e);
        }

        private void showPanel(Control add, Control remove)
        {
            panel3.Controls.Remove(remove);
            panel3.Controls.Add(add);

            add.Location = new System.Drawing.Point(0, 0);
            add.Size = new System.Drawing.Size(1249, 704);
            add.TabIndex = 0;
        }
        private void changeMenu(Control add, Control remove)
        {
            remove.BackColor = Color.FromArgb(15, 26, 56);
            add.BackColor = Color.FromArgb(242, 168, 7);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            changeMenu(btnHome, btnCO);
            showPanel(menuHome, menuCheckOut);

            menuHome.HomeMenu_Load(sender, e);
        }

        private void btnCO_Click(object sender, EventArgs e)
        {
            changeMenu(btnCO, btnHome);
            showPanel(menuCheckOut, menuHome);

            menuCheckOut.CheckOutMenu_Load(sender, e);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var backtologinpage = new LoginPage();

                this.Hide();

                backtologinpage.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
