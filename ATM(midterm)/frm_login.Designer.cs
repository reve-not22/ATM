namespace ATM
{
    partial class frm_login
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
            this.label_PIN = new System.Windows.Forms.Label();
            this.txt_PIN = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_CustomerNumber = new System.Windows.Forms.TextBox();
            this.label_CustomerNumber = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.txt_PIN_2 = new System.Windows.Forms.TextBox();
            this.label_PIN_2 = new System.Windows.Forms.Label();
            this.txt_Checking = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Savings = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_PIN
            // 
            this.label_PIN.AutoSize = true;
            this.label_PIN.Location = new System.Drawing.Point(9, 50);
            this.label_PIN.Name = "label_PIN";
            this.label_PIN.Size = new System.Drawing.Size(28, 13);
            this.label_PIN.TabIndex = 0;
            this.label_PIN.Text = "PIN:";
            // 
            // txt_PIN
            // 
            this.txt_PIN.Location = new System.Drawing.Point(12, 66);
            this.txt_PIN.Name = "txt_PIN";
            this.txt_PIN.Size = new System.Drawing.Size(100, 20);
            this.txt_PIN.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(12, 92);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_CustomerNumber
            // 
            this.txt_CustomerNumber.Location = new System.Drawing.Point(12, 25);
            this.txt_CustomerNumber.Name = "txt_CustomerNumber";
            this.txt_CustomerNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_CustomerNumber.TabIndex = 5;
            // 
            // label_CustomerNumber
            // 
            this.label_CustomerNumber.AutoSize = true;
            this.label_CustomerNumber.Location = new System.Drawing.Point(9, 9);
            this.label_CustomerNumber.Name = "label_CustomerNumber";
            this.label_CustomerNumber.Size = new System.Drawing.Size(94, 13);
            this.label_CustomerNumber.TabIndex = 4;
            this.label_CustomerNumber.Text = "Customer Number:";
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(134, 92);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // txt_PIN_2
            // 
            this.txt_PIN_2.Location = new System.Drawing.Point(134, 66);
            this.txt_PIN_2.Name = "txt_PIN_2";
            this.txt_PIN_2.Size = new System.Drawing.Size(100, 20);
            this.txt_PIN_2.TabIndex = 8;
            // 
            // label_PIN_2
            // 
            this.label_PIN_2.AutoSize = true;
            this.label_PIN_2.Location = new System.Drawing.Point(131, 50);
            this.label_PIN_2.Name = "label_PIN_2";
            this.label_PIN_2.Size = new System.Drawing.Size(28, 13);
            this.label_PIN_2.TabIndex = 7;
            this.label_PIN_2.Text = "PIN:";
            // 
            // txt_Checking
            // 
            this.txt_Checking.Location = new System.Drawing.Point(134, 27);
            this.txt_Checking.Name = "txt_Checking";
            this.txt_Checking.Size = new System.Drawing.Size(75, 20);
            this.txt_Checking.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Checking Value";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Savings
            // 
            this.txt_Savings.Location = new System.Drawing.Point(222, 27);
            this.txt_Savings.Name = "txt_Savings";
            this.txt_Savings.Size = new System.Drawing.Size(79, 20);
            this.txt_Savings.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Savings Value";
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 127);
            this.Controls.Add(this.txt_Savings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Checking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_PIN_2);
            this.Controls.Add(this.label_PIN_2);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txt_CustomerNumber);
            this.Controls.Add(this.label_CustomerNumber);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_PIN);
            this.Controls.Add(this.label_PIN);
            this.Name = "frm_login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PIN;
        private System.Windows.Forms.TextBox txt_PIN;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_CustomerNumber;
        private System.Windows.Forms.Label label_CustomerNumber;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.TextBox txt_PIN_2;
        private System.Windows.Forms.Label label_PIN_2;
        private System.Windows.Forms.TextBox txt_Checking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Savings;
        private System.Windows.Forms.Label label2;
    }
}

