
namespace ATM
{
    partial class Form_NotOurCustomer
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
            this.nmUD_Money = new System.Windows.Forms.NumericUpDown();
            this.tbx_CustomerNo = new System.Windows.Forms.TextBox();
            this.lbl_Transfer = new System.Windows.Forms.Label();
            this.lbl_CustomerNo = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.lbl_MoneyInAccount = new System.Windows.Forms.Label();
            this.lbl_Money = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_Money)).BeginInit();
            this.SuspendLayout();
            // 
            // nmUD_Money
            // 
            this.nmUD_Money.Location = new System.Drawing.Point(168, 87);
            this.nmUD_Money.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmUD_Money.Name = "nmUD_Money";
            this.nmUD_Money.Size = new System.Drawing.Size(120, 20);
            this.nmUD_Money.TabIndex = 13;
            // 
            // tbx_CustomerNo
            // 
            this.tbx_CustomerNo.Location = new System.Drawing.Point(168, 49);
            this.tbx_CustomerNo.Name = "tbx_CustomerNo";
            this.tbx_CustomerNo.Size = new System.Drawing.Size(120, 20);
            this.tbx_CustomerNo.TabIndex = 12;
            // 
            // lbl_Transfer
            // 
            this.lbl_Transfer.AutoSize = true;
            this.lbl_Transfer.Location = new System.Drawing.Point(12, 89);
            this.lbl_Transfer.Name = "lbl_Transfer";
            this.lbl_Transfer.Size = new System.Drawing.Size(133, 13);
            this.lbl_Transfer.TabIndex = 11;
            this.lbl_Transfer.Text = "Amount to be Transferred :";
            // 
            // lbl_CustomerNo
            // 
            this.lbl_CustomerNo.AutoSize = true;
            this.lbl_CustomerNo.Location = new System.Drawing.Point(12, 52);
            this.lbl_CustomerNo.Name = "lbl_CustomerNo";
            this.lbl_CustomerNo.Size = new System.Drawing.Size(74, 13);
            this.lbl_CustomerNo.TabIndex = 10;
            this.lbl_CustomerNo.Text = "Customer No :";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 119);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(101, 40);
            this.btn_Back.TabIndex = 9;
            this.btn_Back.Text = "BACK";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.Location = new System.Drawing.Point(204, 119);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(101, 40);
            this.btn_Transfer.TabIndex = 8;
            this.btn_Transfer.Text = "TRANSFER";
            this.btn_Transfer.UseVisualStyleBackColor = true;
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // lbl_MoneyInAccount
            // 
            this.lbl_MoneyInAccount.AutoSize = true;
            this.lbl_MoneyInAccount.Location = new System.Drawing.Point(12, 19);
            this.lbl_MoneyInAccount.Name = "lbl_MoneyInAccount";
            this.lbl_MoneyInAccount.Size = new System.Drawing.Size(99, 13);
            this.lbl_MoneyInAccount.TabIndex = 14;
            this.lbl_MoneyInAccount.Text = "Money in Account :";
            // 
            // lbl_Money
            // 
            this.lbl_Money.AutoSize = true;
            this.lbl_Money.Location = new System.Drawing.Point(165, 19);
            this.lbl_Money.Name = "lbl_Money";
            this.lbl_Money.Size = new System.Drawing.Size(10, 13);
            this.lbl_Money.TabIndex = 15;
            this.lbl_Money.Text = "-";
            // 
            // Form_NotOurCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 171);
            this.Controls.Add(this.lbl_Money);
            this.Controls.Add(this.lbl_MoneyInAccount);
            this.Controls.Add(this.nmUD_Money);
            this.Controls.Add(this.tbx_CustomerNo);
            this.Controls.Add(this.lbl_Transfer);
            this.Controls.Add(this.lbl_CustomerNo);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Transfer);
            this.Name = "Form_NotOurCustomer";
            this.Text = "Form_NotOurCustomer";
            this.Load += new System.EventHandler(this.Form_NotOurCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_Money)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmUD_Money;
        private System.Windows.Forms.TextBox tbx_CustomerNo;
        private System.Windows.Forms.Label lbl_Transfer;
        private System.Windows.Forms.Label lbl_CustomerNo;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Transfer;
        private System.Windows.Forms.Label lbl_MoneyInAccount;
        private System.Windows.Forms.Label lbl_Money;
    }
}