using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank
{
    public class Customer
    {


        public class Account
        {

            //            private int type;
            private int accountNumber;
            private decimal amount;

            public Account(int accountNum, decimal balance)
            {
                //              this.Type = type;
                this.AccountNumber = accountNum;
                this.Amount = balance;
            }
            //        public int Type { get { return type; } set { type = value; } }
            public int AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
            public decimal Amount { get { return amount; } set { amount = value; } }
        }



        private string name;
        private Account checking, savings;
        private string pin;
        private bool admin;

        public Customer(string name, Account checking, Account savings, string pin, bool admin)
        {
            this.Name = name;
            this.Pin = pin;
            this.Admin = admin;
            this.Checking = checking;
            this.Savings = savings;

        }

        public string Name { get { return name; } set { name = value; } }
        public string Pin { get { return pin; } set { pin = value; } }
        public bool Admin { get { return admin; } set { admin = value; } }
        public Account Checking { get { return checking; } set { checking = value; } }
        public Account Savings { get { return savings; } set { savings = value; } }



    }
}
