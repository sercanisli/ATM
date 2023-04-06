
namespace ATM
{
    partial class Form_WithdrawAndDepositMoney
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
            this.btn_WithdrawMoney = new System.Windows.Forms.Button();
            this.btn_Investment = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_WithdrawMoney
            // 
            this.btn_WithdrawMoney.Location = new System.Drawing.Point(12, 130);
            this.btn_WithdrawMoney.Name = "btn_WithdrawMoney";
            this.btn_WithdrawMoney.Size = new System.Drawing.Size(134, 52);
            this.btn_WithdrawMoney.TabIndex = 0;
            this.btn_WithdrawMoney.Text = "Withdraw Money";
            this.btn_WithdrawMoney.UseVisualStyleBackColor = true;
            this.btn_WithdrawMoney.Click += new System.EventHandler(this.btn_WithdrawMoney_Click);
            // 
            // btn_Investment
            // 
            this.btn_Investment.Location = new System.Drawing.Point(262, 130);
            this.btn_Investment.Name = "btn_Investment";
            this.btn_Investment.Size = new System.Drawing.Size(134, 52);
            this.btn_Investment.TabIndex = 1;
            this.btn_Investment.Text = "Investment";
            this.btn_Investment.UseVisualStyleBackColor = true;
            this.btn_Investment.Click += new System.EventHandler(this.btn_Investment_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(134, 52);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Form_WithdrawAndDepositMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 189);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Investment);
            this.Controls.Add(this.btn_WithdrawMoney);
            this.Name = "Form_WithdrawAndDepositMoney";
            this.Text = "Form_WithdrawAndDepositMoney";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_WithdrawMoney;
        private System.Windows.Forms.Button btn_Investment;
        private System.Windows.Forms.Button btn_Back;
    }
}