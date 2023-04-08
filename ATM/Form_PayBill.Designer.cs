
namespace ATM
{
    partial class Form_PayBill
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.lbl_DebtAmount = new System.Windows.Forms.Label();
            this.lbl_Money = new System.Windows.Forms.Label();
            this.lbl_MoneyInAccount = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 94);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(97, 40);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Pay
            // 
            this.btn_Pay.Location = new System.Drawing.Point(207, 96);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(97, 40);
            this.btn_Pay.TabIndex = 11;
            this.btn_Pay.Text = "PAY";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // lbl_DebtAmount
            // 
            this.lbl_DebtAmount.AutoSize = true;
            this.lbl_DebtAmount.Location = new System.Drawing.Point(69, 46);
            this.lbl_DebtAmount.Name = "lbl_DebtAmount";
            this.lbl_DebtAmount.Size = new System.Drawing.Size(75, 13);
            this.lbl_DebtAmount.TabIndex = 9;
            this.lbl_DebtAmount.Text = "Debt Amount :";
            // 
            // lbl_Money
            // 
            this.lbl_Money.AutoSize = true;
            this.lbl_Money.Location = new System.Drawing.Point(213, 9);
            this.lbl_Money.Name = "lbl_Money";
            this.lbl_Money.Size = new System.Drawing.Size(10, 13);
            this.lbl_Money.TabIndex = 8;
            this.lbl_Money.Text = "-";
            // 
            // lbl_MoneyInAccount
            // 
            this.lbl_MoneyInAccount.AutoSize = true;
            this.lbl_MoneyInAccount.Location = new System.Drawing.Point(45, 9);
            this.lbl_MoneyInAccount.Name = "lbl_MoneyInAccount";
            this.lbl_MoneyInAccount.Size = new System.Drawing.Size(99, 13);
            this.lbl_MoneyInAccount.TabIndex = 7;
            this.lbl_MoneyInAccount.Text = "Money in Acoount :";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(213, 46);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(10, 13);
            this.lbl_Amount.TabIndex = 13;
            this.lbl_Amount.Text = "-";
            // 
            // Form_PayBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 148);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.lbl_DebtAmount);
            this.Controls.Add(this.lbl_Money);
            this.Controls.Add(this.lbl_MoneyInAccount);
            this.Name = "Form_PayBill";
            this.Text = "Form_PayBill";
            this.Load += new System.EventHandler(this.Form_PayBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Label lbl_DebtAmount;
        private System.Windows.Forms.Label lbl_Money;
        private System.Windows.Forms.Label lbl_MoneyInAccount;
        private System.Windows.Forms.Label lbl_Amount;
    }
}