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
    public partial class Form_Investment : Form
    {
        private ICustomerService _customerService;
        public Form_Investment()
        {
            InitializeComponent();

            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private void btn_Investment_Click(object sender, EventArgs e)
        {
            _customerService.AddMoney(new AccountInformation
            {
                Money =  Convert.ToDecimal(nmUD_Amount.Text)
            });
            MessageBox.Show("Succesful");
        }
    }
}
