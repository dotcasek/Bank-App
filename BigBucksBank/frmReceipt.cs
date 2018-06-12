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
    public partial class frmReceipt : Form
    {
        const int Deposit = 0, Checking = 0;
        const int Withdraw = 1, Savings = 1;
        const int Transfer = 2;

        string target;
        int mode, account;
        decimal amount;
        Customer customer;
        public frmReceipt(Customer c, int mode, decimal amount, int accountType)
        {
            InitializeComponent();
            customer = c;
            this.mode = mode;
            this.amount = amount;
            account = accountType;
        }

        public frmReceipt(Customer c, int mode, decimal amount, int accountType, string target)
        {
            InitializeComponent();
            customer = c;
            this.mode = mode;
            this.amount = amount;
            account = accountType;
            this.target = target;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            lbName.Text = customer.Name;
            lbCkecking.Text = customer.Checking.Amount.ToString("c");
            lbSavings.Text = customer.Savings.Amount.ToString("c");
            if(account == Checking)
            {
                lbAccount.Text = "Checking-" + customer.Checking.AccountNumber.ToString().Substring(4, 4);
            }
            else
            {
                lbAccount.Text = "Savings-" + customer.Savings.AccountNumber.ToString().Substring(4, 4);
            }

            if (mode == Deposit)
            {
                lbTType.Text = "Deposit:";
                lbAmount.Text = amount.ToString("c");
            }
            if (mode == Withdraw)
            {
                lbTType.Text = "Withdraw:";
                lbAmount.Text = amount.ToString("c");
            }
            if (mode == Transfer)
            {
                lbTType.Text = "Transfer to: -" + target;
                lbAmount.Text = amount.ToString("c");
            }
        }
    }
}
