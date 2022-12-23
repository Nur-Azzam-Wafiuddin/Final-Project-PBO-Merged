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
    public partial class AdminPageUserList : UserControl
    {
        public AdminPageUserList()
        {
            InitializeComponent();
            AccountController accountController = new AccountController();
            List<Account> accoutList = accountController.GetAllAccount();
            foreach (Account account in accoutList)
            {
                dataGridViewUser.Rows.Add(account.id.ToString(), account.Name.ToString(), account.username.ToString());
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
