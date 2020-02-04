using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmCrm.BL.Model
{
    public class Customers
    {
        public int CustomersId { get; set; }
        public string CustomersName { get; set; }
        public int PhoneNumber { get; set; }
        public ICollection<Order> Orders { get; set; }
        public override string ToString()
        {
            return $"ID заказчика - {CustomersId} Название фирмы заказчика - {CustomersName}";
        }
    }
}
