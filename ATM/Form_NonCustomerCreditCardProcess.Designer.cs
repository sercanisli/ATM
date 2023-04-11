
namespace ATM
{
    partial class Form_NonCustomerCreditCardProcess
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
            this.lbl_CardNo = new System.Windows.Forms.Label();
            this.tbx_CardNo = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_GetCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_CardNo
            // 
            this.lbl_CardNo.AutoSize = true;
            this.lbl_CardNo.Location = new System.Drawing.Point(12, 20);
            this.lbl_CardNo.Name = "lbl_CardNo";
            this.lbl_CardNo.Size = new System.Drawing.Size(52, 13);
            this.lbl_CardNo.TabIndex = 0;
            this.lbl_CardNo.Text = "Card No :";
            // 
            // tbx_CardNo
            // 
            this.tbx_CardNo.Location = new System.Drawing.Point(109, 17);
            this.tbx_CardNo.Name = "tbx_CardNo";
            this.tbx_CardNo.Size = new System.Drawing.Size(142, 20);
            this.tbx_CardNo.TabIndex = 1;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 54);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(95, 42);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_GetCard
            // 
            this.btn_GetCard.Location = new System.Drawing.Point(153, 54);
            this.btn_GetCard.Name = "btn_GetCard";
            this.btn_GetCard.Size = new System.Drawing.Size(98, 42);
            this.btn_GetCard.TabIndex = 5;
            this.btn_GetCard.Text = "Get Card";
            this.btn_GetCard.UseVisualStyleBackColor = true;
            this.btn_GetCard.Click += new System.EventHandler(this.btn_GetCard_Click);
            // 
            // Form_NonCustomerCreditCardProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 109);
            this.Controls.Add(this.btn_GetCard);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.tbx_CardNo);
            this.Controls.Add(this.lbl_CardNo);
            this.Name = "Form_NonCustomerCreditCardProcess";
            this.Text = "Form_NonCustomerCreditCardProcess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CardNo;
        private System.Windows.Forms.TextBox tbx_CardNo;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_GetCard;
    }
}