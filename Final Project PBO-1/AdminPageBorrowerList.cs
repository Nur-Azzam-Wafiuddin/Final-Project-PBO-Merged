using Final_Project_PBO_1.Controller;
using Final_Project_PBO_1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_PBO_1
{
    public partial class AdminPageBorrowerList : UserControl
    {
        
        public AdminPageBorrowerList()
        {
            InitializeComponent();
            AccountController accountController = new AccountController();
            List<Account> accountList = accountController.GetAllAccount();

            foreach (Account account in accountList)
            {
                List<ProductHistory> productHistories = account.productHistory;
                foreach (ProductHistory productHistory in productHistories)
                {
                    string ItemName = productHistory.Name + ", ";
                }
                dataGridViewBorrower.Rows.Add(account.Name.ToString(), account.username.ToString(), account.productHistory);
            }
        }

        private void AdminPageBorrowerList_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Peminjam_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
