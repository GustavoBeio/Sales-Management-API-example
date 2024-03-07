using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Application.DataContract.Request.Product
{
    public class UpdateProductRequest
    {
        public string Description { get; set; } = string.Empty;
        public decimal Sellvalue { get; set; }
        public int Stock { get; set; }
    }
}
