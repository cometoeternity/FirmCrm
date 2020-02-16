using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmCrm.BL.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int PhoneNumber { get; set; }
        public ICollection<Order> Orders { get; set; }
        public override string ToString()
        {
            return $"ID заказчика - {CustomerId} Название фирмы заказчика - {CustomerName}";
        }
    }
}
