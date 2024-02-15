using Sales.Domain.Interfaces.Services;
using Sales.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Services
{
    public class ProductOrderServices : IProductOrderServices
    {
        public Task CreateAsync(ProductOrderModel productOrder)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string productOrderId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductOrderModel> GetbyIdAsync(string productOrderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductOrderModel>> ListbyFilterAsync(string productOrderId, string clientId, string employeeId)
        {
            throw new NotImplementedException();
        }

        public Task UpdadteAsync(ProductOrderModel productOrder)
        {
            throw new NotImplementedException();
        }
    }
}
