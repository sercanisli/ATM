
namespace ATM
{
    partial class Form_Investment
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
            this.lbl_MoneyInAccount = new System.Windows.Forms.Label();
            this.lbl_Money = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.nmUD_Amount = new System.Windows.Forms.NumericUpDown();
            this.btn_Investment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MoneyInAccount
            // 
            this.lbl_MoneyInAccount.AutoSize = true;
            this.lbl_MoneyInAccount.Location = new System.Drawing.Point(12, 53);
            this.lbl_MoneyInAccount.Name = "lbl_MoneyInAccount";
            this.lbl_MoneyInAccount.Size = new System.Drawing.Size(99, 13);
            this.lbl_MoneyInAccount.TabIndex = 1;
            this.lbl_MoneyInAccount.Text = "Money in Acoount :";
            // 
            // lbl_Money
            // 
            this.lbl_Money.AutoSize = true;
            this.lbl_Money.Location = new System.Drawing.Point(209, 53);
            this.lbl_Money.Name = "lbl_Money";
            this.lbl_Money.Size = new System.Drawing.Size(10, 13);
            this.lbl_Money.TabIndex = 2;
            this.lbl_Money.Text = "-";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(62, 111);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(49, 13);
            this.lbl_Amount.TabIndex = 3;
            this.lbl_Amount.Text = "Amount :";
            // 
            // nmUD_Amount
            // 
            this.nmUD_Amount.Location = new System.Drawing.Point(201, 109);
            this.nmUD_Amount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmUD_Amount.Name = "nmUD_Amount";
            this.nmUD_Amount.Size = new System.Drawing.Size(120, 20);
            this.nmUD_Amount.TabIndex = 4;
            // 
            // btn_Investment
            // 
            this.btn_Investment.Location = new System.Drawing.Point(224, 146);
            this.btn_Investment.Name = "btn_Investment";
            this.btn_Investment.Size = new System.Drawing.Size(97, 40);
            this.btn_Investment.TabIndex = 5;
            this.btn_Investment.Text = "INVESTMENT";
            this.btn_Investment.UseVisualStyleBackColor = true;
            this.btn_Investment.Click += new System.EventHandler(this.btn_Investment_Click);
            // 
            // Form_Investment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 198);
            this.Controls.Add(this.btn_Investment);
            this.Controls.Add(this.nmUD_Amount);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.lbl_Money);
            this.Controls.Add(this.lbl_MoneyInAccount);
            this.Name = "Form_Investment";
            this.Text = "Form_Investment";
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MoneyInAccount;
        private System.Windows.Forms.Label lbl_Money;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.NumericUpDown nmUD_Amount;
        private System.Windows.Forms.Button btn_Investment;
    }
}