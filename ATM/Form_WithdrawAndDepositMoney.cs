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
    public partial class Form_WithdrawAndDepositMoney : Form
    {
        public Form_WithdrawAndDepositMoney()
        {
            InitializeComponent();
        }

        private void btn_WithdrawMoney_Click(object sender, EventArgs e)
        {
            Form_WithdrawMoney formWithdrawMoney = new Form_WithdrawMoney();
            formWithdrawMoney.Show();
        }

        private void btn_Investment_Click(object sender, EventArgs e)
        {
            Form_Investment formInvestment = new Form_Investment();
            formInvestment.Show();
        }
    }
}
