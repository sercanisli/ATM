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
    public partial class Form_Bills : Form
    {
        private IBillService _billService;
        public Form_Bills()
        {
            InitializeComponent();
            _billService = InstanceFactory.GetInstance<IBillService>();
        }

        public void GetBillsToCombo()
        {
            cbx_Bills.DataSource = _billService.GetBillItem();
            cbx_Bills.DisplayMember = "Name";
            cbx_Bills.ValueMember = "Id";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_PaymentTransaction form_PaymentTransaction = new Form_PaymentTransaction();
            form_PaymentTransaction.Show();
            this.Close();
        }

        private void Form_Bills_Load(object sender, EventArgs e)
        {
            GetBillsToCombo();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            BillStatic.BillsId = Convert.ToByte(cbx_Bills.SelectedIndex + 1);
            var bill = _billService.GetBillById(BillStatic.BillsId);
            decimal billPrice = bill.Price;
            var result = _billService.IsCutomerHaveBill(User.UserId, Convert.ToInt32(cbx_Bills.SelectedIndex)+1);
            if (result == true && billPrice > 0 )
            {
                Form_PayBill payBill = new Form_PayBill();
                payBill.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You don't have owe");
            }
        }
    }
}
