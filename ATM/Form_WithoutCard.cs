using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form_WithoutCard : Form
    {
        public Form_WithoutCard()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MoneyTransfer_Click(object sender, EventArgs e)
        {
            Form_NonCustomerMoneyTransfer nonCustomerMoneyTransfer = new Form_NonCustomerMoneyTransfer();
            nonCustomerMoneyTransfer.Show();
            this.Close();
        }

        private void btn_CreditCardDebt_Click(object sender, EventArgs e)
        {
            Form_NonCustomerCreditCardProcess nonCustomerCreditCardProcess = new Form_NonCustomerCreditCardProcess();
            nonCustomerCreditCardProcess.Show();
            this.Close();
        }
    }
}
