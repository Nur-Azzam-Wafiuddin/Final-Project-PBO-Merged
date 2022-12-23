using CartTemp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using Final_Project_PBO_1.Model;
using Final_Project_PBO_1.Controller;


namespace Final_Project_PBO_1
{
    public partial class CheckOutMenu : UserControl
    {
        CheckOut CheckList = new Final_Project_PBO_1.CheckOut();
        public CheckOutMenu()
        {
            InitializeComponent();
        }
        public CheckOutMenu(string user)
        {
            InitializeComponent();
            this.labeltumbal.Text = user;
        }
        public void CheckOutMenu_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Cart.getCount(); i++)
            {
                CheckOut CheckList = new Final_Project_PBO_1.CheckOut();
                this.panel1.Controls.Add(CheckList);

                CheckList.Location = new System.Drawing.Point(93, (i * 50));
                CheckList.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
                CheckList.Name = "checkOut";
                CheckList.Size = new System.Drawing.Size(596, 41);
                CheckList.TabIndex = i;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            AccountController accountController = new AccountController();
            List<Account> accoutList = accountController.GetAllAccount();
            ProductHistory prodHis = new ProductHistory();
            Account FoundUser = accoutList.Find(x => x.username == this.labeltumbal.Text);
            for (int i = 0; i < Cart.getCount(); i++)
            {
                prodHis.name = Cart.show(i);
            }
            FoundUser.productHistory.Add(prodHis);
            Cart.clear();
            this.panel1.Controls.Clear();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
