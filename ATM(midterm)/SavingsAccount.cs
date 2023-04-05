using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public class SavingsAccount : Account
    {
        private decimal interestRate;

        public SavingsAccount(int accountNumber, decimal balance, decimal interestRate) : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public decimal InterestRate
        {
            get { return interestRate; }
            set
            {
                if (value > 0)
                {
                    interestRate = value;
                }
                else
                {
                    MessageBox.Show("Interest rate must be greater than zero");
                }
            }
        }

        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }
    }
}
