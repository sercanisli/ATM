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
    public partial class Form_CreditCardTransaction : Form
    {
        public Form_CreditCardTransaction()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_With_Card form_With_Card = new Form_With_Card();
            form_With_Card.Show();
            this.Close();
        }

        private void btn_CreditCardDebt_Click(object sender, EventArgs e)
        {
            Form_CreditCardDebt creditCardDebt = new Form_CreditCardDebt();
            creditCardDebt.Show();
            this.Close();
        }

        private void btn_CreditCardApplication_Click(object sender, EventArgs e)
        {
            Form_CreditCardApplication creditCardApplication = new Form_CreditCardApplication();
            creditCardApplication.Show();
            this.Close();
        }
    }
}
