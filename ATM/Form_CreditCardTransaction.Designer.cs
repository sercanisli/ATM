
namespace ATM
{
    partial class Form_CreditCardTransaction
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
            this.btn_CreditCardApplication = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_CreditCardDebt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CreditCardApplication
            // 
            this.btn_CreditCardApplication.Location = new System.Drawing.Point(171, 12);
            this.btn_CreditCardApplication.Name = "btn_CreditCardApplication";
            this.btn_CreditCardApplication.Size = new System.Drawing.Size(120, 50);
            this.btn_CreditCardApplication.TabIndex = 0;
            this.btn_CreditCardApplication.Text = "Credit Card Application";
            this.btn_CreditCardApplication.UseVisualStyleBackColor = true;
            this.btn_CreditCardApplication.Click += new System.EventHandler(this.btn_CreditCardApplication_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 100);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(120, 50);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_CreditCardDebt
            // 
            this.btn_CreditCardDebt.Location = new System.Drawing.Point(171, 100);
            this.btn_CreditCardDebt.Name = "btn_CreditCardDebt";
            this.btn_CreditCardDebt.Size = new System.Drawing.Size(120, 50);
            this.btn_CreditCardDebt.TabIndex = 2;
            this.btn_CreditCardDebt.Text = "Credit Card Debt";
            this.btn_CreditCardDebt.UseVisualStyleBackColor = true;
            this.btn_CreditCardDebt.Click += new System.EventHandler(this.btn_CreditCardDebt_Click);
            // 
            // Form_CreditCardTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 162);
            this.Controls.Add(this.btn_CreditCardDebt);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_CreditCardApplication);
            this.Name = "Form_CreditCardTransaction";
            this.Text = "Form_CreditCardTransaction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CreditCardApplication;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_CreditCardDebt;
    }
}