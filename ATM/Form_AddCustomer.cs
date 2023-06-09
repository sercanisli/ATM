﻿using Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;

namespace ATM
{
    public partial class Form_AddCustomer : Form
    {
        private ICustomerService _customerService;

        public Form_AddCustomer()
        {
            InitializeComponent();

            _customerService = InstanceFactory.GetInstance<ICustomerService>();

        }

        public void GetGenderToCombo()
        {
            string[] gender = Enum.GetNames(typeof(Gender));
            cbx_Gender.Items.AddRange(gender);
        }
        public void Clear()
        {
            tbx_Name.Clear();
            tbx_Surname.Clear();
            tbx_PhoneNo.Clear();
            tbx_Email.Clear();
            tbx_Password.Clear();
            tbx_PasswordAgain.Clear();
            dtp_DateOfBirth.Value = DateTime.Now;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbx_Password.Text == tbx_PasswordAgain.Text)
                {

                    _customerService.Add(new Customer
                    {
                        Name = tbx_Name.Text,
                        Surname = tbx_Surname.Text,
                        PhoneNo = tbx_PhoneNo.Text,
                        Email = tbx_Email.Text,
                        Password = tbx_Password.Text,
                        Gender = (Gender)cbx_Gender.SelectedIndex,
                        BirthDay = dtp_DateOfBirth.Value,
                        CreatedDate = DateTime.Now.ToShortDateString()
                    });
                    MessageBox.Show("Customer created");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Şifre eşleşmedi");
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Form_AddCustomer_Load(object sender, EventArgs e)
        {
            GetGenderToCombo();
        }
    }
}
