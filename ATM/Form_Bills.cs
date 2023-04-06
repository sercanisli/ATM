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
    public partial class Form_Bills : Form
    {
        public Form_Bills()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_PaymentTransaction form_PaymentTransaction = new Form_PaymentTransaction();
            form_PaymentTransaction.Show();
            this.Close();
        }
    }
}
