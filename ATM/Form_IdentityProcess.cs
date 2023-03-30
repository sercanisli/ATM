using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Abstract;
using Entities.Concrete;

namespace ATM
{
    public partial class Form_IdentityProcess : Form
    {
        private ICustomerService _customerService;
        public Form_IdentityProcess()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private AccountInformation accountInformation = new AccountInformation();


        private void btn_GoWithCards_Click(object sender, EventArgs e)
        {
            User.UserNo = Convert.ToInt32(tbx_CustomerNo.Text);
            var result =_customerService.GetCustomer(User.UserNo, tbx_CustomerPassword.Text);
            var customer=_customerService.GetCustomerById(User.UserNo);
            if (result==true)
            {
                this.Close();
                Form_With_Card formWithCard = new Form_With_Card();
                formWithCard.Show();
                User.UserId = customer.Id;
            }
            else
            {
                MessageBox.Show("Customer Number or Customer Password is incorrect");
            }


        }
    }
}
