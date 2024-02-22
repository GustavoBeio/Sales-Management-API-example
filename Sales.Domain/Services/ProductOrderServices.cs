using Sales.Domain.Interfaces.Services;
using Sales.Domain.Models;
using Sales.Domain.Validations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Services
{
    public class ProductOrderServices : IProductOrderServices
    {
        public Task<Response> CreateAsync(ProductOrderModel productOrder)
        {
            throw new NotImplementedException();
        }

        public Task<Response> DeleteAsync(string productOrderId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<ProductOrderModel>> GetbyIdAsync(string productOrderId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ProductOrderModel>>> ListbyFilterAsync(string productOrderId, string clientId, string employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdadteAsync(ProductOrderModel productOrder)
        {
            throw new NotImplementedException();
        }
    }
}
