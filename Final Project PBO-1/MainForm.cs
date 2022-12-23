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
    public partial class MainForm : Form
    {
        HistoryMenu menuHistory = new Final_Project_PBO_1.HistoryMenu();
        HomeMenu menuHome = new Final_Project_PBO_1.HomeMenu();
        CheckOutMenu menuCheckOut = new Final_Project_PBO_1.CheckOutMenu();

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            btnHome_Click(sender, e);
        }

        private void showPanel(Control add, Control remove1, Control remove2)
        {
            panel3.Controls.Remove(remove1);
            panel3.Controls.Remove(remove2);
            panel3.Controls.Add(add);

            add.Location = new System.Drawing.Point(0, 0);
            add.Size = new System.Drawing.Size(1249, 704);
            add.TabIndex = 0;
        }
        private void changeMenu(Control add, Control remove1, Control remove2)
        {
            remove2.BackColor = Color.FromArgb(15, 26, 56);
            remove1.BackColor = Color.FromArgb(15, 26, 56);
            add.BackColor = Color.FromArgb(242, 168, 7);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            changeMenu(btnHome, btnCO, btnHistory);
            showPanel(menuHome, menuCheckOut, menuHistory);

            menuHome.HomeMenu_Load(sender,e);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            changeMenu(btnHistory, btnHome, btnCO);
            showPanel(menuHistory, menuHome, menuCheckOut);

            menuHistory.HistoryMenu_Load(sender,e);
        }

        private void btnCO_Click(object sender, EventArgs e)
        {
            changeMenu(btnCO, btnHistory, btnHome);
            showPanel(menuCheckOut, menuHistory, menuHome);

            menuCheckOut.CheckOutMenu_Load(sender,e);   
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

      
    }
}
