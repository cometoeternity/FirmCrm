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
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }
        public ProductForm()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product = Product ?? new Product();
            Product.Name = textBox1.Text;
            Product.Price = Convert.ToDecimal(numericUpDown1);
            Product.Count = Convert.ToInt32(numericUpDown2);
            Close();
        }
    }
}
