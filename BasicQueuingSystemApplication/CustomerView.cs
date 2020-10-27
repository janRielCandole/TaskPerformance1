﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingSystemApplication
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            try
            {
                lblCustomerView.Text = CashierClass.CashierQueue.Peek();
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("The List Is Empty.");
                this.Close();
            }
        }
    }
}
