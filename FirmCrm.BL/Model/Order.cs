using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmCrm.BL.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customers Customers { get; set; }
        public DateTime Created { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set;}
        public ICollection<Ordered> Ordereds { get; set; }
        
    }
}
