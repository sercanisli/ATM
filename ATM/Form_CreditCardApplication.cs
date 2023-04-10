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
    public partial class Form_CreditCardApplication : Form
    {
        private ICardLimitService _cardLimitService;
        private ICreditCardService _creditCardService;
        public Form_CreditCardApplication()
        {
            InitializeComponent();
            _cardLimitService = InstanceFactory.GetInstance<ICardLimitService>();
            _creditCardService = InstanceFactory.GetInstance<ICreditCardService>();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_CreditCardTransaction creditCardTransaction = new Form_CreditCardTransaction();
            creditCardTransaction.Show();
            this.Close();
        }
        public void GetCardLimitToCombo()
        {
            cbx_Limit.DataSource = _cardLimitService.GetCardLimitItem();
            cbx_Limit.DisplayMember = "Limit";
            cbx_Limit.ValueMember = "Id";
        }
        private void Form_CreditCardApplication_Load(object sender, EventArgs e)
        {
            GetCardLimitToCombo();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            _creditCardService.ApplyCreditCard(new CreditCard
            {
                CustomerId = User.UserId,
                CreatedDate = DateTime.Now.ToShortDateString(),
                IsDeleted = false,
                CardLimitId = (byte)(cbx_Limit.SelectedIndex+1)
            }) ;
            MessageBox.Show("Apply is done");
        }
    }
}
