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
    public partial class Form_BalanceInformation : Form
    {
        private ICustomerService _customerService;
        public Form_BalanceInformation()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }
        private void LoadBalanceInformation()
        {
            var customer = _customerService.GetCustomerById(User.UserNo);
            lbl_Name.Text = customer.Name;
            lbl_Surname.Text = customer.Surname;
            lbl_Phone.Text = customer.PhoneNo;
            lbl_Email.Text = customer.Email;
            lbl_Date.Text = customer.BirthDay.ToString();
            lbl_GenderSide.Text = customer.Gender.ToString();

            var account = _customerService.GetMoneyById(User.UserId);
            lbl_Money.Text = account.Money.ToString();
            lbl_DeficitMoney.Text = (3000 + account.Money).ToString();
        }
        private void Form_BalanceInformation_Load(object sender, EventArgs e)
        {
            LoadBalanceInformation();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_With_Card with_Card = new Form_With_Card();
            with_Card.Show();
            this.Close();
        }
    }
}
