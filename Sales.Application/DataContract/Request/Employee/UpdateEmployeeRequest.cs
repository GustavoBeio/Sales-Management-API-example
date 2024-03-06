using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Application.DataContract.Request.Employee
{
    public class UpdateEmployeeRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string Passwordhash { get; set; } = string.Empty;
    }
}
