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
    public partial class Form_PaymentTransaction : Form
    {
        public Form_PaymentTransaction()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_With_Card form_With_Card = new Form_With_Card();
            form_With_Card.Show();
            this.Close();
        }

        private void btn_Bills_Click(object sender, EventArgs e)
        {
            Form_Bills form_Bills = new Form_Bills();
            form_Bills.Show();
            this.Close();
        }
    }
}
