using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class frm_account : Form
    {
        public int currentCustomerNum = 0;
        private decimal fee = 0.5M;
        private decimal interestRate = 0.08M;
        private List<BankCustomer> customers = SQLHelper.SelectFromBankCustomer();
        private List<Account> accounts = SQLHelper.SelectFromAccount();

        public frm_account(int cur_Account_Num)
        {
            InitializeComponent();
            currentCustomerNum = cur_Account_Num;
            update_Text();
            label_CheckingNum.Text = "Checking Account Number:" + customers[currentCustomerNum - 1].CheckingAccountNumber.ToString();
            label_SavingsNum.Text = "Savings Account Number:" + customers[currentCustomerNum - 1].SavingsAccountNumber.ToString();
        }

        private void btn_Withdraw_Checking_Click(object sender, EventArgs e)
        {
            try
            {
                int accNum = (customers[currentCustomerNum - 1].CheckingAccountNumber);
                CheckingAccount newChecking = new CheckingAccount(accNum, accounts[accNum - 1].Balance, fee);
                newChecking.Balance -= Convert.ToDecimal(txt_Amount_Checking.Text);
                SQLHelper.UpdateAccount(accNum.ToString(), newChecking.Balance.ToString());
                update_Text();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input a number.");
            }
        }

        private void btn_Widthdraw_Savings_Click(object sender, EventArgs e)
        {
            try
            {
                int accNum = (customers[currentCustomerNum - 1].SavingsAccountNumber);
                SavingsAccount newSavings = new SavingsAccount(accNum, accounts[accNum - 1].Balance, interestRate);
                newSavings.Balance -= Convert.ToDecimal(txt_Amount_Savings.Text);
                SQLHelper.UpdateAccount(accNum.ToString(), newSavings.Balance.ToString());
                update_Text();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input a number.");
            }
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            if (txt_Amount_Transfer.Text != String.Empty && txt_Account_Withdrawal.Text != String.Empty && txt_Account_Deposit.Text != String.Empty)
            {
                Account withdrawal = accounts[Convert.ToInt32(txt_Account_Withdrawal.Text) - 1];
                Account deposit = accounts[Convert.ToInt32(txt_Account_Deposit.Text) - 1];
                if (withdrawal.Balance >= Convert.ToDecimal(txt_Amount_Transfer.Text))
                {
                    withdrawal.Balance -= Convert.ToDecimal(txt_Amount_Transfer.Text);
                    deposit.Balance += Convert.ToDecimal(txt_Amount_Transfer.Text);
                    SQLHelper.UpdateAccount(txt_Account_Withdrawal.Text, withdrawal.Balance.ToString());
                    SQLHelper.UpdateAccount(txt_Account_Deposit.Text, deposit.Balance.ToString());
                    update_Text();
                }
                else
                {
                    MessageBox.Show("Not enough money to transfer.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all text fields.");
            }
        }

        private void update_Text()
        {
            customers = SQLHelper.SelectFromBankCustomer();
            accounts = SQLHelper.SelectFromAccount();
            txt_Bal_Checking.Text = accounts[(customers[currentCustomerNum - 1].CheckingAccountNumber) - 1].Balance.ToString();
            txt_Bal_Savings.Text = accounts[(customers[currentCustomerNum - 1].SavingsAccountNumber) - 1].Balance.ToString();
        }

        private void frm_account_Load(object sender, EventArgs e)
        {

        }
    }
}
