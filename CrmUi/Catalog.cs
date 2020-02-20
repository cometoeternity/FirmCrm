using FirmCrm.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class Catalog<T> : Form
                            where T : class
    {
        CrmContext db;
        DbSet<T> set;
        public Catalog(DbSet<T> set, CrmContext db)
        {
            InitializeComponent();
            this.db = db;
            this.set = set;
            set.Load();
            dataGridView1.DataSource = set.Local.ToBindingList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = dataGridView1.SelectedRows[0].Cells[0].Value;
            if (typeof(T) == typeof(Product))
            {
                if (set.Find(id) is Product product)
                {
                    var form = new ProductForm(product);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        product = form.Product;
                    }
                }
                if (typeof(T) == typeof(Employee))
                {
                    if (set.Find(id) is Employee employee)
                    {
                        var form = new EmployeeForm(employee);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            employee = form.Employee;
                        }
                    }
                }
                if (typeof(T) == typeof(Customer))
                {
                    if (set.Find(id) is Customer customer)
                    {
                        var form = new CustomerForm(customer);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            customer = form.Customer;
                        }
                    }
                }
            }
            db.SaveChanges();
            dataGridView1.Update();
        }
    }
}
