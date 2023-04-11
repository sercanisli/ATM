using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Abstract;
using Entities.Concrete;
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
    public partial class Form_PayCreditCardNonCustomer : Form
    {
        private ICreditCardService _creditCardService;
        private INonCustomerService _nonCustomerService;
        public Form_PayCreditCardNonCustomer()
        {
            InitializeComponent();

            _creditCardService = InstanceFactory.GetInstance<ICreditCardService>();
            _nonCustomerService = InstanceFactory.GetInstance<INonCustomerService>();

        }
        public void LoadDebt()
        {
            var creditCard = _creditCardService.GetCreditCardByCardNo(Card.CardNo);

            lbl_No.Text = creditCard.CardNo.ToString();
            lbl_Debt.Text = creditCard.Debt.ToString();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_NonCustomerCreditCardProcess form_NonCustomerCreditCardProcess = new Form_NonCustomerCreditCardProcess();
            form_NonCustomerCreditCardProcess.Show();
            this.Close();
        }

        private void Form_PayCreditCardNonCustomer_Load(object sender, EventArgs e)
        {
            LoadDebt();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            decimal debt = Convert.ToDecimal(lbl_Debt.Text);
            debt = debt - debt;
            _nonCustomerService.PayCreditCard(new CreditCard
            {

            }, Convert.ToInt32(lbl_No.Text), debt);
            LoadDebt();
        }
    }
}
