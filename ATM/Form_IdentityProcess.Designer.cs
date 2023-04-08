
namespace ATM
{
    partial class Form_IdentityProcess
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
            this.btn_GoWithCards = new System.Windows.Forms.Button();
            this.lbl_CustomerNo = new System.Windows.Forms.Label();
            this.tbx_CustomerNo = new System.Windows.Forms.TextBox();
            this.lbl_CustomerPassword = new System.Windows.Forms.Label();
            this.tbx_CustomerPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_GoWithCards
            // 
            this.btn_GoWithCards.Location = new System.Drawing.Point(157, 91);
            this.btn_GoWithCards.Name = "btn_GoWithCards";
            this.btn_GoWithCards.Size = new System.Drawing.Size(103, 36);
            this.btn_GoWithCards.TabIndex = 0;
            this.btn_GoWithCards.Text = "Entry";
            this.btn_GoWithCards.UseVisualStyleBackColor = true;
            this.btn_GoWithCards.Click += new System.EventHandler(this.btn_GoWithCards_Click);
            // 
            // lbl_CustomerNo
            // 
            this.lbl_CustomerNo.AutoSize = true;
            this.lbl_CustomerNo.Location = new System.Drawing.Point(12, 19);
            this.lbl_CustomerNo.Name = "lbl_CustomerNo";
            this.lbl_CustomerNo.Size = new System.Drawing.Size(74, 13);
            this.lbl_CustomerNo.TabIndex = 1;
            this.lbl_CustomerNo.Text = "Customer No :";
            // 
            // tbx_CustomerNo
            // 
            this.tbx_CustomerNo.Location = new System.Drawing.Point(122, 16);
            this.tbx_CustomerNo.Name = "tbx_CustomerNo";
            this.tbx_CustomerNo.Size = new System.Drawing.Size(138, 20);
            this.tbx_CustomerNo.TabIndex = 2;
            this.tbx_CustomerNo.Text = "77391";
            // 
            // lbl_CustomerPassword
            // 
            this.lbl_CustomerPassword.AutoSize = true;
            this.lbl_CustomerPassword.Location = new System.Drawing.Point(12, 54);
            this.lbl_CustomerPassword.Name = "lbl_CustomerPassword";
            this.lbl_CustomerPassword.Size = new System.Drawing.Size(106, 13);
            this.lbl_CustomerPassword.TabIndex = 3;
            this.lbl_CustomerPassword.Text = "Customer Password :";
            // 
            // tbx_CustomerPassword
            // 
            this.tbx_CustomerPassword.Location = new System.Drawing.Point(122, 51);
            this.tbx_CustomerPassword.Name = "tbx_CustomerPassword";
            this.tbx_CustomerPassword.Size = new System.Drawing.Size(138, 20);
            this.tbx_CustomerPassword.TabIndex = 4;
            this.tbx_CustomerPassword.Text = "asd123";
            // 
            // Form_IdentityProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 132);
            this.Controls.Add(this.tbx_CustomerPassword);
            this.Controls.Add(this.lbl_CustomerPassword);
            this.Controls.Add(this.tbx_CustomerNo);
            this.Controls.Add(this.lbl_CustomerNo);
            this.Controls.Add(this.btn_GoWithCards);
            this.Name = "Form_IdentityProcess";
            this.Text = "Form_IdentityProcess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GoWithCards;
        private System.Windows.Forms.Label lbl_CustomerNo;
        private System.Windows.Forms.TextBox tbx_CustomerNo;
        private System.Windows.Forms.Label lbl_CustomerPassword;
        private System.Windows.Forms.TextBox tbx_CustomerPassword;
    }
}