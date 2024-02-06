using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Models
{
    public class EmployeeModel : EntityBase
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Passwordhash { get; set; }
    }
}
