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
    public partial class frmLogIn : Form
    {
        public static int attempts = 0;
        public static Customer[] userList = new Customer[5];

        public frmLogIn()
        {

            InitializeComponent();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            attempts++;
            if (attempts >= 3)
            {
                tbMessage.Visible = true;
                tbMessage.Clear();
                tbMessage.AppendText("PLEASE SEE A BANK OFFICER\n");
                tbMessage.AppendText("NO FURTHER LOGIN ATTEMPTS ALLOWED");
               
            }


            if (isValidData())
            {

                if (UserExists() && PinMatches())
                {
                    if (GetData().Admin == true)
                    {
                        btClear.Visible = false;
                        btSubmit.Visible = false;
                        btRelease.Visible = true;
                        btQuit.Visible = true;
                        tbMessage.Clear();
                        ClearFields();
                        tbMessage.AppendText("ADMIN MODE");

                        return;
                    }
                    if (attempts <= 3)
                    {
                        tbMessage.Visible = false;
                        attempts = 0;
                        frmMenu menu = new frmMenu(GetData());
                        this.Visible = false;
                        menu.ShowDialog();
                        ClearFields();
                        this.Visible = true;
                    }



                }
                else
                {
                    ClearFields();
                }
            }
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            userList[0] = new Customer("Jane Dane", new Customer.Account(12341234, 5000m),
              new Customer.Account(12344321, 1000m), "1122", false);
            userList[1] = new Customer("Joe Malone", new Customer.Account(54322345, 872.50m),
                new Customer.Account(78362837, 0m), "2323", false);
            userList[2] = new Customer("Henry Potter", new Customer.Account(98989898, 325.87m),
                new Customer.Account(67676767, 25m), "0678", false);
            userList[3] = new Customer("Sam Samulson", new Customer.Account(12345676, 32078.84m),
                new Customer.Account(56382736, 7560m), "2828", false);
            userList[4] = new Customer("Admin", new Customer.Account(-1, 0m),
                new Customer.Account(-1, 0m), "1234", true);

            tbMessage.Visible = false;
            btRelease.Visible = false;
            btQuit.Visible = false;
        }

        private bool isValidData()
        {
            return Validator.IsPresent(tbUserName) && Validator.IsPresent(tbPassword) &&
                Validator.IsInt32(tbPassword) && Validator.IsCorrectLength(tbPassword, 4) &&
                Validator.StartsWithLetter(tbUserName);
        }

        private bool UserExists()
        {
            foreach (Customer c in userList)
            {
                if (String.Compare(tbUserName.Text.ToString(), c.Name.ToString(), true) == 0)
                {
                    return true;
                }
            }
            MessageBox.Show("Name doesn't exist.", "Entry Error");
            tbUserName.Focus();
            return false;
        }

        private bool PinMatches()
        {
            foreach (Customer c in userList)
            {
                if (String.Compare(tbUserName.Text.ToString(), c.Name.ToString(), true) == 0 &&
                        String.Compare(tbPassword.Text.ToString(), c.Pin.ToString()) == 0)
                {
                    return true;
                }
            }
            MessageBox.Show("Invalid PIN.", "Entry Error");
            tbPassword.Focus();
            return false;
        }

        private void ClearFields()
        {
            tbUserName.Focus();
            tbUserName.Text = "";
            tbPassword.Text = "";
        }

        private Customer GetData()
        {
            foreach (Customer c in userList)
            {
                if (String.Compare(tbUserName.Text.ToString(), c.Name.ToString(), true) == 0 &&
                        String.Compare(tbPassword.Text.ToString(), c.Pin.ToString()) == 0)
                {
                    return c;
                }
            }
            return null;
        }

        private void btRelease_Click(object sender, EventArgs e)
        {
            btSubmit.Visible = true;
            btRelease.Visible = false;
            btQuit.Visible = false;
            tbMessage.Visible = false;
            btClear.Visible = true;
            attempts = 0;
            ClearFields();

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
