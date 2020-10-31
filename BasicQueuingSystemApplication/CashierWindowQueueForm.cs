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

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
                listCashierQueue.Items.Clear();
                foreach (Object obj in CashierList)
                {
                 listCashierQueue.Items.Add(obj.ToString());
                }
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
            CustomerView CustomerView = new CustomerView();
            CustomerView.ShowDialog();
            timer.Start();
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public int TimerCount;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                TimerCount++;
                lblCustomerView.Text = TimerCount.ToString();
                if (TimerCount == 13)
                {
                    CustomerTimer.Stop();
                    TimerCount = 0;
                    CustomerView CustomerView = new CustomerView();
                    CustomerView.ShowDialog();

                    DisplayCashierQueue(CashierClass.CashierQueue.Dequeue());

                }
            }
            catch (System.InvalidOperationException)
            {
                this.Close();
            }

        }
    }
    }
