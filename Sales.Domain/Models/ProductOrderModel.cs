using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Models
{
    public class ProductOrderModel : EntityBase
    {
        public ClientModel Client { get; set; }
        public EmployeeModel Employee { get; set; }
    }
}
