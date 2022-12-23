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
    public partial class HistoryMenu : UserControl
    {
        public HistoryMenu()
        {
            InitializeComponent();
        }
        public HistoryMenu(string user)
        {
            InitializeComponent();
            this.labeltumbal1.Text = user;
        }

        public void HistoryMenu_Load(object sender, EventArgs e)
        {
            AccountController accountController = new AccountController();
            List<Account> accoutList = accountController.GetAllAccount();
            Account FoundUser = accoutList.Find(x => x.username == this.labeltumbal1.Text);

            for (int i = 0; i < 18; i++)
            {
                HistoryList HistoryCheck = new Final_Project_PBO_1.HistoryList();
                this.panel3.Controls.Add(HistoryCheck);

                HistoryCheck.Location = new System.Drawing.Point(0, 20 + (i * 70));
                HistoryCheck.Name = FoundUser.productHistory[i].name;
                HistoryCheck.Size = new System.Drawing.Size(1249, 59);
                HistoryCheck.TabIndex = i;
            }
        }

        private void labeltumbal1_Click(object sender, EventArgs e)
        {

        }
    }
}
