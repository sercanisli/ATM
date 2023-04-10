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
    public partial class Form_CreditCardDebt : Form
    {
        private ICreditCardService _creditCardService;
        private ICustomerService _customerService;
        public Form_CreditCardDebt()
        {
            InitializeComponent();
            _creditCardService = InstanceFactory.GetInstance<ICreditCardService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_CreditCardTransaction creditCardTransaction = new Form_CreditCardTransaction();
            creditCardTransaction.Show();
            this.Close();
        }
        private void LoadCreditCard()
        {
            var creditCard = _creditCardService.GetByCreditCardId(User.UserId);
            var customer = _customerService.GetMoneyById(User.UserId);

            lbl_No.Text = creditCard.CardNo.ToString();
            lbl_Money.Text = customer.Money.ToString();
            lbl_Debt.Text = creditCard.Debt.ToString();
            lbl_MinimumDebt.Text = (creditCard.Debt * (40M / 100M)).ToString();
            lbl_Limit.Text = creditCard.CardLimit.Limit.ToString();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if(rdb_MinimumPayment.Checked==true || rdb_PayAll.Checked==true)
            {
                decimal debt = Convert.ToDecimal(lbl_Debt.Text);
                if (rdb_MinimumPayment.Checked == true)
                {
                    PaymentPreference.Preference = 1;
                }
                if (rdb_PayAll.Checked == true)
                {
                    PaymentPreference.Preference = 2;
                }
                _creditCardService.PayCreditCardDebt(new AccountInformation
                {
                    Money = Convert.ToDecimal(lbl_Money.Text)
                }, User.UserId, PaymentPreference.Preference, debt);

                _creditCardService.LoadDebt(new CreditCard 
                {
                    
                } ,User.UserId, PaymentPreference.Preference, debt);
                LoadCreditCard();

            }
            else
            {
                MessageBox.Show("Please choose a payment type");
            }
        }

        private void Form_CreditCardDebt_Load(object sender, EventArgs e)
        {
            LoadCreditCard();
        }
    }
}
