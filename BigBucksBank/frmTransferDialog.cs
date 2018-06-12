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
    public partial class frmTransferDialog : Form
    {
        const int Deposit = 0, Checking = 0;
        const int Withdraw = 1, Savings = 1;
        int index = -1;

        Customer customer;

        public frmTransferDialog(Customer c)
        {
            InitializeComponent();
            customer = c;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                decimal amount = Decimal.Parse(tbAmount.Text);
                string target = tbTarget.Text.Substring(4, 4);

                if (index == Checking)
                {
                    customer.Checking.Amount -= amount;
                }
                if (index == Savings)
                {
                    customer.Savings.Amount -= amount;
                }

                foreach(Customer c in frmLogIn.userList)
                {
                    if(String.Compare(tbTarget.Text, c.Checking.AccountNumber.ToString()) == 0){
                        c.Checking.Amount += amount;
                    }
                    if (String.Compare(tbTarget.Text, c.Savings.AccountNumber.ToString()) == 0)
                    {
                        c.Savings.Amount += amount;
                    }
                }



                frmReceipt receipt = new frmReceipt(customer, 2, amount, index, target);
                this.Close();
                receipt.ShowDialog();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTransferDialog_Load(object sender, EventArgs e)
        {
            cboBox.Items.Clear();
            cboBox.Items.Add("Checking-" + customer.Checking.AccountNumber.ToString().Substring(4, 4));
            cboBox.Items.Add("Savings-" + customer.Savings.AccountNumber.ToString().Substring(4, 4));
        }

        private void cboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cboBox.SelectedIndex;
        }

        private bool IsValid()
        {
            return Validator.isSelected(cboBox) && Validator.IsPresent(tbAmount) && Validator.IsPresent(tbTarget) &&
                Validator.IsCorrectLength(tbTarget, 8) && Validator.IsInt32(tbTarget) && 
                Validator.IsMoneyDecimal(tbAmount) && Validator.IsPositive(tbAmount) &&
                HasFunds(tbAmount) && TargetAccountExists(tbTarget) && isUniqueAccount(tbTarget);

        }

        private bool HasFunds(TextBox amount)
        {
            if(index == Checking)
            {
                if (decimal.Parse(amount.Text) > customer.Checking.Amount)
                {
                    MessageBox.Show("Insufficient Funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    amount.Focus();
                    return false;
                }
            }
            if (index == Savings)
            {
                if (decimal.Parse(amount.Text) > customer.Savings.Amount)
                {
                    MessageBox.Show("Insufficient Funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    amount.Focus();
                    return false;
                }

            }

            return true;
        }

        private bool TargetAccountExists(TextBox target)
        {
            
            foreach(Customer c in frmLogIn.userList)
            {
                if(String.Compare(target.Text, c.Checking.AccountNumber.ToString()) == 0)
                {
                    return true;
                }
                if (String.Compare(target.Text, c.Savings.AccountNumber.ToString()) == 0)
                {
                    return true;
                }
            }
            MessageBox.Show("Target account does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            target.Focus();
            return false;
        }

        private bool isUniqueAccount(TextBox target)
        {
            if(index == Checking)
            {
                if(String.Compare(target.Text, customer.Checking.AccountNumber.ToString()) == 0)
                {
                    MessageBox.Show("Target cannot be same as source account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            
            }
            if(index == Savings)
            {
                if (String.Compare(target.Text, customer.Savings.AccountNumber.ToString()) == 0)
                {
                    MessageBox.Show("Target cannot be same as source account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            return true;
        }

    }
}
