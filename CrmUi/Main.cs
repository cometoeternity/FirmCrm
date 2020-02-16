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
            var catalogProduct = new Catalog<Product>(db.Products);
            catalogProduct.Show();
        }

        private void OrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogOrder = new Catalog<Order>(db.Orders);
            catalogOrder.Show();
        }

        private void OrderedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogOrdered = new Catalog<Ordered>(db.Ordereds);
            catalogOrdered.Show();
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogEmployee = new Catalog<Employee>(db.Employees);
            catalogEmployee.Show();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCustomers = new Catalog<Customer>(db.Customers);
            catalogCustomers.Show();
        }
    }
}
