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
    public partial class Form_Investment : Form
    {
        private ICustomerService _customerService;
        public Form_Investment()
        {
            InitializeComponent();

            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }
        private void LoadMoney()
        {
            
            var account = _customerService.GetMoneyById(User.UserId);
            if(account==null)
            {
                lbl_Money.Text = "0";
            }
            else
            {
                lbl_Money.Text = account.Money.ToString();
            }
        }
        private void btn_Investment_Click(object sender, EventArgs e)
        {
            var isExistsForMoneyProcess = _customerService.IsExistsForMoneyProcess(User.UserId);
            if (isExistsForMoneyProcess==true)
            {
                _customerService.UpdateMoneyProcess(new AccountInformation
                { 
                    Money = Convert.ToDecimal(nmUD_Amount.Text)
                }, User.UserId);
                MessageBox.Show("Your account updated");
            }
            else
            { 
                _customerService.AddMoneyProcess(new AccountInformation
                {
                    Money = Convert.ToDecimal(nmUD_Amount.Text),
                    CustomerNo = User.UserNo,
                    CreatedDate = DateTime.Now.ToShortDateString(),
                    CustomerId = User.UserId
                });
            }
            LoadMoney();
        }

        private void Form_Investment_Load(object sender, EventArgs e)
        {
            LoadMoney();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_WithdrawAndDepositMoney withdrawAndDepositMoney = new Form_WithdrawAndDepositMoney();
            withdrawAndDepositMoney.Show();
            this.Close();
        }
    }
}
