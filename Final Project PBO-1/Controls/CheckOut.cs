﻿using CartTemp;
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
    public partial class CheckOut : UserControl
    {
        public CheckOut()
        {
            InitializeComponent();
        }
        public void LoadThis(object sender, EventArgs e)
        {
            lblGearName.Text = Cart.show(this.TabIndex);
            //ganti teks
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart.remove(this.TabIndex);
            //terus remove dari list
        }
    }
}
