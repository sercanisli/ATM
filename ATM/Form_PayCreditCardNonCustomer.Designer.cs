
namespace ATM
{
    partial class Form_PayCreditCardNonCustomer
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
            this.lbl_CardNo = new System.Windows.Forms.Label();
            this.lbl_CardDebt = new System.Windows.Forms.Label();
            this.lbl_No = new System.Windows.Forms.Label();
            this.lbl_Debt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Pay
            // 
            this.btn_Pay.Location = new System.Drawing.Point(145, 84);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(92, 43);
            this.btn_Pay.TabIndex = 0;
            this.btn_Pay.Text = "Pay";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 84);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(92, 43);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_CardNo
            // 
            this.lbl_CardNo.AutoSize = true;
            this.lbl_CardNo.Location = new System.Drawing.Point(52, 19);
            this.lbl_CardNo.Name = "lbl_CardNo";
            this.lbl_CardNo.Size = new System.Drawing.Size(52, 13);
            this.lbl_CardNo.TabIndex = 2;
            this.lbl_CardNo.Text = "Card No :";
            // 
            // lbl_CardDebt
            // 
            this.lbl_CardDebt.AutoSize = true;
            this.lbl_CardDebt.Location = new System.Drawing.Point(52, 49);
            this.lbl_CardDebt.Name = "lbl_CardDebt";
            this.lbl_CardDebt.Size = new System.Drawing.Size(61, 13);
            this.lbl_CardDebt.TabIndex = 3;
            this.lbl_CardDebt.Text = "Card Debt :";
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Location = new System.Drawing.Point(142, 19);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(10, 13);
            this.lbl_No.TabIndex = 4;
            this.lbl_No.Text = "-";
            // 
            // lbl_Debt
            // 
            this.lbl_Debt.AutoSize = true;
            this.lbl_Debt.Location = new System.Drawing.Point(142, 49);
            this.lbl_Debt.Name = "lbl_Debt";
            this.lbl_Debt.Size = new System.Drawing.Size(10, 13);
            this.lbl_Debt.TabIndex = 5;
            this.lbl_Debt.Text = "-";
            // 
            // Form_PayCreditCardNonCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 133);
            this.Controls.Add(this.lbl_Debt);
            this.Controls.Add(this.lbl_No);
            this.Controls.Add(this.lbl_CardDebt);
            this.Controls.Add(this.lbl_CardNo);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Pay);
            this.Name = "Form_PayCreditCardNonCustomer";
            this.Text = "Form_PayCreditCardNonCustomer";
            this.Load += new System.EventHandler(this.Form_PayCreditCardNonCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_CardNo;
        private System.Windows.Forms.Label lbl_CardDebt;
        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.Label lbl_Debt;
    }
}