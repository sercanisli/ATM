using Business.Abstract;
using Business.DependencyResolvers.Ninject;
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
    public partial class Form_NonCustomerMoneyTransfer : Form
    {
        private INonCustomerService _nonCustomerService;
        public Form_NonCustomerMoneyTransfer()
        {
            InitializeComponent();

            _nonCustomerService = InstanceFactory.GetInstance<INonCustomerService>();
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
           if(_nonCustomerService.IsItOurCustomer(Convert.ToInt32(tbx_CustomerNo.Text))==true)
           {
                _nonCustomerService.TransferMoney(new AccountInformation
                {
                    Money = Convert.ToDecimal(nmUD_Money.Value)
                }, Convert.ToInt32(tbx_CustomerNo.Text));
           }
            _nonCustomerService.AddNonCustomer(new NonCustomer
            {
                CreatedDate = DateTime.Now.ToShortDateString(),
                IsDeleted = false,
                Name = tbx_Name.Text,
                Surname = tbx_Surname.Text,
                PhoneNo = tbx_PhoneNo.Text,
                IdentityNo = tbx_IdentityNo.Text,
                Amount = nmUD_Money.Value
            }) ;
            MessageBox.Show("Transfer is done");
        }
    }
}
