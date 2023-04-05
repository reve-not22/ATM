namespace ATM
{
    partial class frm_account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Bal_Checking = new System.Windows.Forms.Label();
            this.label_Bal_Savings = new System.Windows.Forms.Label();
            this.txt_Bal_Checking = new System.Windows.Forms.TextBox();
            this.txt_Bal_Savings = new System.Windows.Forms.TextBox();
            this.btn_Withdraw_Checking = new System.Windows.Forms.Button();
            this.btn_Widthdraw_Savings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Amount_Savings = new System.Windows.Forms.TextBox();
            this.txt_Amount_Checking = new System.Windows.Forms.TextBox();
            this.txt_Amount_Transfer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Account_Deposit = new System.Windows.Forms.TextBox();
            this.txt_Account_Withdrawal = new System.Windows.Forms.TextBox();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.label_CheckingNum = new System.Windows.Forms.Label();
            this.label_SavingsNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Bal_Checking
            // 
            this.label_Bal_Checking.AutoSize = true;
            this.label_Bal_Checking.Location = new System.Drawing.Point(12, 9);
            this.label_Bal_Checking.Name = "label_Bal_Checking";
            this.label_Bal_Checking.Size = new System.Drawing.Size(140, 13);
            this.label_Bal_Checking.TabIndex = 0;
            this.label_Bal_Checking.Text = "Checking Account Balance:";
            // 
            // label_Bal_Savings
            // 
            this.label_Bal_Savings.AutoSize = true;
            this.label_Bal_Savings.Location = new System.Drawing.Point(154, 9);
            this.label_Bal_Savings.Name = "label_Bal_Savings";
            this.label_Bal_Savings.Size = new System.Drawing.Size(133, 13);
            this.label_Bal_Savings.TabIndex = 1;
            this.label_Bal_Savings.Text = "Savings Account Balance:";
            // 
            // txt_Bal_Checking
            // 
            this.txt_Bal_Checking.Location = new System.Drawing.Point(13, 26);
            this.txt_Bal_Checking.Name = "txt_Bal_Checking";
            this.txt_Bal_Checking.Size = new System.Drawing.Size(100, 20);
            this.txt_Bal_Checking.TabIndex = 2;
            // 
            // txt_Bal_Savings
            // 
            this.txt_Bal_Savings.Location = new System.Drawing.Point(157, 26);
            this.txt_Bal_Savings.Name = "txt_Bal_Savings";
            this.txt_Bal_Savings.Size = new System.Drawing.Size(100, 20);
            this.txt_Bal_Savings.TabIndex = 3;
            // 
            // btn_Withdraw_Checking
            // 
            this.btn_Withdraw_Checking.Location = new System.Drawing.Point(12, 132);
            this.btn_Withdraw_Checking.Name = "btn_Withdraw_Checking";
            this.btn_Withdraw_Checking.Size = new System.Drawing.Size(75, 23);
            this.btn_Withdraw_Checking.TabIndex = 4;
            this.btn_Withdraw_Checking.Text = "Withdraw";
            this.btn_Withdraw_Checking.UseVisualStyleBackColor = true;
            this.btn_Withdraw_Checking.Click += new System.EventHandler(this.btn_Withdraw_Checking_Click);
            // 
            // btn_Widthdraw_Savings
            // 
            this.btn_Widthdraw_Savings.Location = new System.Drawing.Point(157, 132);
            this.btn_Widthdraw_Savings.Name = "btn_Widthdraw_Savings";
            this.btn_Widthdraw_Savings.Size = new System.Drawing.Size(75, 23);
            this.btn_Widthdraw_Savings.TabIndex = 6;
            this.btn_Widthdraw_Savings.Text = "Withdraw";
            this.btn_Widthdraw_Savings.UseVisualStyleBackColor = true;
            this.btn_Widthdraw_Savings.Click += new System.EventHandler(this.btn_Widthdraw_Savings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amount:";
            // 
            // txt_Amount_Savings
            // 
            this.txt_Amount_Savings.Location = new System.Drawing.Point(156, 106);
            this.txt_Amount_Savings.Name = "txt_Amount_Savings";
            this.txt_Amount_Savings.Size = new System.Drawing.Size(100, 20);
            this.txt_Amount_Savings.TabIndex = 9;
            // 
            // txt_Amount_Checking
            // 
            this.txt_Amount_Checking.Location = new System.Drawing.Point(12, 106);
            this.txt_Amount_Checking.Name = "txt_Amount_Checking";
            this.txt_Amount_Checking.Size = new System.Drawing.Size(100, 20);
            this.txt_Amount_Checking.TabIndex = 8;
            // 
            // txt_Amount_Transfer
            // 
            this.txt_Amount_Transfer.Location = new System.Drawing.Point(15, 261);
            this.txt_Amount_Transfer.Name = "txt_Amount_Transfer";
            this.txt_Amount_Transfer.Size = new System.Drawing.Size(100, 20);
            this.txt_Amount_Transfer.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Withdrawal Account Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Deposit Account Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Amount:";
            // 
            // txt_Account_Deposit
            // 
            this.txt_Account_Deposit.Location = new System.Drawing.Point(156, 211);
            this.txt_Account_Deposit.Name = "txt_Account_Deposit";
            this.txt_Account_Deposit.Size = new System.Drawing.Size(100, 20);
            this.txt_Account_Deposit.TabIndex = 17;
            // 
            // txt_Account_Withdrawal
            // 
            this.txt_Account_Withdrawal.Location = new System.Drawing.Point(15, 211);
            this.txt_Account_Withdrawal.Name = "txt_Account_Withdrawal";
            this.txt_Account_Withdrawal.Size = new System.Drawing.Size(100, 20);
            this.txt_Account_Withdrawal.TabIndex = 16;
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.Location = new System.Drawing.Point(15, 305);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(75, 23);
            this.btn_Transfer.TabIndex = 20;
            this.btn_Transfer.Text = "Transfer";
            this.btn_Transfer.UseVisualStyleBackColor = true;
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // label_CheckingNum
            // 
            this.label_CheckingNum.AutoSize = true;
            this.label_CheckingNum.Location = new System.Drawing.Point(13, 53);
            this.label_CheckingNum.Name = "label_CheckingNum";
            this.label_CheckingNum.Size = new System.Drawing.Size(90, 13);
            this.label_CheckingNum.TabIndex = 21;
            this.label_CheckingNum.Text = "Account Number:";
            // 
            // label_SavingsNum
            // 
            this.label_SavingsNum.AutoSize = true;
            this.label_SavingsNum.Location = new System.Drawing.Point(154, 53);
            this.label_SavingsNum.Name = "label_SavingsNum";
            this.label_SavingsNum.Size = new System.Drawing.Size(90, 13);
            this.label_SavingsNum.TabIndex = 22;
            this.label_SavingsNum.Text = "Account Number:";
            // 
            // frm_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 341);
            this.Controls.Add(this.label_SavingsNum);
            this.Controls.Add(this.label_CheckingNum);
            this.Controls.Add(this.btn_Transfer);
            this.Controls.Add(this.txt_Account_Deposit);
            this.Controls.Add(this.txt_Account_Withdrawal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Amount_Transfer);
            this.Controls.Add(this.txt_Amount_Savings);
            this.Controls.Add(this.txt_Amount_Checking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Widthdraw_Savings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Withdraw_Checking);
            this.Controls.Add(this.txt_Bal_Savings);
            this.Controls.Add(this.txt_Bal_Checking);
            this.Controls.Add(this.label_Bal_Savings);
            this.Controls.Add(this.label_Bal_Checking);
            this.Name = "frm_account";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Bal_Checking;
        private System.Windows.Forms.Label label_Bal_Savings;
        private System.Windows.Forms.TextBox txt_Bal_Checking;
        private System.Windows.Forms.TextBox txt_Bal_Savings;
        private System.Windows.Forms.Button btn_Withdraw_Checking;
        private System.Windows.Forms.Button btn_Widthdraw_Savings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Amount_Savings;
        private System.Windows.Forms.TextBox txt_Amount_Checking;
        private System.Windows.Forms.TextBox txt_Amount_Transfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Account_Deposit;
        private System.Windows.Forms.TextBox txt_Account_Withdrawal;
        private System.Windows.Forms.Button btn_Transfer;
        private System.Windows.Forms.Label label_CheckingNum;
        private System.Windows.Forms.Label label_SavingsNum;
    }
}