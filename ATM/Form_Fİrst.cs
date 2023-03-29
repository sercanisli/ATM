using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Concrete.Context;

namespace ATM
{
    public partial class Form_First : Form
    {
        public Form_First()
        {
            InitializeComponent();
        }
        private void Form_First_Load(object sender, EventArgs e)
        {
            //BankContext bankContext =new BankContext();
            //bankContext.Database.Create();
        }

        private void btn_Without_Card_Click(object sender, EventArgs e)
        {
            Form_Without_Card formWithoutCard = new Form_Without_Card();
            formWithoutCard.Show();

        }

        private void btn_With_Card_Click(object sender, EventArgs e)
        {
            Form_IdentityProcess formIdentityProcess = new Form_IdentityProcess();
            formIdentityProcess.Show();
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            Form_AddCustomer formAddCustomer = new Form_AddCustomer();
            formAddCustomer.Show();
        }
    }
}
