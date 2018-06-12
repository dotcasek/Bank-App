using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksBank
{
    public partial class frmMenu : Form
    {

        private Customer customer;
        public frmMenu(Customer c)
        {
            InitializeComponent();
            customer = c;

        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if(rbDeposit.Checked)
            {
                frmDWDialog depositDialog = new frmDWDialog(customer, 0);
                depositDialog.ShowDialog();

            }
            if (rbWithdrawl.Checked)
            {
                frmDWDialog withdrawDialog = new frmDWDialog(customer, 1);
                withdrawDialog.ShowDialog();
            }
            if (rbBalance.Checked)
            {
                MessageBox.Show("Current Balance:\n\nChecking - " + customer.Checking.Amount.ToString("c") +
                    "\nSavings - " + customer.Savings.Amount.ToString("c"), "Balance - BBB",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (rbTransfer.Checked)
            {
                frmTransferDialog transferDialog = new frmTransferDialog(customer);
                transferDialog.ShowDialog();
            }
            if (rbExit.Checked)
            {
                this.Close();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
