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

        private void btn_GoWithCards_Click(object sender, EventArgs e)
        {
            var result=_customerService.GetCustomer(tbx_CustomerNo.Text, tbx_CustomerPassword.Text);
            if (result==true)
            {
                this.Close();
                Form_With_Card formWithCard = new Form_With_Card();
                formWithCard.Show();
            }
            else
            {
                MessageBox.Show("Customer Number or Customer Password is incorrect");
            }

            
        }
    }
}
