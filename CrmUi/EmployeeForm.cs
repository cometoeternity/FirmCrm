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
    public partial class EmployeeForm : Form
    {
        public Employee Employee { get; set; }
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee = Employee ?? new Employee();
            Employee.Surname = textBox1.Text;
            Employee.Name = textBox2.Text;
            Close();
        }
    }
}
