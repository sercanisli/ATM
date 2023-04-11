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
    public partial class Form_MoneyTransfer : Form
    {
        public Form_MoneyTransfer()
        {
            InitializeComponent();
        }

        private void btn_OurCustomer_Click(object sender, EventArgs e)
        {
            Form_MoneyTransferOurCustomer moneyTransferOurCustomer = new Form_MoneyTransferOurCustomer();
            moneyTransferOurCustomer.Show();
            this.Close();
        }

        private void btn_NotOurCustomer_Click(object sender, EventArgs e)
        {
            Form_NotOurCustomer notOurCustomer = new Form_NotOurCustomer();
            notOurCustomer.Show();
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_With_Card with_Card = new Form_With_Card();
            with_Card.Show();
            this.Close();
        }

        private void Form_MoneyTransfer_Load(object sender, EventArgs e)
        {

        }
    }
}
