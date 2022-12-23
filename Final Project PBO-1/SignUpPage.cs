using Final_Project_PBO_1.Controller;
using Final_Project_PBO_1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_PBO_1
{
    public partial class SignUpPage : Form
    {
        
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void txtUsername_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPasswordSignUp.Text.Length > 0)
            {
                btnShowCPW.Visible = true;
            }
            else
            {
                btnShowCPW.Visible = false;
            }
        }

        private void ClearDataSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPasswordSignUp.Clear();
            txtNameSignUp.Clear();
            txtUsernameSignUp.Clear();
            txtConfirmPasswordSignUp.Clear();
        }

        private void txtNameSignUp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginpage = new LoginPage();
            loginpage.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnShowPW_Click(object sender, EventArgs e)
        {
            if (txtConfirmPasswordSignUp.PasswordChar == '*')
            {
                txtConfirmPasswordSignUp.PasswordChar = '\0';
                btnShowCPW.Hide();
                btnHideCPW.Show();
            }
            else
            {
                txtConfirmPasswordSignUp.PasswordChar = '*';
            }
        }

        private void btnHidePW_Click(object sender, EventArgs e)
        {
            if (txtConfirmPasswordSignUp.PasswordChar == '\0')
            {
                txtConfirmPasswordSignUp.PasswordChar = '*';
                btnHideCPW.Hide();
                btnShowCPW.Show();

            }
            else
            {
                txtConfirmPasswordSignUp.PasswordChar = '\0';
            }
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            if(txtPasswordSignUp.Text != txtConfirmPasswordSignUp.Text)
            {
                DialogResult pwnotmatch = MessageBox.Show("Your Password and Confirmation Does Not Match");
            }
            else 
            {
            DialogResult successsignup = MessageBox.Show("Sign Up Successfully");
            var homepage = new MainForm();
            this.Hide();
            homepage.Show();
            AccountController accountController = new AccountController();
            accountController.PostAccount(txtNameSignUp.Text, txtUsernameSignUp.Text, txtPasswordSignUp.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsernameSignUp_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordSignUp.Text.Length > 0)
            {
                btnShowPW.Visible = true;
            }
            else
            {
                btnShowPW.Visible = false;
            }
        }

        private void btnHidePW_Click_1(object sender, EventArgs e)
        {
            if (txtPasswordSignUp.PasswordChar == '\0')
            {
                txtPasswordSignUp.PasswordChar = '*';
                btnHidePW.Hide();
                btnShowPW.Show();

            }
            else
            {
                txtPasswordSignUp.PasswordChar = '\0';
            }
        }

        private void btnShowPW_Click_1(object sender, EventArgs e)
        {
            if (txtPasswordSignUp.PasswordChar == '*')
            {
                txtPasswordSignUp.PasswordChar = '\0';
                btnShowPW.Hide();
                btnHidePW.Show();
            }
            else
            {
                txtPasswordSignUp.PasswordChar = '*';
            }
        }
    }
}
