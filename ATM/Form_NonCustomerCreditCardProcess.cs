using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Abstract;
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
    public partial class Form_NonCustomerCreditCardProcess : Form
    {
        private INonCustomerService _nonCustomerService;
        public Form_NonCustomerCreditCardProcess()
        {
            InitializeComponent();
            _nonCustomerService = InstanceFactory.GetInstance<INonCustomerService>();

        }

        private void btn_GetCard_Click(object sender, EventArgs e)
        {
            if(_nonCustomerService.IsItOurCard(Convert.ToInt32(tbx_CardNo.Text))==true)
            {
                Card.CardNo = Convert.ToInt32(tbx_CardNo.Text);
                Form_PayCreditCardNonCustomer payCreditCardNonCustomer = new Form_PayCreditCardNonCustomer();
                payCreditCardNonCustomer.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("This card is not registered");
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_WithoutCard form_WithoutCard = new Form_WithoutCard();
            form_WithoutCard.Show();
            this.Close();
        }
    }
}
