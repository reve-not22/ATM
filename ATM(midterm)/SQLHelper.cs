using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class SQLHelper
    {
        //Insert Commands
        public static void InsertIntoAccount(decimal Balance)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\demat\\source\\repos\\ATM(midterm)\\ATM(midterm)\\DB.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sql = "INSERT INTO Account (Balance) values ('" + Balance + "')";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }

        public static void InsertIntoBankCustomer(int PIN, decimal CheckingValue, decimal SavingsValue)
        {
            InsertIntoAccount(CheckingValue);
            InsertIntoAccount(SavingsValue);
            List<Account> accounts = SelectFromAccount();

            string connectionString;
            SqlConnection cnn;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\demat\\source\\repos\\ATM(midterm)\\ATM(midterm)\\DB.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sql = "INSERT INTO BankCustomer (PIN, Checking_Account_Number, Savings_Account_Number) values ('" + PIN + "', '" + (accounts.Count - 1).ToString() + "', '" + accounts.Count.ToString() + "')";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }

        //Update Commands
        public static void UpdateAccount(string AccountNumber, string newBalance)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\demat\\source\\repos\\ATM(midterm)\\ATM(midterm)\\DB.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sql = "UPDATE Account SET Balance = '" + newBalance + "' WHERE Account_Number = '" + AccountNumber + "'";
            command = new SqlCommand(sql, cnn);

            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose(); 
            cnn.Close(); 
        }

        //Delete Commands
        public static void DeleteAccount(string AccountNumber)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\demat\\source\\repos\\ATM(midterm)\\ATM(midterm)\\DB.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "DELETE FROM Account WHERE Account_Number = '" + AccountNumber + "'";

            command = new SqlCommand(sql, cnn);

            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }

        public static void DeleteBankCustomer(string CustomerNumber)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\demat\\source\\repos\\ATM(midterm)\\ATM(midterm)\\DB.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "DELETE FROM BankCustomer WHERE Customer_Number = '" + CustomerNumber + "'";

            command= new SqlCommand(sql, cnn);
            
            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }

        //Select Commands
        public static List<Account> SelectFromAccount()
        {
            List<Account> accountList = new List<Account>();

            string connectionString;
            SqlConnection cnn;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\demat\\source\\repos\\ATM(midterm)\\ATM(midterm)\\DB.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql = "Select Account_Number,Balance from Account";
            
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Account myAccount = new Account(Convert.ToInt32(dataReader.GetValue(0)), Convert.ToDecimal(dataReader.GetValue(1)));
                accountList.Add(myAccount);
            }

            dataReader.Close();
            cnn.Close();
            command.Dispose();

            return accountList;
        }

        public static List<BankCustomer> SelectFromBankCustomer()
        {
            List<BankCustomer> customerList = new List<BankCustomer>();

            string connectionString;
            SqlConnection cnn;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\demat\\source\\repos\\ATM(midterm)\\ATM(midterm)\\DB.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql = "Select Customer_Number,PIN,Checking_Account_Number,Savings_Account_Number from BankCustomer";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                BankCustomer newEntry = new BankCustomer(Convert.ToInt32(dataReader.GetValue(0)), Convert.ToInt32(dataReader.GetValue(1)), Convert.ToInt32(dataReader.GetValue(2)), Convert.ToInt32(dataReader.GetValue(3)));
                customerList.Add(newEntry);
            }

            dataReader.Close();
            cnn.Close();
            command.Dispose();

            return customerList;
        }
    }
}
