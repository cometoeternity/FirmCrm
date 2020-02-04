using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmCrm.BL.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
        public override string ToString()
        {
            return $"ID сотрудника - {EmployeeId}, Фамилия и Имя сотрудника - {Surname} {Name} ";
        }
    }
}
