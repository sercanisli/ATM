
namespace ATM
{
    partial class Form_WithdrawMoney
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
            this.btn_Draw = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MoneyInAccount
            // 
            this.lbl_MoneyInAccount.AutoSize = true;
            this.lbl_MoneyInAccount.Location = new System.Drawing.Point(12, 40);
            this.lbl_MoneyInAccount.Name = "lbl_MoneyInAccount";
            this.lbl_MoneyInAccount.Size = new System.Drawing.Size(99, 13);
            this.lbl_MoneyInAccount.TabIndex = 0;
            this.lbl_MoneyInAccount.Text = "Money in Acoount :";
            // 
            // lbl_Money
            // 
            this.lbl_Money.AutoSize = true;
            this.lbl_Money.Location = new System.Drawing.Point(216, 40);
            this.lbl_Money.Name = "lbl_Money";
            this.lbl_Money.Size = new System.Drawing.Size(10, 13);
            this.lbl_Money.TabIndex = 1;
            this.lbl_Money.Text = "-";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(62, 112);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(49, 13);
            this.lbl_Amount.TabIndex = 2;
            this.lbl_Amount.Text = "Amount :";
            // 
            // nmUD_Amount
            // 
            this.nmUD_Amount.Location = new System.Drawing.Point(205, 110);
            this.nmUD_Amount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmUD_Amount.Name = "nmUD_Amount";
            this.nmUD_Amount.Size = new System.Drawing.Size(120, 20);
            this.nmUD_Amount.TabIndex = 3;
            // 
            // btn_Draw
            // 
            this.btn_Draw.Location = new System.Drawing.Point(228, 150);
            this.btn_Draw.Name = "btn_Draw";
            this.btn_Draw.Size = new System.Drawing.Size(97, 40);
            this.btn_Draw.TabIndex = 4;
            this.btn_Draw.Text = "DRAW";
            this.btn_Draw.UseVisualStyleBackColor = true;
            this.btn_Draw.Click += new System.EventHandler(this.btn_Draw_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 150);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(97, 40);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Form_WithdrawMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 198);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Draw);
            this.Controls.Add(this.nmUD_Amount);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.lbl_Money);
            this.Controls.Add(this.lbl_MoneyInAccount);
            this.Name = "Form_WithdrawMoney";
            this.Text = "Form_WithdrawMoney";
            this.Load += new System.EventHandler(this.Form_WithdrawMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MoneyInAccount;
        private System.Windows.Forms.Label lbl_Money;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.NumericUpDown nmUD_Amount;
        private System.Windows.Forms.Button btn_Draw;
        private System.Windows.Forms.Button btn_Back;
    }
}