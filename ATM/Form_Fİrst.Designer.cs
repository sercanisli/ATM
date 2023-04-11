
namespace ATM
{
    partial class Form_First
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
            this.btn_Without_Card = new System.Windows.Forms.Button();
            this.btn_With_Card = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Without_Card
            // 
            this.btn_Without_Card.Location = new System.Drawing.Point(12, 93);
            this.btn_Without_Card.Name = "btn_Without_Card";
            this.btn_Without_Card.Size = new System.Drawing.Size(143, 53);
            this.btn_Without_Card.TabIndex = 0;
            this.btn_Without_Card.Text = "Non-Customer";
            this.btn_Without_Card.UseVisualStyleBackColor = true;
            this.btn_Without_Card.Click += new System.EventHandler(this.btn_Without_Card_Click);
            // 
            // btn_With_Card
            // 
            this.btn_With_Card.Location = new System.Drawing.Point(192, 93);
            this.btn_With_Card.Name = "btn_With_Card";
            this.btn_With_Card.Size = new System.Drawing.Size(143, 53);
            this.btn_With_Card.TabIndex = 1;
            this.btn_With_Card.Text = "Customer";
            this.btn_With_Card.UseVisualStyleBackColor = true;
            this.btn_With_Card.Click += new System.EventHandler(this.btn_With_Card_Click);
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Location = new System.Drawing.Point(192, 12);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(143, 53);
            this.btn_AddCustomer.TabIndex = 2;
            this.btn_AddCustomer.Text = "I Want To Be Customer";
            this.btn_AddCustomer.UseVisualStyleBackColor = true;
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // Form_First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 157);
            this.Controls.Add(this.btn_AddCustomer);
            this.Controls.Add(this.btn_With_Card);
            this.Controls.Add(this.btn_Without_Card);
            this.Name = "Form_First";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form_First_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Without_Card;
        private System.Windows.Forms.Button btn_With_Card;
        private System.Windows.Forms.Button btn_AddCustomer;
    }
}

