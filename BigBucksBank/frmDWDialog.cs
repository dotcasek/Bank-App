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
    public partial class frmDWDialog : Form
    {
        const int Deposit = 0, Checking = 0;
        const int Withdraw = 1, Savings = 1;
        int index = -1;
        int mode = -1;
        Customer customer;
        public frmDWDialog(Customer c, int mode)
        {
            InitializeComponent();
            customer = c;
            this.mode = mode;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                decimal amount = Decimal.Parse(tbAmount.Text);
                frmReceipt receipt = new frmReceipt(customer, mode, amount, index);

                switch (mode)
                {
                    case Deposit:
                        if (index == Checking)
                        {
                            customer.Checking.Amount += amount;
                        }
                        if (index == Savings)
                        {
                            customer.Savings.Amount += amount;

                        }
                        this.Close();
                        receipt.ShowDialog();
                        break;
                    case Withdraw:

                        // validate error message and confirmation
                        if (index == Checking)
                        {
                            if (amount > customer.Checking.Amount)
                            {
                                MessageBox.Show("Insufficient Funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            }
                            customer.Checking.Amount -= amount;
                        }
                        if (index == Savings)
                        {
                            customer.Savings.Amount -= amount;

                        }
                        this.Close();
                        receipt.ShowDialog();
                        break;
                }
           
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValid()
        {
            return Validator.isSelected(cboBox) && Validator.IsPresent(tbAmount) && 
                Validator.IsMoneyDecimal(tbAmount) && Validator.IsPositive(tbAmount);

        }

        private void cboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cboBox.SelectedIndex;
        }

        private void frmDWDialog_Load(object sender, EventArgs e)
        {
            cboBox.Items.Clear();
            cboBox.Items.Add("Checking-" + customer.Checking.AccountNumber.ToString().Substring(4, 4));
            cboBox.Items.Add("Savings-" + customer.Savings.AccountNumber.ToString().Substring(4, 4));
        }
    }
}
