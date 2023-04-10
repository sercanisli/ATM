
namespace ATM
{
    partial class Form_CreditCardApplication
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
            this.cbx_Limit = new System.Windows.Forms.ComboBox();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.lbl_SelectLimit = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_Limit
            // 
            this.cbx_Limit.FormattingEnabled = true;
            this.cbx_Limit.Location = new System.Drawing.Point(119, 20);
            this.cbx_Limit.Name = "cbx_Limit";
            this.cbx_Limit.Size = new System.Drawing.Size(150, 21);
            this.cbx_Limit.TabIndex = 0;
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(165, 63);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(104, 47);
            this.btn_Apply.TabIndex = 1;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // lbl_SelectLimit
            // 
            this.lbl_SelectLimit.AutoSize = true;
            this.lbl_SelectLimit.Location = new System.Drawing.Point(12, 23);
            this.lbl_SelectLimit.Name = "lbl_SelectLimit";
            this.lbl_SelectLimit.Size = new System.Drawing.Size(67, 13);
            this.lbl_SelectLimit.TabIndex = 2;
            this.lbl_SelectLimit.Text = "Select Limit :";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 63);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(104, 47);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Form_CreditCardApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 124);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_SelectLimit);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.cbx_Limit);
            this.Name = "Form_CreditCardApplication";
            this.Text = "Form_CreditCardApplication";
            this.Load += new System.EventHandler(this.Form_CreditCardApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Limit;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Label lbl_SelectLimit;
        private System.Windows.Forms.Button btn_Back;
    }
}