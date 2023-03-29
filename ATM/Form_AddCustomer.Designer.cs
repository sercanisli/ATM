
namespace ATM
{
    partial class Form_AddCustomer
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_PasswordAgain = new System.Windows.Forms.Label();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.tbx_Surname = new System.Windows.Forms.TextBox();
            this.tbx_PhoneNo = new System.Windows.Forms.TextBox();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.tbx_Password = new System.Windows.Forms.TextBox();
            this.tbx_PasswordAgain = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dtp_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lbl_DateOfBirth = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.cbx_Gender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(12, 24);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(41, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name :";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(12, 56);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(55, 13);
            this.lbl_Surname.TabIndex = 1;
            this.lbl_Surname.Text = "Surname :";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(12, 91);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(84, 13);
            this.lbl_PhoneNumber.TabIndex = 3;
            this.lbl_PhoneNumber.Text = "Phone Number :";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(12, 131);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(41, 13);
            this.lbl_Email.TabIndex = 5;
            this.lbl_Email.Text = "E-mail :";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(12, 246);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(59, 13);
            this.lbl_Password.TabIndex = 6;
            this.lbl_Password.Text = "Password :";
            // 
            // lbl_PasswordAgain
            // 
            this.lbl_PasswordAgain.AutoSize = true;
            this.lbl_PasswordAgain.Location = new System.Drawing.Point(12, 283);
            this.lbl_PasswordAgain.Name = "lbl_PasswordAgain";
            this.lbl_PasswordAgain.Size = new System.Drawing.Size(59, 13);
            this.lbl_PasswordAgain.TabIndex = 7;
            this.lbl_PasswordAgain.Text = "Password :";
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(125, 21);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(134, 20);
            this.tbx_Name.TabIndex = 8;
            // 
            // tbx_Surname
            // 
            this.tbx_Surname.Location = new System.Drawing.Point(125, 53);
            this.tbx_Surname.Name = "tbx_Surname";
            this.tbx_Surname.Size = new System.Drawing.Size(134, 20);
            this.tbx_Surname.TabIndex = 9;
            // 
            // tbx_PhoneNo
            // 
            this.tbx_PhoneNo.Location = new System.Drawing.Point(125, 88);
            this.tbx_PhoneNo.Name = "tbx_PhoneNo";
            this.tbx_PhoneNo.Size = new System.Drawing.Size(134, 20);
            this.tbx_PhoneNo.TabIndex = 11;
            // 
            // tbx_Email
            // 
            this.tbx_Email.Location = new System.Drawing.Point(125, 128);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(134, 20);
            this.tbx_Email.TabIndex = 12;
            // 
            // tbx_Password
            // 
            this.tbx_Password.Location = new System.Drawing.Point(125, 243);
            this.tbx_Password.Name = "tbx_Password";
            this.tbx_Password.Size = new System.Drawing.Size(134, 20);
            this.tbx_Password.TabIndex = 13;
            // 
            // tbx_PasswordAgain
            // 
            this.tbx_PasswordAgain.Location = new System.Drawing.Point(125, 280);
            this.tbx_PasswordAgain.Name = "tbx_PasswordAgain";
            this.tbx_PasswordAgain.Size = new System.Drawing.Size(134, 20);
            this.tbx_PasswordAgain.TabIndex = 14;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(146, 316);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(113, 38);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dtp_DateOfBirth
            // 
            this.dtp_DateOfBirth.Location = new System.Drawing.Point(90, 167);
            this.dtp_DateOfBirth.Name = "dtp_DateOfBirth";
            this.dtp_DateOfBirth.Size = new System.Drawing.Size(169, 20);
            this.dtp_DateOfBirth.TabIndex = 16;
            // 
            // lbl_DateOfBirth
            // 
            this.lbl_DateOfBirth.AutoSize = true;
            this.lbl_DateOfBirth.Location = new System.Drawing.Point(12, 173);
            this.lbl_DateOfBirth.Name = "lbl_DateOfBirth";
            this.lbl_DateOfBirth.Size = new System.Drawing.Size(72, 13);
            this.lbl_DateOfBirth.TabIndex = 17;
            this.lbl_DateOfBirth.Text = "Date of Birth :";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Location = new System.Drawing.Point(12, 208);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(48, 13);
            this.lbl_Gender.TabIndex = 18;
            this.lbl_Gender.Text = "Gender :";
            // 
            // cbx_Gender
            // 
            this.cbx_Gender.FormattingEnabled = true;
            this.cbx_Gender.Location = new System.Drawing.Point(125, 205);
            this.cbx_Gender.Name = "cbx_Gender";
            this.cbx_Gender.Size = new System.Drawing.Size(134, 21);
            this.cbx_Gender.TabIndex = 19;
            // 
            // Form_AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 356);
            this.Controls.Add(this.cbx_Gender);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_DateOfBirth);
            this.Controls.Add(this.dtp_DateOfBirth);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tbx_PasswordAgain);
            this.Controls.Add(this.tbx_Password);
            this.Controls.Add(this.tbx_Email);
            this.Controls.Add(this.tbx_PhoneNo);
            this.Controls.Add(this.tbx_Surname);
            this.Controls.Add(this.tbx_Name);
            this.Controls.Add(this.lbl_PasswordAgain);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_PhoneNumber);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.lbl_Name);
            this.Name = "Form_AddCustomer";
            this.Text = "Form_AddCustomer";
            this.Load += new System.EventHandler(this.Form_AddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_PasswordAgain;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.TextBox tbx_Surname;
        private System.Windows.Forms.TextBox tbx_PhoneNo;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.TextBox tbx_Password;
        private System.Windows.Forms.TextBox tbx_PasswordAgain;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DateTimePicker dtp_DateOfBirth;
        private System.Windows.Forms.Label lbl_DateOfBirth;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.ComboBox cbx_Gender;
    }
}