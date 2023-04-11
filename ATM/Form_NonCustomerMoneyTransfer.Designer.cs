
namespace ATM
{
    partial class Form_NonCustomerMoneyTransfer
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
            this.lbl_Sender = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_PhoneNo = new System.Windows.Forms.Label();
            this.lbl_IdentityNo = new System.Windows.Forms.Label();
            this.lbl_AccountToSend = new System.Windows.Forms.Label();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.tbx_Surname = new System.Windows.Forms.TextBox();
            this.tbx_PhoneNo = new System.Windows.Forms.TextBox();
            this.tbx_IdentityNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_Money)).BeginInit();
            this.SuspendLayout();
            // 
            // nmUD_Money
            // 
            this.nmUD_Money.Location = new System.Drawing.Point(179, 87);
            this.nmUD_Money.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmUD_Money.Name = "nmUD_Money";
            this.nmUD_Money.Size = new System.Drawing.Size(120, 20);
            this.nmUD_Money.TabIndex = 15;
            // 
            // tbx_CustomerNo
            // 
            this.tbx_CustomerNo.Location = new System.Drawing.Point(179, 48);
            this.tbx_CustomerNo.Name = "tbx_CustomerNo";
            this.tbx_CustomerNo.Size = new System.Drawing.Size(120, 20);
            this.tbx_CustomerNo.TabIndex = 14;
            // 
            // lbl_Transfer
            // 
            this.lbl_Transfer.AutoSize = true;
            this.lbl_Transfer.Location = new System.Drawing.Point(26, 89);
            this.lbl_Transfer.Name = "lbl_Transfer";
            this.lbl_Transfer.Size = new System.Drawing.Size(133, 13);
            this.lbl_Transfer.TabIndex = 13;
            this.lbl_Transfer.Text = "Amount to be Transferred :";
            // 
            // lbl_CustomerNo
            // 
            this.lbl_CustomerNo.AutoSize = true;
            this.lbl_CustomerNo.Location = new System.Drawing.Point(26, 51);
            this.lbl_CustomerNo.Name = "lbl_CustomerNo";
            this.lbl_CustomerNo.Size = new System.Drawing.Size(74, 13);
            this.lbl_CustomerNo.TabIndex = 12;
            this.lbl_CustomerNo.Text = "Customer No :";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(27, 308);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(101, 40);
            this.btn_Back.TabIndex = 11;
            this.btn_Back.Text = "BACK";
            this.btn_Back.UseVisualStyleBackColor = true;
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.Location = new System.Drawing.Point(198, 308);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(101, 40);
            this.btn_Transfer.TabIndex = 10;
            this.btn_Transfer.Text = "TRANSFER";
            this.btn_Transfer.UseVisualStyleBackColor = true;
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // lbl_Sender
            // 
            this.lbl_Sender.AutoSize = true;
            this.lbl_Sender.Location = new System.Drawing.Point(133, 128);
            this.lbl_Sender.Name = "lbl_Sender";
            this.lbl_Sender.Size = new System.Drawing.Size(41, 13);
            this.lbl_Sender.TabIndex = 16;
            this.lbl_Sender.Text = "Sender";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(24, 167);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(41, 13);
            this.lbl_Name.TabIndex = 17;
            this.lbl_Name.Text = "Name :";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(24, 197);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(55, 13);
            this.lbl_Surname.TabIndex = 18;
            this.lbl_Surname.Text = "Surname :";
            // 
            // lbl_PhoneNo
            // 
            this.lbl_PhoneNo.AutoSize = true;
            this.lbl_PhoneNo.Location = new System.Drawing.Point(24, 229);
            this.lbl_PhoneNo.Name = "lbl_PhoneNo";
            this.lbl_PhoneNo.Size = new System.Drawing.Size(84, 13);
            this.lbl_PhoneNo.TabIndex = 19;
            this.lbl_PhoneNo.Text = "Phone Number :";
            // 
            // lbl_IdentityNo
            // 
            this.lbl_IdentityNo.AutoSize = true;
            this.lbl_IdentityNo.Location = new System.Drawing.Point(26, 261);
            this.lbl_IdentityNo.Name = "lbl_IdentityNo";
            this.lbl_IdentityNo.Size = new System.Drawing.Size(64, 13);
            this.lbl_IdentityNo.TabIndex = 20;
            this.lbl_IdentityNo.Text = "Identity No :";
            // 
            // lbl_AccountToSend
            // 
            this.lbl_AccountToSend.AutoSize = true;
            this.lbl_AccountToSend.Location = new System.Drawing.Point(107, 9);
            this.lbl_AccountToSend.Name = "lbl_AccountToSend";
            this.lbl_AccountToSend.Size = new System.Drawing.Size(91, 13);
            this.lbl_AccountToSend.TabIndex = 21;
            this.lbl_AccountToSend.Text = "Acoount To Send";
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(179, 160);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(120, 20);
            this.tbx_Name.TabIndex = 22;
            // 
            // tbx_Surname
            // 
            this.tbx_Surname.Location = new System.Drawing.Point(179, 190);
            this.tbx_Surname.Name = "tbx_Surname";
            this.tbx_Surname.Size = new System.Drawing.Size(120, 20);
            this.tbx_Surname.TabIndex = 23;
            // 
            // tbx_PhoneNo
            // 
            this.tbx_PhoneNo.Location = new System.Drawing.Point(179, 222);
            this.tbx_PhoneNo.Name = "tbx_PhoneNo";
            this.tbx_PhoneNo.Size = new System.Drawing.Size(120, 20);
            this.tbx_PhoneNo.TabIndex = 24;
            // 
            // tbx_IdentityNo
            // 
            this.tbx_IdentityNo.Location = new System.Drawing.Point(179, 254);
            this.tbx_IdentityNo.Name = "tbx_IdentityNo";
            this.tbx_IdentityNo.Size = new System.Drawing.Size(120, 20);
            this.tbx_IdentityNo.TabIndex = 25;
            // 
            // Form_NonCustomerMoneyTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 360);
            this.Controls.Add(this.tbx_IdentityNo);
            this.Controls.Add(this.tbx_PhoneNo);
            this.Controls.Add(this.tbx_Surname);
            this.Controls.Add(this.tbx_Name);
            this.Controls.Add(this.lbl_AccountToSend);
            this.Controls.Add(this.lbl_IdentityNo);
            this.Controls.Add(this.lbl_PhoneNo);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Sender);
            this.Controls.Add(this.nmUD_Money);
            this.Controls.Add(this.tbx_CustomerNo);
            this.Controls.Add(this.lbl_Transfer);
            this.Controls.Add(this.lbl_CustomerNo);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Transfer);
            this.Name = "Form_NonCustomerMoneyTransfer";
            this.Text = "Form_NonCustomerMoneyTransfer";
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
        private System.Windows.Forms.Label lbl_Sender;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_PhoneNo;
        private System.Windows.Forms.Label lbl_IdentityNo;
        private System.Windows.Forms.Label lbl_AccountToSend;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.TextBox tbx_Surname;
        private System.Windows.Forms.TextBox tbx_PhoneNo;
        private System.Windows.Forms.TextBox tbx_IdentityNo;
    }
}