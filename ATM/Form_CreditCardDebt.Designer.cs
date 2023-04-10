
namespace ATM
{
    partial class Form_CreditCardDebt
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
            this.btn_Pay = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.rdb_PayAll = new System.Windows.Forms.RadioButton();
            this.rdb_MinimumPayment = new System.Windows.Forms.RadioButton();
            this.lbl_CardNo = new System.Windows.Forms.Label();
            this.lbl_CardDebt = new System.Windows.Forms.Label();
            this.lbl_MinimumPaymentAmount = new System.Windows.Forms.Label();
            this.lbl_MoneyInAccount = new System.Windows.Forms.Label();
            this.lbl_No = new System.Windows.Forms.Label();
            this.lbl_Money = new System.Windows.Forms.Label();
            this.lbl_Debt = new System.Windows.Forms.Label();
            this.lbl_MinimumDebt = new System.Windows.Forms.Label();
            this.lbl_RemainderLimit = new System.Windows.Forms.Label();
            this.lbl_Limit = new System.Windows.Forms.Label();
            this.lbl_UseableLimit = new System.Windows.Forms.Label();
            this.lbl_UseLimit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Pay
            // 
            this.btn_Pay.Location = new System.Drawing.Point(299, 181);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(115, 49);
            this.btn_Pay.TabIndex = 0;
            this.btn_Pay.Text = "Pay";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 181);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(115, 49);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // rdb_PayAll
            // 
            this.rdb_PayAll.AutoSize = true;
            this.rdb_PayAll.Location = new System.Drawing.Point(299, 144);
            this.rdb_PayAll.Name = "rdb_PayAll";
            this.rdb_PayAll.Size = new System.Drawing.Size(57, 17);
            this.rdb_PayAll.TabIndex = 2;
            this.rdb_PayAll.TabStop = true;
            this.rdb_PayAll.Text = "Pay All";
            this.rdb_PayAll.UseVisualStyleBackColor = true;
            // 
            // rdb_MinimumPayment
            // 
            this.rdb_MinimumPayment.AutoSize = true;
            this.rdb_MinimumPayment.Location = new System.Drawing.Point(299, 112);
            this.rdb_MinimumPayment.Name = "rdb_MinimumPayment";
            this.rdb_MinimumPayment.Size = new System.Drawing.Size(110, 17);
            this.rdb_MinimumPayment.TabIndex = 3;
            this.rdb_MinimumPayment.TabStop = true;
            this.rdb_MinimumPayment.Text = "Minimum Payment";
            this.rdb_MinimumPayment.UseVisualStyleBackColor = true;
            // 
            // lbl_CardNo
            // 
            this.lbl_CardNo.AutoSize = true;
            this.lbl_CardNo.Location = new System.Drawing.Point(12, 20);
            this.lbl_CardNo.Name = "lbl_CardNo";
            this.lbl_CardNo.Size = new System.Drawing.Size(52, 13);
            this.lbl_CardNo.TabIndex = 5;
            this.lbl_CardNo.Text = "Card No :";
            // 
            // lbl_CardDebt
            // 
            this.lbl_CardDebt.AutoSize = true;
            this.lbl_CardDebt.Location = new System.Drawing.Point(12, 96);
            this.lbl_CardDebt.Name = "lbl_CardDebt";
            this.lbl_CardDebt.Size = new System.Drawing.Size(64, 13);
            this.lbl_CardDebt.TabIndex = 6;
            this.lbl_CardDebt.Text = "Card Debt  :";
            // 
            // lbl_MinimumPaymentAmount
            // 
            this.lbl_MinimumPaymentAmount.AutoSize = true;
            this.lbl_MinimumPaymentAmount.Location = new System.Drawing.Point(12, 134);
            this.lbl_MinimumPaymentAmount.Name = "lbl_MinimumPaymentAmount";
            this.lbl_MinimumPaymentAmount.Size = new System.Drawing.Size(140, 13);
            this.lbl_MinimumPaymentAmount.TabIndex = 7;
            this.lbl_MinimumPaymentAmount.Text = "Minimum Payment Amount  :";
            // 
            // lbl_MoneyInAccount
            // 
            this.lbl_MoneyInAccount.AutoSize = true;
            this.lbl_MoneyInAccount.Location = new System.Drawing.Point(12, 59);
            this.lbl_MoneyInAccount.Name = "lbl_MoneyInAccount";
            this.lbl_MoneyInAccount.Size = new System.Drawing.Size(99, 13);
            this.lbl_MoneyInAccount.TabIndex = 8;
            this.lbl_MoneyInAccount.Text = "Money in Account :";
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Location = new System.Drawing.Point(158, 20);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(10, 13);
            this.lbl_No.TabIndex = 9;
            this.lbl_No.Text = "-";
            // 
            // lbl_Money
            // 
            this.lbl_Money.AutoSize = true;
            this.lbl_Money.Location = new System.Drawing.Point(158, 59);
            this.lbl_Money.Name = "lbl_Money";
            this.lbl_Money.Size = new System.Drawing.Size(10, 13);
            this.lbl_Money.TabIndex = 10;
            this.lbl_Money.Text = "-";
            // 
            // lbl_Debt
            // 
            this.lbl_Debt.AutoSize = true;
            this.lbl_Debt.Location = new System.Drawing.Point(158, 96);
            this.lbl_Debt.Name = "lbl_Debt";
            this.lbl_Debt.Size = new System.Drawing.Size(10, 13);
            this.lbl_Debt.TabIndex = 11;
            this.lbl_Debt.Text = "-";
            // 
            // lbl_MinimumDebt
            // 
            this.lbl_MinimumDebt.AutoSize = true;
            this.lbl_MinimumDebt.Location = new System.Drawing.Point(158, 134);
            this.lbl_MinimumDebt.Name = "lbl_MinimumDebt";
            this.lbl_MinimumDebt.Size = new System.Drawing.Size(10, 13);
            this.lbl_MinimumDebt.TabIndex = 12;
            this.lbl_MinimumDebt.Text = "-";
            // 
            // lbl_RemainderLimit
            // 
            this.lbl_RemainderLimit.AutoSize = true;
            this.lbl_RemainderLimit.Location = new System.Drawing.Point(240, 20);
            this.lbl_RemainderLimit.Name = "lbl_RemainderLimit";
            this.lbl_RemainderLimit.Size = new System.Drawing.Size(88, 13);
            this.lbl_RemainderLimit.TabIndex = 13;
            this.lbl_RemainderLimit.Text = "Remainder Limit :";
            // 
            // lbl_Limit
            // 
            this.lbl_Limit.AutoSize = true;
            this.lbl_Limit.Location = new System.Drawing.Point(346, 20);
            this.lbl_Limit.Name = "lbl_Limit";
            this.lbl_Limit.Size = new System.Drawing.Size(10, 13);
            this.lbl_Limit.TabIndex = 14;
            this.lbl_Limit.Text = "-";
            // 
            // lbl_UseableLimit
            // 
            this.lbl_UseableLimit.AutoSize = true;
            this.lbl_UseableLimit.Location = new System.Drawing.Point(240, 46);
            this.lbl_UseableLimit.Name = "lbl_UseableLimit";
            this.lbl_UseableLimit.Size = new System.Drawing.Size(76, 13);
            this.lbl_UseableLimit.TabIndex = 15;
            this.lbl_UseableLimit.Text = "Useable Limit :";
            // 
            // lbl_UseLimit
            // 
            this.lbl_UseLimit.AutoSize = true;
            this.lbl_UseLimit.Location = new System.Drawing.Point(346, 46);
            this.lbl_UseLimit.Name = "lbl_UseLimit";
            this.lbl_UseLimit.Size = new System.Drawing.Size(10, 13);
            this.lbl_UseLimit.TabIndex = 16;
            this.lbl_UseLimit.Text = "-";
            // 
            // Form_CreditCardDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 242);
            this.Controls.Add(this.lbl_UseLimit);
            this.Controls.Add(this.lbl_UseableLimit);
            this.Controls.Add(this.lbl_Limit);
            this.Controls.Add(this.lbl_RemainderLimit);
            this.Controls.Add(this.lbl_MinimumDebt);
            this.Controls.Add(this.lbl_Debt);
            this.Controls.Add(this.lbl_Money);
            this.Controls.Add(this.lbl_No);
            this.Controls.Add(this.lbl_MoneyInAccount);
            this.Controls.Add(this.lbl_MinimumPaymentAmount);
            this.Controls.Add(this.lbl_CardDebt);
            this.Controls.Add(this.lbl_CardNo);
            this.Controls.Add(this.rdb_MinimumPayment);
            this.Controls.Add(this.rdb_PayAll);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Pay);
            this.Name = "Form_CreditCardDebt";
            this.Text = "Form_CreditCardDebt";
            this.Load += new System.EventHandler(this.Form_CreditCardDebt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.RadioButton rdb_PayAll;
        private System.Windows.Forms.RadioButton rdb_MinimumPayment;
        private System.Windows.Forms.Label lbl_CardNo;
        private System.Windows.Forms.Label lbl_CardDebt;
        private System.Windows.Forms.Label lbl_MinimumPaymentAmount;
        private System.Windows.Forms.Label lbl_MoneyInAccount;
        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.Label lbl_Money;
        private System.Windows.Forms.Label lbl_Debt;
        private System.Windows.Forms.Label lbl_MinimumDebt;
        private System.Windows.Forms.Label lbl_RemainderLimit;
        private System.Windows.Forms.Label lbl_Limit;
        private System.Windows.Forms.Label lbl_UseableLimit;
        private System.Windows.Forms.Label lbl_UseLimit;
    }
}