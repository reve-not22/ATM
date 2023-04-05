using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public class Account
    {
        private int accountNumber;
        private decimal balance;

        public Account(int accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            Balance = balance;
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set { }
        } 

        public virtual decimal Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    MessageBox.Show("Balance cannot be negative");
                }
            }
        }

        public virtual void Credit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                MessageBox.Show("Please input an amount greater than zero");
            }
        }

        public virtual bool Debit(decimal amount)
        {
            bool OK = true;
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                OK = true;
            }
            else
            {
                MessageBox.Show("Debit Amount Exceeded account balance");
                OK = false;
            }
            return OK;
        }
    }
}
