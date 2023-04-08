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
    public partial class Form_PayBill : Form
    {
        decimal money = 0;
        decimal billPrice = 0;
        private ICustomerService _customerService;
        private IBillService _billService;
        public Form_PayBill()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _billService = InstanceFactory.GetInstance<IBillService>();
        }
        private void LoadMoney()
        {
            var result = _customerService.GetMoneyById(User.UserId);
            money = result.Money;
            lbl_Money.Text = result.Money.ToString();
        }
        private void LoadBill()
        {
            var result = _billService.GetBillById(BillStatic.BillsId);
            billPrice = result.Price;
            lbl_Amount.Text = result.Price.ToString();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_Bills form_Bills = new Form_Bills();
            form_Bills.Show();
            this.Close();
        }

        private void Form_PayBill_Load(object sender, EventArgs e)
        {
            LoadBill();
            LoadMoney();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if(billPrice>money)
            {
                MessageBox.Show("You don't have enough money");
            }
            else
            {
                _customerService.DrawMoney(new AccountInformation
                {
                    Money =  Convert.ToDecimal(lbl_Amount.Text)
                },User.UserId);
                _billService.PayBill(new PayBill
                {
                    Price = Convert.ToDecimal(lbl_Amount.Text)
                }, User.UserId);
                LoadBill();
                LoadMoney();
            }
        }
    }
}
