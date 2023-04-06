﻿using Business.Abstract;
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
    public partial class Form_NotOurCustomer : Form
    {
        private ICustomerService _customerService;

        public Form_NotOurCustomer()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }
        private void LoadMoney()
        {
            var money = _customerService.GetMoneyById(User.UserId);
            lbl_Money.Text = money.Money.ToString();
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            _customerService.DrawMoney(new AccountInformation
            {
                Money = Convert.ToDecimal(nmUD_Money.Value)
            }, User.UserId);
            MessageBox.Show("Transfer is done");
            LoadMoney();
        }

        private void Form_NotOurCustomer_Load(object sender, EventArgs e)
        {
            LoadMoney();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_MoneyTransfer moneyTransfer = new Form_MoneyTransfer();
            moneyTransfer.Show();
            this.Close();
        }
    }
}
