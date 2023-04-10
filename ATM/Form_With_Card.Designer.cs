
namespace ATM
{
    partial class Form_With_Card
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
            this.btn_WithCard_WithdrawMoney = new System.Windows.Forms.Button();
            this.btn_WithCard_MoneyTransfers = new System.Windows.Forms.Button();
            this.btn_WithCard_ApplicationProcedures = new System.Windows.Forms.Button();
            this.btn_BalanceInformaion = new System.Windows.Forms.Button();
            this.btn_WithCard_CreditCardDebtPayment = new System.Windows.Forms.Button();
            this.btn_PaymentTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_WithCard_WithdrawMoney
            // 
            this.btn_WithCard_WithdrawMoney.Location = new System.Drawing.Point(12, 45);
            this.btn_WithCard_WithdrawMoney.Name = "btn_WithCard_WithdrawMoney";
            this.btn_WithCard_WithdrawMoney.Size = new System.Drawing.Size(141, 53);
            this.btn_WithCard_WithdrawMoney.TabIndex = 0;
            this.btn_WithCard_WithdrawMoney.Text = "Withdraw / Deposit Money";
            this.btn_WithCard_WithdrawMoney.UseVisualStyleBackColor = true;
            this.btn_WithCard_WithdrawMoney.Click += new System.EventHandler(this.btn_WithCard_WithdrawMoney_Click);
            // 
            // btn_WithCard_MoneyTransfers
            // 
            this.btn_WithCard_MoneyTransfers.Location = new System.Drawing.Point(12, 152);
            this.btn_WithCard_MoneyTransfers.Name = "btn_WithCard_MoneyTransfers";
            this.btn_WithCard_MoneyTransfers.Size = new System.Drawing.Size(141, 53);
            this.btn_WithCard_MoneyTransfers.TabIndex = 1;
            this.btn_WithCard_MoneyTransfers.Text = "Money Transfers";
            this.btn_WithCard_MoneyTransfers.UseVisualStyleBackColor = true;
            this.btn_WithCard_MoneyTransfers.Click += new System.EventHandler(this.btn_WithCard_MoneyTransfers_Click);
            // 
            // btn_WithCard_ApplicationProcedures
            // 
            this.btn_WithCard_ApplicationProcedures.Location = new System.Drawing.Point(12, 259);
            this.btn_WithCard_ApplicationProcedures.Name = "btn_WithCard_ApplicationProcedures";
            this.btn_WithCard_ApplicationProcedures.Size = new System.Drawing.Size(141, 53);
            this.btn_WithCard_ApplicationProcedures.TabIndex = 2;
            this.btn_WithCard_ApplicationProcedures.Text = "Application Procedures";
            this.btn_WithCard_ApplicationProcedures.UseVisualStyleBackColor = true;
            // 
            // btn_BalanceInformaion
            // 
            this.btn_BalanceInformaion.Location = new System.Drawing.Point(520, 45);
            this.btn_BalanceInformaion.Name = "btn_BalanceInformaion";
            this.btn_BalanceInformaion.Size = new System.Drawing.Size(141, 53);
            this.btn_BalanceInformaion.TabIndex = 3;
            this.btn_BalanceInformaion.Text = "Balance Information";
            this.btn_BalanceInformaion.UseVisualStyleBackColor = true;
            this.btn_BalanceInformaion.Click += new System.EventHandler(this.btn_BalanceInformaion_Click);
            // 
            // btn_WithCard_CreditCardDebtPayment
            // 
            this.btn_WithCard_CreditCardDebtPayment.Location = new System.Drawing.Point(520, 259);
            this.btn_WithCard_CreditCardDebtPayment.Name = "btn_WithCard_CreditCardDebtPayment";
            this.btn_WithCard_CreditCardDebtPayment.Size = new System.Drawing.Size(141, 53);
            this.btn_WithCard_CreditCardDebtPayment.TabIndex = 4;
            this.btn_WithCard_CreditCardDebtPayment.Text = "Credit Card Transactions";
            this.btn_WithCard_CreditCardDebtPayment.UseVisualStyleBackColor = true;
            this.btn_WithCard_CreditCardDebtPayment.Click += new System.EventHandler(this.btn_WithCard_CreditCardDebtPayment_Click);
            // 
            // btn_PaymentTransaction
            // 
            this.btn_PaymentTransaction.Location = new System.Drawing.Point(520, 152);
            this.btn_PaymentTransaction.Name = "btn_PaymentTransaction";
            this.btn_PaymentTransaction.Size = new System.Drawing.Size(141, 53);
            this.btn_PaymentTransaction.TabIndex = 5;
            this.btn_PaymentTransaction.Text = "Payment Transaction";
            this.btn_PaymentTransaction.UseVisualStyleBackColor = true;
            this.btn_PaymentTransaction.Click += new System.EventHandler(this.btn_PaymentTransaction_Click);
            // 
            // Form_With_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 342);
            this.Controls.Add(this.btn_PaymentTransaction);
            this.Controls.Add(this.btn_WithCard_CreditCardDebtPayment);
            this.Controls.Add(this.btn_BalanceInformaion);
            this.Controls.Add(this.btn_WithCard_ApplicationProcedures);
            this.Controls.Add(this.btn_WithCard_MoneyTransfers);
            this.Controls.Add(this.btn_WithCard_WithdrawMoney);
            this.Name = "Form_With_Card";
            this.Text = "Process";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_WithCard_WithdrawMoney;
        private System.Windows.Forms.Button btn_WithCard_MoneyTransfers;
        private System.Windows.Forms.Button btn_WithCard_ApplicationProcedures;
        private System.Windows.Forms.Button btn_BalanceInformaion;
        private System.Windows.Forms.Button btn_WithCard_CreditCardDebtPayment;
        private System.Windows.Forms.Button btn_PaymentTransaction;
    }
}