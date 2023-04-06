
namespace ATM
{
    partial class Form_MoneyTransfer
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
            this.btn_OurCustomer = new System.Windows.Forms.Button();
            this.btn_NotOurCustomer = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_OurCustomer
            // 
            this.btn_OurCustomer.Location = new System.Drawing.Point(246, 121);
            this.btn_OurCustomer.Name = "btn_OurCustomer";
            this.btn_OurCustomer.Size = new System.Drawing.Size(112, 51);
            this.btn_OurCustomer.TabIndex = 0;
            this.btn_OurCustomer.Text = "Our Customer";
            this.btn_OurCustomer.UseVisualStyleBackColor = true;
            this.btn_OurCustomer.Click += new System.EventHandler(this.btn_OurCustomer_Click);
            // 
            // btn_NotOurCustomer
            // 
            this.btn_NotOurCustomer.Location = new System.Drawing.Point(12, 121);
            this.btn_NotOurCustomer.Name = "btn_NotOurCustomer";
            this.btn_NotOurCustomer.Size = new System.Drawing.Size(112, 51);
            this.btn_NotOurCustomer.TabIndex = 1;
            this.btn_NotOurCustomer.Text = "Not Our Customer";
            this.btn_NotOurCustomer.UseVisualStyleBackColor = true;
            this.btn_NotOurCustomer.Click += new System.EventHandler(this.btn_NotOurCustomer_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(112, 51);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Form_MoneyTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 183);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_NotOurCustomer);
            this.Controls.Add(this.btn_OurCustomer);
            this.Name = "Form_MoneyTransfer";
            this.Text = "Form_MoneyTransfer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OurCustomer;
        private System.Windows.Forms.Button btn_NotOurCustomer;
        private System.Windows.Forms.Button btn_Back;
    }
}