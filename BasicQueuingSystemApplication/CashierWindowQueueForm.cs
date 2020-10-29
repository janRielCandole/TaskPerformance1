using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BasicQueuingSystemApplication
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }


        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
                listCashierQueue.Items.Clear();
                foreach (Object obj in CashierList)
                {
                 listCashierQueue.Items.Add(obj.ToString());
                }
            }


        private void BtnNext_Click(object sender, EventArgs e)
        {
            CustomerView CustomerView = new CustomerView();
            CustomerView.ShowDialog();
        }
        Timer timer = new Timer();
        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
            timer.Stop();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
            timer.Stop();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e){
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
