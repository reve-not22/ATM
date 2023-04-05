using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class BankCustomer
    {
        private int customerNumber;
        public int PIN;
        public int CheckingAccountNumber;
        public int SavingsAccountNumber;

        public BankCustomer(int customerNumber, int pIN, int checking_Account_Number, int savings_Account_Number)
        {
            //Each bank customer is assigned unique accounts numbers for both checking and savings in their respective databases
            this.customerNumber = customerNumber;
            PIN = pIN;
            CheckingAccountNumber = checking_Account_Number;
            SavingsAccountNumber = savings_Account_Number;
        }

        public int CustomerNumber
        {
            get { return customerNumber; }
            set { }
        }
    }
}
