
namespace ATM
{
    partial class Form_Without_Card
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
            this.btn_WithoutCard_MoneyTransfers = new System.Windows.Forms.Button();
            this.btn_WithoutCard_ApplicationProcedures = new System.Windows.Forms.Button();
            this.btn_WithoutCard_PaymentTransaction = new System.Windows.Forms.Button();
            this.btn_WithoutCard_CreditCardDebtPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_WithoutCard_MoneyTransfers
            // 
            this.btn_WithoutCard_MoneyTransfers.Location = new System.Drawing.Point(12, 173);
            this.btn_WithoutCard_MoneyTransfers.Name = "btn_WithoutCard_MoneyTransfers";
            this.btn_WithoutCard_MoneyTransfers.Size = new System.Drawing.Size(141, 53);
            this.btn_WithoutCard_MoneyTransfers.TabIndex = 2;
            this.btn_WithoutCard_MoneyTransfers.Text = "Money Transfers";
            this.btn_WithoutCard_MoneyTransfers.UseVisualStyleBackColor = true;
            // 
            // btn_WithoutCard_ApplicationProcedures
            // 
            this.btn_WithoutCard_ApplicationProcedures.Location = new System.Drawing.Point(387, 173);
            this.btn_WithoutCard_ApplicationProcedures.Name = "btn_WithoutCard_ApplicationProcedures";
            this.btn_WithoutCard_ApplicationProcedures.Size = new System.Drawing.Size(141, 53);
            this.btn_WithoutCard_ApplicationProcedures.TabIndex = 3;
            this.btn_WithoutCard_ApplicationProcedures.Text = "Application Procedures";
            this.btn_WithoutCard_ApplicationProcedures.UseVisualStyleBackColor = true;
            // 
            // btn_WithoutCard_PaymentTransaction
            // 
            this.btn_WithoutCard_PaymentTransaction.Location = new System.Drawing.Point(12, 59);
            this.btn_WithoutCard_PaymentTransaction.Name = "btn_WithoutCard_PaymentTransaction";
            this.btn_WithoutCard_PaymentTransaction.Size = new System.Drawing.Size(141, 53);
            this.btn_WithoutCard_PaymentTransaction.TabIndex = 6;
            this.btn_WithoutCard_PaymentTransaction.Text = "Payment Transaction";
            this.btn_WithoutCard_PaymentTransaction.UseVisualStyleBackColor = true;
            // 
            // btn_WithoutCard_CreditCardDebtPayment
            // 
            this.btn_WithoutCard_CreditCardDebtPayment.Location = new System.Drawing.Point(387, 59);
            this.btn_WithoutCard_CreditCardDebtPayment.Name = "btn_WithoutCard_CreditCardDebtPayment";
            this.btn_WithoutCard_CreditCardDebtPayment.Size = new System.Drawing.Size(141, 53);
            this.btn_WithoutCard_CreditCardDebtPayment.TabIndex = 7;
            this.btn_WithoutCard_CreditCardDebtPayment.Text = "Credit Card Debt Payment ";
            this.btn_WithoutCard_CreditCardDebtPayment.UseVisualStyleBackColor = true;
            // 
            // Form_Without_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 298);
            this.Controls.Add(this.btn_WithoutCard_CreditCardDebtPayment);
            this.Controls.Add(this.btn_WithoutCard_PaymentTransaction);
            this.Controls.Add(this.btn_WithoutCard_ApplicationProcedures);
            this.Controls.Add(this.btn_WithoutCard_MoneyTransfers);
            this.Name = "Form_Without_Card";
            this.Text = "Form_Without_Card";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_WithoutCard_MoneyTransfers;
        private System.Windows.Forms.Button btn_WithoutCard_ApplicationProcedures;
        private System.Windows.Forms.Button btn_WithoutCard_PaymentTransaction;
        private System.Windows.Forms.Button btn_WithoutCard_CreditCardDebtPayment;
    }
}