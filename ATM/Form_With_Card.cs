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
    public partial class Form_With_Card : Form
    {
        public Form_With_Card()
        {
            InitializeComponent();
        }

        private void btn_WithCard_WithdrawMoney_Click(object sender, EventArgs e)
        {
            Form_WithdrawAndDepositMoney formWithdrawAndDepositMoney = new Form_WithdrawAndDepositMoney();
            formWithdrawAndDepositMoney.Show();
            this.Close();
        }

        private void btn_BalanceInformaion_Click(object sender, EventArgs e)
        {
            Form_BalanceInformation formBalanceInformation = new Form_BalanceInformation();
            formBalanceInformation.Show();
            this.Close();
        }

        private void btn_WithCard_MoneyTransfers_Click(object sender, EventArgs e)
        {
            Form_MoneyTransfer form_MoneyTransfer = new Form_MoneyTransfer();
            form_MoneyTransfer.Show();
            this.Close();
        }

        private void btn_PaymentTransaction_Click(object sender, EventArgs e)
        {
            Form_PaymentTransaction form_PaymentTransaction = new Form_PaymentTransaction();
            form_PaymentTransaction.Show();
            this.Close();
        }

        private void btn_WithCard_CreditCardDebtPayment_Click(object sender, EventArgs e)
        {
            Form_CreditCardTransaction form_CreditCardTransaction = new Form_CreditCardTransaction();
            form_CreditCardTransaction.Show();
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
