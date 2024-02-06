using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Models
{
    public class ProductOrderItemModel : EntityBase
    {
        public ProductOrderModel ProductOrder { get; set; }
        public ProductModel Product { get; set; }
        public decimal Sellvalue { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
