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
    }
}
