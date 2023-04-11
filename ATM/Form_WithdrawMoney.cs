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
    public partial class Form_WithdrawMoney : Form
    {
        private ICustomerService _customerService;

        public Form_WithdrawMoney()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();

        }
        private void LoadMoney()
        {
            var account = _customerService.GetMoneyById(User.UserId);
            decimal money = account.Money;
            if(money==0)
            {
                lbl_Money.Text = "0";
            }
            lbl_Money.Text = account.Money.ToString();
        }

        private void btn_Draw_Click(object sender, EventArgs e)
        {
            _customerService.DrawMoney(new AccountInformation
            {
                Money = Convert.ToDecimal(nmUD_Amount.Text)
            }, User.UserId);

            LoadMoney();
        }

        private void Form_WithdrawMoney_Load(object sender, EventArgs e)
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
