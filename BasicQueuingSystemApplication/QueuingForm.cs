using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingSystemApplication
{
    public partial class QueuingForm : Form
    {

        public QueuingForm()
        {
            InitializeComponent();
        }

        private CashierClass cashier = new CashierClass();
        private void btnCasher_Click(object sender, EventArgs e)
        { 
             
            lblQueue.Text=cashier.CashierGeneratedNumber("P-");
            CashierClass.getNumberInQueue=lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
         }

        private void QueuingForm_Load(object sender, EventArgs e)
        {

        }
    }
    }

 