
namespace ATM
{
    partial class Form_PaymentTransaction
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
            this.btn_Bills = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Bills
            // 
            this.btn_Bills.Location = new System.Drawing.Point(205, 12);
            this.btn_Bills.Name = "btn_Bills";
            this.btn_Bills.Size = new System.Drawing.Size(119, 51);
            this.btn_Bills.TabIndex = 0;
            this.btn_Bills.Text = "Bills";
            this.btn_Bills.UseVisualStyleBackColor = true;
            this.btn_Bills.Click += new System.EventHandler(this.btn_Bills_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(119, 51);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Form_PaymentTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 76);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Bills);
            this.Name = "Form_PaymentTransaction";
            this.Text = "Form_PaymentTransaction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Bills;
        private System.Windows.Forms.Button btn_Back;
    }
}