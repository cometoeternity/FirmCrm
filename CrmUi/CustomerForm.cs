﻿using FirmCrm.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class CustomerForm : Form
    {
        public Customer Customer { get; set; }
        public CustomerForm()
        {
            InitializeComponent();
        }
        public CustomerForm(Customer customer):this()
        {
            Customer = customer ?? new Customer();
            textBox1.Text = Customer.CustomerName;
            textBox2.Text = Customer.PhoneNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer = Customer ?? new Customer();
            Customer.CustomerName = textBox1.Text;
            Customer.PhoneNumber =Convert.ToInt32(textBox2.Text);
            Close();
        }
    }
}
