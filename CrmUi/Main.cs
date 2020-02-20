using FirmCrm.BL.Model;
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
    public partial class Main : Form
    {
        CrmContext db;
        public Main()
        {
            db = new CrmContext();
            InitializeComponent();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Products,db);
            catalogProduct.Show();
        }

        private void OrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogOrder = new Catalog<Order>(db.Orders,db);
            catalogOrder.Show();
        }

        private void OrderedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogOrdered = new Catalog<Ordered>(db.Ordereds,db);
            catalogOrdered.Show();
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogEmployee = new Catalog<Employee>(db.Employees,db);
            catalogEmployee.Show();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCustomers = new Catalog<Customer>(db.Customers,db);
            catalogCustomers.Show();
        }

        private void productAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if(form.ShowDialog()==DialogResult.OK)
            {
                db.Products.Add(form.Product);
                db.SaveChanges();
            }
        }

        private void orderAddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new OrderForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Orders.Add(form.Order);
                db.SaveChanges();
            }
        }

        private void orderedAddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new OrderedForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Ordereds.Add(form.Ordered);
                db.SaveChanges();
            }
        }

        private void employeeAddToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var form = new EmployeeForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Employees.Add(form.Employee);
                db.SaveChanges();
            }
        }

        private void customerAddToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }
        }
    }
}
