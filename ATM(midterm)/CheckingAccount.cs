using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public class CheckingAccount : Account
    {
        private decimal fee;
        private decimal balance;

        public CheckingAccount(int accountNumber, decimal balance, decimal fee) : base(accountNumber, balance)
        {
            Fee = fee;
        }

        public override decimal Balance
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
                    //Pull remaining money from the savings account
                    List<BankCustomer> bankCustomers = SQLHelper.SelectFromBankCustomer();
                    List<Account> accounts = SQLHelper.SelectFromAccount();
                    foreach (BankCustomer bankCustomer in bankCustomers)
                    {
                        if(bankCustomer.CheckingAccountNumber == AccountNumber)
                        {
                            foreach (Account savingsAccount in accounts)
                            {
                                if (savingsAccount.AccountNumber == bankCustomer.SavingsAccountNumber)
                                {
                                    if (value + savingsAccount.Balance >= 0)
                                    {
                                        balance = 0.0M;
                                        SQLHelper.UpdateAccount(AccountNumber.ToString(), balance.ToString());
                                    }
                                    else
                                    {
                                        MessageBox.Show("Not enough money to withdraw");
                                        break;
                                    }
                                    savingsAccount.Balance += value;
                                    SQLHelper.UpdateAccount(savingsAccount.AccountNumber.ToString(), savingsAccount.Balance.ToString());
                                    MessageBox.Show("Transfered from savings account");
                                }
                            }
                        }
                    }
                }
            }
        }

        public decimal Fee
        {
            get { return fee; }
            set
            {
                if (value > 0)
                {
                   fee = value;
                }
                else
                {
                    MessageBox.Show("Fee must be greater than zero");
                }
            }
        }

        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance -= Fee;
        }

        public override bool Debit(decimal amount)
        {
            if (base.Debit(amount))
            {
                Balance -= Fee;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
