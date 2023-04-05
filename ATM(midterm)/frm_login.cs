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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            List<BankCustomer> bankCustomerList = SQLHelper.SelectFromBankCustomer();
            bool showMsg = true;
            foreach(BankCustomer customer in bankCustomerList)
            {
                try
                {
                    if (customer.PIN == Convert.ToInt32(txt_PIN.Text) && customer.CustomerNumber == Convert.ToInt32(txt_CustomerNumber.Text))
                    {
                        MessageBox.Show("Login Success!");
                        var form2 = new frm_account(customer.CustomerNumber);
                        this.Hide();
                        form2.Show();
                        showMsg = false;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please input an integer.");
                }
               
            }
            if (showMsg)
            {
                MessageBox.Show("Incorrect PIN or Customer Number");
            }
        }
        private void btn_Register_Click(object sender, EventArgs e)
        {
            SQLHelper.InsertIntoBankCustomer(Convert.ToInt32(txt_PIN_2.Text), Convert.ToDecimal(txt_Checking.Text), Convert.ToDecimal(txt_Savings.Text));
        }   

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
